#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Launcher
{
    partial class frmLaunch
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
            this.components = new System.ComponentModel.Container();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblUsrName = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BackColor = System.Drawing.Color.White;
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(183, 27);
            this.textBoxExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt1.Location = new System.Drawing.Point(233, 41);
            this.textBoxExt1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.Size = new System.Drawing.Size(183, 27);
            this.textBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBoxExt1.TabIndex = 1;
            this.textBoxExt1.Text = "textBoxExt1";
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BackColor = System.Drawing.Color.White;
            this.textBoxExt2.BeforeTouchSize = new System.Drawing.Size(183, 27);
            this.textBoxExt2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt2.Location = new System.Drawing.Point(233, 102);
            this.textBoxExt2.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.Size = new System.Drawing.Size(183, 27);
            this.textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textBoxExt2.TabIndex = 2;
            this.textBoxExt2.Text = "textBoxExt2";
            // 
            // lblUsrName
            // 
            this.lblUsrName.AutoSize = true;
            this.lblUsrName.Location = new System.Drawing.Point(219, 18);
            this.lblUsrName.Name = "lblUsrName";
            this.lblUsrName.Size = new System.Drawing.Size(84, 20);
            this.lblUsrName.TabIndex = 3;
            this.lblUsrName.Text = "Brukernavn:";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(219, 79);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(63, 20);
            this.lblPwd.TabIndex = 4;
            this.lblPwd.Text = "Passord:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 186);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnLogin.BeforeTouchSize = new System.Drawing.Size(90, 35);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IsBackStageButton = false;
            this.btnLogin.Location = new System.Drawing.Point(326, 135);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Logg inn";
            this.btnLogin.UseVisualStyle = true;
            // 
            // frmLaunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CaptionBarHeight = 48;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(666, 186);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUsrName);
            this.Controls.Add(this.textBoxExt2);
            this.Controls.Add(this.textBoxExt1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLaunch";
            this.Text = "MetroForm1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLaunch_FormClosing);
            this.Load += new System.EventHandler(this.frmLaunch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private System.Windows.Forms.Label lblUsrName;
        private System.Windows.Forms.Label lblPwd;
        private Syncfusion.Windows.Forms.ButtonAdv btnLogin;
    }
}