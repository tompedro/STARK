using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STARK___Compiler_and_Debugger
{
    public partial class Form1 : Form
    {
        public int dimensions;
        public List<string> names;
        public bool isClass = false;
        public int nInd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            HighlightText("#DEFINE", Color.Orange);
            HighlightText("ARG", Color.Orange);
            HighlightText("act", Color.DeepSkyBlue);
            HighlightText("@init", Color.DarkGreen);
            HighlightText("@loop", Color.DarkGreen);
            HighlightText("@func", Color.DarkGreen);
            HighlightText("if", Color.DeepPink);
            HighlightText("for", Color.DeepPink);
            HighlightText("while", Color.DeepPink);
        }
        public void HighlightText(string word, Color color)
        {

            if (word == string.Empty)
                return;

            int s_start = code.SelectionStart, startIndex = 0, index;

            while ((index = code.Text.IndexOf(word, startIndex)) != -1)
            {
                code.Select(index, word.Length);
                code.SelectionColor = color;

                startIndex = index + word.Length;
            }

            code.SelectionStart = s_start;
            code.SelectionLength = 0;
            code.SelectionColor = Color.White;
        }
        
        private void CompileBTN_Click(object sender, EventArgs e)
        {
            python.Text = "";
            nInd = 0;
            foreach(String stringLine in code.Lines)
            {
                string s = stringLine;
                if (s.Contains("#DEFINE"))
                {
                    if (s.Contains("DIMENSIONS") && s.Contains("="))
                    {
                        s = stringLine.Replace(" ", "");
                        string sub = s.Substring(s.IndexOf("=") + 1, s.Length - s.IndexOf("=") - 1);
                        if (sub.Replace(" ", "") != "")
                        {
                            dimensions = Int32.Parse(s.Substring(s.IndexOf("=") + 1, s.Length - s.IndexOf("=") - 1));
                            nInd = 0;
                            writePython("dimensions = " + dimensions.ToString() + "\n");
                        }
                    }else if(s.Contains("NAME") && s.Contains("=") && s.Contains("ARG") && s.Contains("(") && s.Contains(")"))
                    {
                        string sub = s.Substring(s.IndexOf("=") + 1, s.Length - s.IndexOf("=") - 1);
                        string args = s.Substring(s.IndexOf("(") + 1, s.IndexOf(")") - s.IndexOf("(") - 1);
                        string sub2 = "";
                        if (args.Replace(" ","") != "")
                        {
                            
                            foreach (string a in args.Split(','))
                            {
                                sub2 += a.Split(' ')[1] + ",";
                            }
                            sub2 = sub2.Substring(0, sub2.Length - 1);
                            debug.Items.Add(sub2);
                        }
                        
                        if (sub.Replace(" ", "") != "" && sub2.Replace(" ", "") != "")
                        {
                            string name = s.Substring(s.IndexOf("=") + 1, s.IndexOf("ARG") - s.IndexOf("=") - 1);
                            nInd = 0;
                            writePython("class " + name + "(" + sub2 + "):\n");
                            isClass = true;
                            writePython("def __init__(self ," + sub2 + "):\n");
                            nInd = 1;
                            foreach(string arg in sub2.Split(','))
                            {
                                writePython("self." + arg + "=" + arg);
                            }
                            nInd = 0;
                        }
                    }
                }else if (s.Contains("act"))
                {
                    string name = s.Substring(s.IndexOf("t") + 1, s.IndexOf("@") - s.IndexOf("t") - 1);
                    string type = s.Substring(s.IndexOf("@") + 1, s.IndexOf("(") - s.IndexOf("@") - 1);
                    string rawArgs = s.Substring(s.IndexOf("(") + 1, s.IndexOf(")") - s.IndexOf("(") - 1);string args = "";
                    if(rawArgs != "")
                    {
                        args = "";
                        foreach (string a in rawArgs.Split(','))
                        {
                            args += a.Split(' ')[1] + ",";
                        }
                        args = args.Substring(0, args.Length - 1);
                    }
                    
                    if (type == "init")
                    {
                        writePython("def " + name + "():");
                        if (isClass)
                        {
                            bool found = false;
                            int i = 0;
                            foreach(string line in python.Lines)
                            {
                                if (line.Contains("__init__"))
                                {
                                    found = true;
                                }
                                else if(found && line.Contains("def"))
                                {
                                    debug.Items.Add(i.ToString());
                                    nInd++;
                                    python.Text = python.Text.Insert(i,"\n" +  name + "()");
                                    nInd--;
                                }
                                i += line.Length;
                            }
                        }
                        else
                        {
                            writePython(name + "()");
                        }
                    }
                    else if(type == "loop")
                    {
                        writePython("def " + name + "():");
                        if (isClass)
                        {
                            bool found = false;
                            int i = 0;
                            foreach (string line in python.Lines)
                            {
                                if (line.Contains("__init__"))
                                {
                                    found = true;
                                }
                                else if (found && line.Contains("def"))
                                {
                                    debug.Items.Add(i.ToString());
                                    nInd++;
                                    python.Text = python.Text.Insert(i, "\n while True:");
                                    nInd++;
                                    python.Text = python.Text.Insert(i, "\n" + name + "()");
                                    nInd -= 2;
                                }
                                i += line.Length;
                            }
                        }
                        else
                        {
                            writePython("while True:");
                            nInd++;
                            writePython(name + "()");
                            nInd--;
                        }
                    }else if(type == "func")
                    {
                        writePython("def " + name + "(" + args + "):");
                    }
                    nInd++;
                }else if (s.Contains("}"))
                {
                    nInd--;
                }
                else if (s.Contains("if"))
                {
                    string str ="";
                    foreach(char c in s)
                    {
                        if(c =='(' || c== ')'){
                            str += " ";
                        }else if(c == '£')
                        {
                            str += "and";
                        }
                        else if (c == '/')
                        {
                            str += "or";
                        }
                        else
                        {
                            str += c;
                        }
                    }
                    str += ":";
                    writePython(str);
                    nInd++;
                }
                else if(!s.Contains("{"))
                {
                    writePython(s.Replace(";",""));

                }
            }
        }

        public void writePython(string line)
        {
            if (isClass)
            {
                line = "    " + line;
            }
             if (nInd != 0)
            {
                int k = nInd;
                while(k > 0)
                {
                    line = "    " + line;
                    k--;
                }    
            }
            //debug.Items.Add(nInd.ToString());
            python.AppendText(line + "\n");
        }
    }
}
