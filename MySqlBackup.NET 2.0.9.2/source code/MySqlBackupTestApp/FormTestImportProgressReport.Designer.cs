﻿namespace MySqlBackupTestApp
{
    partial class FormTestImportProgressReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btImport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.nmImInterval = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmImInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Test - Progress Report - Import";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(155, 62);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(118, 33);
            this.btCancel.TabIndex = 14;
            this.btCancel.Text = "Cancel Import";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(16, 62);
            this.btImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(118, 33);
            this.btImport.TabIndex = 13;
            this.btImport.Text = "Start Import";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Processed Bytes:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(143, 181);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(76, 16);
            this.lbStatus.TabIndex = 18;
            this.lbStatus.Text = "0 of 0 bytes";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 200);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(302, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // nmImInterval
            // 
            this.nmImInterval.Location = new System.Drawing.Point(246, 125);
            this.nmImInterval.Name = "nmImInterval";
            this.nmImInterval.Size = new System.Drawing.Size(72, 22);
            this.nmImInterval.TabIndex = 23;
            this.nmImInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmImInterval.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Progress Report Interval (Miliseconds)";
            // 
            // FormTestImportProgressReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(390, 284);
            this.Controls.Add(this.nmImInterval);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormTestImportProgressReport";
            this.Text = "FormTestImportProgressReport";
            ((System.ComponentModel.ISupportInitialize)(this.nmImInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown nmImInterval;
        private System.Windows.Forms.Label label6;

    }
}