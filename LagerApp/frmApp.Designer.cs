namespace LagerApp
{
    partial class frmApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kodeStrek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antBoks)).BeginInit();
            this.SuspendLayout();
            // 
            // kodeStrek
            // 
            this.kodeStrek.BackGroundColor = System.Drawing.SystemColors.Window;
            this.kodeStrek.BeforeTouchSize = new System.Drawing.Size(76, 20);
            this.kodeStrek.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kodeStrek.IntegerValue = ((long)(1));
            this.kodeStrek.Location = new System.Drawing.Point(404, 128);
            this.kodeStrek.Margin = new System.Windows.Forms.Padding(2);
            this.kodeStrek.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.kodeStrek.Name = "kodeStrek";
            this.kodeStrek.NullString = "";
            this.kodeStrek.Size = new System.Drawing.Size(76, 20);
            this.kodeStrek.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.kodeStrek.TabIndex = 0;
            this.kodeStrek.Text = "1";
            this.kodeStrek.TextChanged += new System.EventHandler(this.integerTextBox1_TextChanged);
            // 
            // antBoks
            // 
            this.antBoks.BackGroundColor = System.Drawing.SystemColors.Window;
            this.antBoks.BeforeTouchSize = new System.Drawing.Size(76, 20);
            this.antBoks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.antBoks.IntegerValue = ((long)(2));
            this.antBoks.Location = new System.Drawing.Point(404, 173);
            this.antBoks.Margin = new System.Windows.Forms.Padding(2);
            this.antBoks.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.antBoks.Name = "antBoks";
            this.antBoks.NullString = "";
            this.antBoks.Size = new System.Drawing.Size(76, 20);
            this.antBoks.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.antBoks.TabIndex = 1;
            this.antBoks.Text = "2";
            // 
            // vareNavn
            // 
            this.vareNavn.Location = new System.Drawing.Point(404, 150);
            this.vareNavn.Margin = new System.Windows.Forms.Padding(2);
            this.vareNavn.Name = "vareNavn";
            this.vareNavn.Size = new System.Drawing.Size(76, 20);
            this.vareNavn.TabIndex = 2;
            // 
            // vareAdd
            // 
            this.vareAdd.Location = new System.Drawing.Point(497, 139);
            this.vareAdd.Margin = new System.Windows.Forms.Padding(2);
            this.vareAdd.Name = "vareAdd";
            this.vareAdd.Size = new System.Drawing.Size(178, 41);
            this.vareAdd.TabIndex = 3;
            this.vareAdd.Text = "Legg til ny vare";
            this.vareAdd.UseVisualStyleBackColor = true;
            this.vareAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Vare endre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(741, 217);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Legg til ny vare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 619);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vareAdd);
            this.Controls.Add(this.vareNavn);
            this.Controls.Add(this.antBoks);
            this.Controls.Add(this.kodeStrek);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

