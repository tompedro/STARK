namespace STARK___Compiler_and_Debugger
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.code = new System.Windows.Forms.RichTextBox();
            this.python = new System.Windows.Forms.RichTextBox();
            this.debug = new System.Windows.Forms.ListBox();
            this.compileBTN = new System.Windows.Forms.Button();
            this.runBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.ForeColor = System.Drawing.SystemColors.Control;
            this.code.Location = new System.Drawing.Point(12, 12);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(740, 426);
            this.code.TabIndex = 0;
            this.code.Text = "";
            this.code.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // python
            // 
            this.python.AccessibleName = "python";
            this.python.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.python.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.python.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.python.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.python.ForeColor = System.Drawing.SystemColors.Control;
            this.python.Location = new System.Drawing.Point(758, 12);
            this.python.Name = "python";
            this.python.Size = new System.Drawing.Size(553, 426);
            this.python.TabIndex = 1;
            this.python.Text = "";
            // 
            // debug
            // 
            this.debug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.debug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debug.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug.ForeColor = System.Drawing.SystemColors.Control;
            this.debug.FormattingEnabled = true;
            this.debug.ItemHeight = 18;
            this.debug.Location = new System.Drawing.Point(12, 496);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(1299, 108);
            this.debug.TabIndex = 2;
            // 
            // compileBTN
            // 
            this.compileBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compileBTN.BackColor = System.Drawing.Color.Maroon;
            this.compileBTN.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compileBTN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.compileBTN.Location = new System.Drawing.Point(12, 444);
            this.compileBTN.Name = "compileBTN";
            this.compileBTN.Size = new System.Drawing.Size(740, 36);
            this.compileBTN.TabIndex = 3;
            this.compileBTN.Text = "Compile";
            this.compileBTN.UseVisualStyleBackColor = false;
            this.compileBTN.Click += new System.EventHandler(this.CompileBTN_Click);
            // 
            // runBTN
            // 
            this.runBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runBTN.BackColor = System.Drawing.Color.ForestGreen;
            this.runBTN.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runBTN.ForeColor = System.Drawing.SystemColors.InfoText;
            this.runBTN.Location = new System.Drawing.Point(758, 444);
            this.runBTN.Name = "runBTN";
            this.runBTN.Size = new System.Drawing.Size(553, 36);
            this.runBTN.TabIndex = 4;
            this.runBTN.Text = "Run";
            this.runBTN.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1323, 625);
            this.Controls.Add(this.runBTN);
            this.Controls.Add(this.compileBTN);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.python);
            this.Controls.Add(this.code);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox code;
        private System.Windows.Forms.RichTextBox python;
        private System.Windows.Forms.ListBox debug;
        private System.Windows.Forms.Button compileBTN;
        private System.Windows.Forms.Button runBTN;
    }
}

