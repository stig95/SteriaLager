#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace LagerApp
{
    partial class frmLagerApp
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
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            Syncfusion.Windows.Forms.CaptionLabel captionLabel1 = new Syncfusion.Windows.Forms.CaptionLabel();
            Syncfusion.Windows.Forms.CaptionLabel captionLabel2 = new Syncfusion.Windows.Forms.CaptionLabel();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnVareSlett = new System.Windows.Forms.Button();
            this.vareSlett = new System.Windows.Forms.ComboBox();
            this.vareAdd = new System.Windows.Forms.Button();
            this.vareNavn = new System.Windows.Forms.TextBox();
            this.antBoks = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.kodeStrek = new System.Windows.Forms.TextBox();
            this.vareEndre = new System.Windows.Forms.ComboBox();
            this.endreStrek = new System.Windows.Forms.TextBox();
            this.endreNavn = new System.Windows.Forms.TextBox();
            this.endreAnt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antBoks)).BeginInit();
            this.tabPageAdv2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(1031, 562);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.RotateTextWhenVertical = true;
            this.tabControlAdv1.Size = new System.Drawing.Size(1031, 562);
            this.tabControlAdv1.TabIndex = 0;
            this.tabControlAdv1.ThemesEnabled = true;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.button1);
            this.tabPageAdv1.Controls.Add(this.endreAnt);
            this.tabPageAdv1.Controls.Add(this.endreNavn);
            this.tabPageAdv1.Controls.Add(this.endreStrek);
            this.tabPageAdv1.Controls.Add(this.vareEndre);
            this.tabPageAdv1.Controls.Add(this.kodeStrek);
            this.tabPageAdv1.Controls.Add(this.btnVareSlett);
            this.tabPageAdv1.Controls.Add(this.vareSlett);
            this.tabPageAdv1.Controls.Add(this.vareAdd);
            this.tabPageAdv1.Controls.Add(this.vareNavn);
            this.tabPageAdv1.Controls.Add(this.antBoks);
            this.tabPageAdv1.Controls.Add(this.toolStripEx1);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(48, 48);
            this.tabPageAdv1.IsTransparent = true;
            this.tabPageAdv1.Location = new System.Drawing.Point(86, 3);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(941, 555);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.ThemesEnabled = true;
            // 
            // btnVareSlett
            // 
            this.btnVareSlett.Location = new System.Drawing.Point(548, 93);
            this.btnVareSlett.Name = "btnVareSlett";
            this.btnVareSlett.Size = new System.Drawing.Size(121, 33);
            this.btnVareSlett.TabIndex = 9;
            this.btnVareSlett.Text = "REMOFF IT";
            this.btnVareSlett.UseVisualStyleBackColor = true;
            this.btnVareSlett.Click += new System.EventHandler(this.btnVareSlett_Click);
            // 
            // vareSlett
            // 
            this.vareSlett.FormattingEnabled = true;
            this.vareSlett.Location = new System.Drawing.Point(548, 65);
            this.vareSlett.Name = "vareSlett";
            this.vareSlett.Size = new System.Drawing.Size(121, 21);
            this.vareSlett.TabIndex = 8;
            this.vareSlett.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vareAdd
            // 
            this.vareAdd.Location = new System.Drawing.Point(607, 164);
            this.vareAdd.Margin = new System.Windows.Forms.Padding(2);
            this.vareAdd.Name = "vareAdd";
            this.vareAdd.Size = new System.Drawing.Size(178, 41);
            this.vareAdd.TabIndex = 7;
            this.vareAdd.Text = "Legg til ny vare";
            this.vareAdd.UseVisualStyleBackColor = true;
            this.vareAdd.Click += new System.EventHandler(this.vareAdd_Click);
            // 
            // vareNavn
            // 
            this.vareNavn.Location = new System.Drawing.Point(514, 175);
            this.vareNavn.Margin = new System.Windows.Forms.Padding(2);
            this.vareNavn.Name = "vareNavn";
            this.vareNavn.Size = new System.Drawing.Size(76, 20);
            this.vareNavn.TabIndex = 6;
            // 
            // antBoks
            // 
            this.antBoks.BackGroundColor = System.Drawing.SystemColors.Window;
            this.antBoks.BeforeTouchSize = new System.Drawing.Size(76, 20);
            this.antBoks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.antBoks.IntegerValue = ((long)(2));
            this.antBoks.Location = new System.Drawing.Point(514, 198);
            this.antBoks.Margin = new System.Windows.Forms.Padding(2);
            this.antBoks.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.antBoks.Name = "antBoks";
            this.antBoks.NullString = "";
            this.antBoks.Size = new System.Drawing.Size(76, 20);
            this.antBoks.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.antBoks.TabIndex = 5;
            this.antBoks.Text = "2";
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Size = new System.Drawing.Size(941, 40);
            this.toolStripEx1.TabIndex = 0;
            this.toolStripEx1.Text = "toolStripEx1";
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.toolStripEx2);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(86, 3);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(941, 555);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "tabPageAdv2";
            this.tabPageAdv2.ThemesEnabled = true;
            // 
            // toolStripEx2
            // 
            this.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Size = new System.Drawing.Size(941, 40);
            this.toolStripEx2.TabIndex = 1;
            this.toolStripEx2.Text = "toolStripEx2";
            // 
            // kodeStrek
            // 
            this.kodeStrek.Location = new System.Drawing.Point(514, 150);
            this.kodeStrek.Name = "kodeStrek";
            this.kodeStrek.Size = new System.Drawing.Size(76, 20);
            this.kodeStrek.TabIndex = 10;
            // 
            // vareEndre
            // 
            this.vareEndre.FormattingEnabled = true;
            this.vareEndre.Location = new System.Drawing.Point(122, 65);
            this.vareEndre.Name = "vareEndre";
            this.vareEndre.Size = new System.Drawing.Size(121, 21);
            this.vareEndre.TabIndex = 11;
            this.vareEndre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // endreStrek
            // 
            this.endreStrek.Location = new System.Drawing.Point(122, 93);
            this.endreStrek.Name = "endreStrek";
            this.endreStrek.Size = new System.Drawing.Size(100, 20);
            this.endreStrek.TabIndex = 12;
            // 
            // endreNavn
            // 
            this.endreNavn.Location = new System.Drawing.Point(122, 120);
            this.endreNavn.Name = "endreNavn";
            this.endreNavn.Size = new System.Drawing.Size(100, 20);
            this.endreNavn.TabIndex = 13;
            // 
            // endreAnt
            // 
            this.endreAnt.Location = new System.Drawing.Point(122, 147);
            this.endreAnt.Name = "endreAnt";
            this.endreAnt.Size = new System.Drawing.Size(100, 20);
            this.endreAnt.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmLagerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarHeight = 48;
            captionImage1.BackColor = System.Drawing.Color.Transparent;
            captionImage1.Location = new System.Drawing.Point(110, 4);
            captionImage1.Name = "SSLogoTop";
            captionImage1.Size = new System.Drawing.Size(44, 44);
            this.CaptionImages.Add(captionImage1);
            captionLabel1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            captionLabel1.Location = new System.Drawing.Point(30, 10);
            captionLabel1.Name = "capLblSopra";
            captionLabel1.Text = "Sopra";
            captionLabel2.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            captionLabel2.Location = new System.Drawing.Point(150, 10);
            captionLabel2.Name = "capLblSteria";
            captionLabel2.Text = "Steria";
            this.CaptionLabels.Add(captionLabel1);
            this.CaptionLabels.Add(captionLabel2);
            this.ClientSize = new System.Drawing.Size(1031, 562);
            this.Controls.Add(this.tabControlAdv1);
            this.Name = "frmLagerApp";
            this.Text = "MetroForm1";
            this.Load += new System.EventHandler(this.frmLagerApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antBoks)).EndInit();
            this.tabPageAdv2.ResumeLayout(false);
            this.tabPageAdv2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private System.Windows.Forms.Button vareAdd;
        private System.Windows.Forms.TextBox vareNavn;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox antBoks;
        private System.Windows.Forms.ComboBox vareSlett;
        private System.Windows.Forms.Button btnVareSlett;
        private System.Windows.Forms.TextBox kodeStrek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox endreAnt;
        private System.Windows.Forms.TextBox endreNavn;
        private System.Windows.Forms.TextBox endreStrek;
        private System.Windows.Forms.ComboBox vareEndre;
    }
}