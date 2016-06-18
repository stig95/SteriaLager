namespace LagerApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kodeStrek = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.antBoks = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.vareNavn = new System.Windows.Forms.TextBox();
            this.vareAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kodeStrek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antBoks)).BeginInit();
            this.SuspendLayout();
            // 
            // kodeStrek
            // 
            this.kodeStrek.BackGroundColor = System.Drawing.SystemColors.Window;
            this.kodeStrek.BeforeTouchSize = new System.Drawing.Size(100, 22);
            this.kodeStrek.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kodeStrek.IntegerValue = ((long)(1));
            this.kodeStrek.Location = new System.Drawing.Point(538, 157);
            this.kodeStrek.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.kodeStrek.Name = "kodeStrek";
            this.kodeStrek.NullString = "";
            this.kodeStrek.Size = new System.Drawing.Size(100, 22);
            this.kodeStrek.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.kodeStrek.TabIndex = 0;
            this.kodeStrek.Text = "1";
            this.kodeStrek.TextChanged += new System.EventHandler(this.integerTextBox1_TextChanged);
            // 
            // antBoks
            // 
            this.antBoks.BackGroundColor = System.Drawing.SystemColors.Window;
            this.antBoks.BeforeTouchSize = new System.Drawing.Size(100, 22);
            this.antBoks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.antBoks.IntegerValue = ((long)(2));
            this.antBoks.Location = new System.Drawing.Point(538, 213);
            this.antBoks.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.antBoks.Name = "antBoks";
            this.antBoks.NullString = "";
            this.antBoks.Size = new System.Drawing.Size(100, 22);
            this.antBoks.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.antBoks.TabIndex = 1;
            this.antBoks.Text = "2";
            // 
            // vareNavn
            // 
            this.vareNavn.Location = new System.Drawing.Point(538, 185);
            this.vareNavn.Name = "vareNavn";
            this.vareNavn.Size = new System.Drawing.Size(100, 22);
            this.vareNavn.TabIndex = 2;
            // 
            // vareAdd
            // 
            this.vareAdd.Location = new System.Drawing.Point(663, 171);
            this.vareAdd.Name = "vareAdd";
            this.vareAdd.Size = new System.Drawing.Size(237, 50);
            this.vareAdd.TabIndex = 3;
            this.vareAdd.Text = "Legg til ny vare";
            this.vareAdd.UseVisualStyleBackColor = true;
            this.vareAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1819, 762);
            this.Controls.Add(this.vareAdd);
            this.Controls.Add(this.vareNavn);
            this.Controls.Add(this.antBoks);
            this.Controls.Add(this.kodeStrek);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kodeStrek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antBoks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.IntegerTextBox kodeStrek;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox antBoks;
        private System.Windows.Forms.TextBox vareNavn;
        private System.Windows.Forms.Button vareAdd;
    }
}

