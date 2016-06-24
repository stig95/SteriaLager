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
            this.components = new System.ComponentModel.Container();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabOverview = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOslLager = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblStavLager = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblTrdLager = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.tsOversikt = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsLblTotAntVare = new System.Windows.Forms.ToolStripLabel();
            this.tabStorage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.splitContainerAdv2 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.tabControlAdv2 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabAddRemove = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstInfoDelete = new System.Windows.Forms.ListBox();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbLager = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnSlett = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cmbVare = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gbVareSlett = new System.Windows.Forms.GroupBox();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.intAntall = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.txtVareNavn = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnVareAdd = new Syncfusion.Windows.Forms.ButtonAdv();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.intKodeStrek = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.tabChange = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tabUser = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tsOversikt.SuspendLayout();
            this.tabStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv2)).BeginInit();
            this.splitContainerAdv2.Panel2.SuspendLayout();
            this.splitContainerAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv2)).BeginInit();
            this.tabControlAdv2.SuspendLayout();
            this.tabAddRemove.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVare)).BeginInit();
            this.gbVareSlett.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intAntall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVareNavn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intKodeStrek)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabColor = System.Drawing.SystemColors.Control;
            this.tabControlAdv1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(794, 401);
            this.tabControlAdv1.Controls.Add(this.tabOverview);
            this.tabControlAdv1.Controls.Add(this.tabStorage);
            this.tabControlAdv1.Controls.Add(this.tabUser);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.ImageAlignmentR = Syncfusion.Windows.Forms.Tools.RelativeImageAlignment.AboveText;
            this.tabControlAdv1.InactiveTabColor = System.Drawing.Color.Transparent;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.RotateTextWhenVertical = true;
            this.tabControlAdv1.Size = new System.Drawing.Size(794, 401);
            this.tabControlAdv1.TabIndex = 0;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.Transparent;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabControlAdv1.ThemesEnabled = true;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.splitContainerAdv1);
            this.tabOverview.Controls.Add(this.tsOversikt);
            this.tabOverview.Image = null;
            this.tabOverview.ImageSize = new System.Drawing.Size(48, 48);
            this.tabOverview.Location = new System.Drawing.Point(81, 3);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.ShowCloseButton = true;
            this.tabOverview.Size = new System.Drawing.Size(709, 394);
            this.tabOverview.TabIndex = 1;
            this.tabOverview.Text = "tabOverview";
            this.tabOverview.ThemesEnabled = true;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.IsSplitterFixed = true;
            this.splitContainerAdv1.Location = new System.Drawing.Point(0, 40);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerAdv1.Size = new System.Drawing.Size(709, 354);
            this.splitContainerAdv1.SplitterDistance = 221;
            this.splitContainerAdv1.TabIndex = 1;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOslLager);
            this.groupBox1.Controls.Add(this.lblStavLager);
            this.groupBox1.Controls.Add(this.lblTrdLager);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enheter over lager";
            // 
            // lblOslLager
            // 
            this.lblOslLager.Location = new System.Drawing.Point(6, 55);
            this.lblOslLager.Name = "lblOslLager";
            this.lblOslLager.Size = new System.Drawing.Size(60, 13);
            this.lblOslLager.TabIndex = 2;
            this.lblOslLager.Text = "autoLabel3";
            // 
            // lblStavLager
            // 
            this.lblStavLager.Location = new System.Drawing.Point(6, 37);
            this.lblStavLager.Name = "lblStavLager";
            this.lblStavLager.Size = new System.Drawing.Size(60, 13);
            this.lblStavLager.TabIndex = 1;
            this.lblStavLager.Text = "autoLabel2";
            // 
            // lblTrdLager
            // 
            this.lblTrdLager.Location = new System.Drawing.Point(6, 19);
            this.lblTrdLager.Name = "lblTrdLager";
            this.lblTrdLager.Size = new System.Drawing.Size(60, 13);
            this.lblTrdLager.TabIndex = 0;
            this.lblTrdLager.Text = "autoLabel1";
            // 
            // tsOversikt
            // 
            this.tsOversikt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsOversikt.Image = null;
            this.tsOversikt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblTotAntVare});
            this.tsOversikt.Location = new System.Drawing.Point(0, 0);
            this.tsOversikt.Name = "tsOversikt";
            this.tsOversikt.Office12Mode = false;
            this.tsOversikt.Size = new System.Drawing.Size(709, 40);
            this.tsOversikt.TabIndex = 0;
            this.tsOversikt.Text = "Oversikt";
            this.tsOversikt.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Metro;
            // 
            // tsLblTotAntVare
            // 
            this.tsLblTotAntVare.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLblTotAntVare.Name = "tsLblTotAntVare";
            this.tsLblTotAntVare.Size = new System.Drawing.Size(86, 22);
            this.tsLblTotAntVare.Text = "toolStripLabel1";
            // 
            // tabStorage
            // 
            this.tabStorage.Controls.Add(this.splitContainerAdv2);
            this.tabStorage.Controls.Add(this.toolStripEx1);
            this.tabStorage.Image = null;
            this.tabStorage.ImageSize = new System.Drawing.Size(48, 48);
            this.tabStorage.Location = new System.Drawing.Point(81, 3);
            this.tabStorage.Name = "tabStorage";
            this.tabStorage.ShowCloseButton = true;
            this.tabStorage.Size = new System.Drawing.Size(709, 394);
            this.tabStorage.TabIndex = 2;
            this.tabStorage.Text = "tabStorage";
            this.tabStorage.ThemesEnabled = true;
            // 
            // splitContainerAdv2
            // 
            this.splitContainerAdv2.BeforeTouchSize = 7;
            this.splitContainerAdv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv2.IsSplitterFixed = true;
            this.splitContainerAdv2.Location = new System.Drawing.Point(0, 40);
            this.splitContainerAdv2.Name = "splitContainerAdv2";
            // 
            // splitContainerAdv2.Panel2
            // 
            this.splitContainerAdv2.Panel2.Controls.Add(this.tabControlAdv2);
            this.splitContainerAdv2.Size = new System.Drawing.Size(709, 354);
            this.splitContainerAdv2.SplitterDistance = 221;
            this.splitContainerAdv2.TabIndex = 1;
            this.splitContainerAdv2.Text = "splitContainerAdv2";
            // 
            // tabControlAdv2
            // 
            this.tabControlAdv2.ActiveTabColor = System.Drawing.SystemColors.Control;
            this.tabControlAdv2.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAdv2.BeforeTouchSize = new System.Drawing.Size(481, 354);
            this.tabControlAdv2.Controls.Add(this.tabAddRemove);
            this.tabControlAdv2.Controls.Add(this.tabChange);
            this.tabControlAdv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv2.FocusOnTabClick = false;
            this.tabControlAdv2.InactiveTabColor = System.Drawing.Color.Transparent;
            this.tabControlAdv2.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv2.Name = "tabControlAdv2";
            this.tabControlAdv2.Size = new System.Drawing.Size(481, 354);
            this.tabControlAdv2.TabIndex = 0;
            this.tabControlAdv2.TabPanelBackColor = System.Drawing.Color.Transparent;
            this.tabControlAdv2.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabControlAdv2.ThemesEnabled = true;
            // 
            // tabAddRemove
            // 
            this.tabAddRemove.Controls.Add(this.groupBox2);
            this.tabAddRemove.Controls.Add(this.gbVareSlett);
            this.tabAddRemove.Image = null;
            this.tabAddRemove.ImageSize = new System.Drawing.Size(32, 32);
            this.tabAddRemove.Location = new System.Drawing.Point(25, 3);
            this.tabAddRemove.Name = "tabAddRemove";
            this.tabAddRemove.ShowCloseButton = true;
            this.tabAddRemove.Size = new System.Drawing.Size(452, 347);
            this.tabAddRemove.TabIndex = 1;
            this.tabAddRemove.ThemesEnabled = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstInfoDelete);
            this.groupBox2.Controls.Add(this.autoLabel4);
            this.groupBox2.Controls.Add(this.cmbLager);
            this.groupBox2.Controls.Add(this.btnSlett);
            this.groupBox2.Controls.Add(this.cmbVare);
            this.groupBox2.Controls.Add(this.autoLabel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(215, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 347);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slett Vare";
            // 
            // lstInfoDelete
            // 
            this.lstInfoDelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstInfoDelete.FormattingEnabled = true;
            this.lstInfoDelete.Location = new System.Drawing.Point(6, 82);
            this.lstInfoDelete.Name = "lstInfoDelete";
            this.lstInfoDelete.Size = new System.Drawing.Size(196, 91);
            this.lstInfoDelete.TabIndex = 12;
            // 
            // autoLabel4
            // 
            this.autoLabel4.Location = new System.Drawing.Point(6, 31);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(40, 13);
            this.autoLabel4.TabIndex = 8;
            this.autoLabel4.Text = "Lager: ";
            // 
            // cmbLager
            // 
            this.cmbLager.BackColor = System.Drawing.Color.White;
            this.cmbLager.BeforeTouchSize = new System.Drawing.Size(146, 21);
            this.cmbLager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLager.Items.AddRange(new object[] {
            "Trondheim",
            "Oslo",
            "Stavanger"});
            this.cmbLager.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.cmbLager, "Trondheim"));
            this.cmbLager.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.cmbLager, "Oslo"));
            this.cmbLager.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.cmbLager, "Stavanger"));
            this.cmbLager.Location = new System.Drawing.Point(56, 27);
            this.cmbLager.Name = "cmbLager";
            this.cmbLager.Size = new System.Drawing.Size(146, 21);
            this.cmbLager.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbLager.TabIndex = 7;
            this.cmbLager.SelectedValueChanged += new System.EventHandler(this.cmbLager_SelectedValueChanged);
            // 
            // btnSlett
            // 
            this.btnSlett.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSlett.BackColor = System.Drawing.SystemColors.Control;
            this.btnSlett.BeforeTouchSize = new System.Drawing.Size(100, 23);
            this.btnSlett.ForeColor = System.Drawing.Color.Black;
            this.btnSlett.IsBackStageButton = false;
            this.btnSlett.Location = new System.Drawing.Point(102, 182);
            this.btnSlett.MetroColor = System.Drawing.SystemColors.Control;
            this.btnSlett.Name = "btnSlett";
            this.btnSlett.Size = new System.Drawing.Size(100, 23);
            this.btnSlett.TabIndex = 11;
            this.btnSlett.Text = "Slett Valgt Vare";
            this.btnSlett.UseVisualStyle = true;
            // 
            // cmbVare
            // 
            this.cmbVare.BackColor = System.Drawing.Color.White;
            this.cmbVare.BeforeTouchSize = new System.Drawing.Size(146, 21);
            this.cmbVare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVare.Location = new System.Drawing.Point(56, 54);
            this.cmbVare.Name = "cmbVare";
            this.cmbVare.Size = new System.Drawing.Size(146, 21);
            this.cmbVare.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbVare.TabIndex = 9;
            this.cmbVare.Text = "comboBoxAdv2";
            this.cmbVare.SelectedValueChanged += new System.EventHandler(this.cmbVare_SelectedValueChanged);
            // 
            // autoLabel5
            // 
            this.autoLabel5.Location = new System.Drawing.Point(6, 60);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(32, 13);
            this.autoLabel5.TabIndex = 10;
            this.autoLabel5.Text = "Vare:";
            // 
            // gbVareSlett
            // 
            this.gbVareSlett.Controls.Add(this.autoLabel1);
            this.gbVareSlett.Controls.Add(this.autoLabel6);
            this.gbVareSlett.Controls.Add(this.intAntall);
            this.gbVareSlett.Controls.Add(this.txtVareNavn);
            this.gbVareSlett.Controls.Add(this.autoLabel3);
            this.gbVareSlett.Controls.Add(this.comboBoxAdv1);
            this.gbVareSlett.Controls.Add(this.btnVareAdd);
            this.gbVareSlett.Controls.Add(this.autoLabel2);
            this.gbVareSlett.Controls.Add(this.intKodeStrek);
            this.gbVareSlett.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbVareSlett.Location = new System.Drawing.Point(0, 0);
            this.gbVareSlett.Name = "gbVareSlett";
            this.gbVareSlett.Size = new System.Drawing.Size(215, 347);
            this.gbVareSlett.TabIndex = 8;
            this.gbVareSlett.TabStop = false;
            this.gbVareSlett.Text = "Legg Til Ny Vare";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Location = new System.Drawing.Point(6, 31);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(36, 13);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Navn:";
            // 
            // autoLabel6
            // 
            this.autoLabel6.Location = new System.Drawing.Point(6, 130);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(40, 13);
            this.autoLabel6.TabIndex = 10;
            this.autoLabel6.Text = "Lager: ";
            // 
            // intAntall
            // 
            this.intAntall.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intAntall.BeforeTouchSize = new System.Drawing.Size(132, 20);
            this.intAntall.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.intAntall.IntegerValue = ((long)(1));
            this.intAntall.Location = new System.Drawing.Point(71, 95);
            this.intAntall.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intAntall.Name = "intAntall";
            this.intAntall.NullString = "";
            this.intAntall.Size = new System.Drawing.Size(132, 20);
            this.intAntall.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intAntall.TabIndex = 5;
            this.intAntall.Text = "1";
            // 
            // txtVareNavn
            // 
            this.txtVareNavn.BeforeTouchSize = new System.Drawing.Size(132, 20);
            this.txtVareNavn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVareNavn.Location = new System.Drawing.Point(71, 28);
            this.txtVareNavn.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtVareNavn.Name = "txtVareNavn";
            this.txtVareNavn.Size = new System.Drawing.Size(132, 20);
            this.txtVareNavn.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtVareNavn.TabIndex = 1;
            this.txtVareNavn.Text = "textBoxExt1";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Location = new System.Drawing.Point(6, 99);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(36, 13);
            this.autoLabel3.TabIndex = 4;
            this.autoLabel3.Text = "Antall:";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.White;
            this.comboBoxAdv1.BeforeTouchSize = new System.Drawing.Size(132, 21);
            this.comboBoxAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Trondheim",
            "Oslo",
            "Stavanger"});
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Trondheim"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Oslo"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Stavanger"));
            this.comboBoxAdv1.Location = new System.Drawing.Point(71, 126);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(132, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBoxAdv1.TabIndex = 9;
            // 
            // btnVareAdd
            // 
            this.btnVareAdd.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnVareAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnVareAdd.BeforeTouchSize = new System.Drawing.Size(100, 23);
            this.btnVareAdd.ForeColor = System.Drawing.Color.Black;
            this.btnVareAdd.IsBackStageButton = false;
            this.btnVareAdd.Location = new System.Drawing.Point(103, 182);
            this.btnVareAdd.MetroColor = System.Drawing.SystemColors.Control;
            this.btnVareAdd.Name = "btnVareAdd";
            this.btnVareAdd.Size = new System.Drawing.Size(100, 23);
            this.btnVareAdd.TabIndex = 6;
            this.btnVareAdd.Text = "Legg til ny vare";
            this.btnVareAdd.UseVisualStyle = true;
            this.btnVareAdd.Click += new System.EventHandler(this.btnVareAdd_Click_1);
            // 
            // autoLabel2
            // 
            this.autoLabel2.Location = new System.Drawing.Point(6, 64);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(59, 13);
            this.autoLabel2.TabIndex = 2;
            this.autoLabel2.Text = "Strekkode:";
            // 
            // intKodeStrek
            // 
            this.intKodeStrek.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intKodeStrek.BeforeTouchSize = new System.Drawing.Size(132, 20);
            this.intKodeStrek.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.intKodeStrek.IntegerValue = ((long)(1));
            this.intKodeStrek.Location = new System.Drawing.Point(71, 60);
            this.intKodeStrek.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intKodeStrek.Name = "intKodeStrek";
            this.intKodeStrek.NullString = "";
            this.intKodeStrek.Size = new System.Drawing.Size(132, 20);
            this.intKodeStrek.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intKodeStrek.TabIndex = 3;
            this.intKodeStrek.Text = "1";
            // 
            // tabChange
            // 
            this.tabChange.Image = null;
            this.tabChange.ImageSize = new System.Drawing.Size(32, 32);
            this.tabChange.Location = new System.Drawing.Point(25, 3);
            this.tabChange.Name = "tabChange";
            this.tabChange.ShowCloseButton = true;
            this.tabChange.Size = new System.Drawing.Size(452, 347);
            this.tabChange.TabIndex = 2;
            this.tabChange.ThemesEnabled = true;
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.Size = new System.Drawing.Size(709, 40);
            this.toolStripEx1.TabIndex = 0;
            this.toolStripEx1.Text = "Lageroversikt";
            this.toolStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Metro;
            // 
            // tabUser
            // 
            this.tabUser.Image = null;
            this.tabUser.ImageSize = new System.Drawing.Size(48, 48);
            this.tabUser.Location = new System.Drawing.Point(81, 3);
            this.tabUser.Name = "tabUser";
            this.tabUser.ShowCloseButton = true;
            this.tabUser.Size = new System.Drawing.Size(709, 394);
            this.tabUser.TabIndex = 3;
            this.tabUser.Text = "tabUser";
            this.tabUser.ThemesEnabled = true;
            // 
            // frmLagerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarColor = System.Drawing.SystemColors.Control;
            this.CaptionBarHeight = 48;
            this.ClientSize = new System.Drawing.Size(794, 401);
            this.Controls.Add(this.tabControlAdv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLagerApp";
            this.ShowMaximizeBox = false;
            this.Text = "MetroForm1";
            this.Load += new System.EventHandler(this.frmLagerApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.tabOverview.PerformLayout();
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsOversikt.ResumeLayout(false);
            this.tsOversikt.PerformLayout();
            this.tabStorage.ResumeLayout(false);
            this.tabStorage.PerformLayout();
            this.splitContainerAdv2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv2)).EndInit();
            this.splitContainerAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv2)).EndInit();
            this.tabControlAdv2.ResumeLayout(false);
            this.tabAddRemove.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVare)).EndInit();
            this.gbVareSlett.ResumeLayout(false);
            this.gbVareSlett.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intAntall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVareNavn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intKodeStrek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabOverview;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabStorage;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblOslLager;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblStavLager;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTrdLager;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx tsOversikt;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripLabel tsLblTotAntVare;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv2;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv2;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabAddRemove;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intAntall;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intKodeStrek;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtVareNavn;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabChange;
        private System.Windows.Forms.GroupBox gbVareSlett;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbVare;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbLager;
        private Syncfusion.Windows.Forms.ButtonAdv btnVareAdd;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.ButtonAdv btnSlett;
        private System.Windows.Forms.ListBox lstInfoDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabUser;
    }
}