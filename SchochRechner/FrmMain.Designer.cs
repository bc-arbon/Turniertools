﻿namespace SchochRechner
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SpcMain = new SplitContainer();
            tabControl1 = new TabControl();
            TpgRanking = new TabPage();
            SpcRanking = new SplitContainer();
            BtnDisplay = new Button();
            BtnPrint = new Button();
            LvwRanking = new ListView();
            ChrRank = new ColumnHeader();
            ChrId = new ColumnHeader();
            ChrName = new ColumnHeader();
            ChrRounds = new ColumnHeader();
            ChrPoints = new ColumnHeader();
            ChrBuchholz = new ColumnHeader();
            ChrFeinbuchholz = new ColumnHeader();
            ChrGames = new ColumnHeader();
            ChrGamesDiff = new ColumnHeader();
            ChrSets = new ColumnHeader();
            ChrSetsDiff = new ColumnHeader();
            ChrGamepoints = new ColumnHeader();
            ChrGamepointsDiff = new ColumnHeader();
            TpgDraws = new TabPage();
            label1 = new Label();
            BtnCustomMatchcard = new Button();
            NudRound = new NumericUpDown();
            BtnTest = new Button();
            BtnEmptyMatchcard = new Button();
            BtnRandomDraw = new Button();
            BtnClearDraws = new Button();
            BtnAddDraw = new Button();
            LvwDraws = new ListView();
            ChdOpp1 = new ColumnHeader();
            ChdDrawTeam1 = new ColumnHeader();
            ChdPoints1 = new ColumnHeader();
            ChdPoints2 = new ColumnHeader();
            ChdDrawTeam2 = new ColumnHeader();
            ChdOpp2 = new ColumnHeader();
            ChdCourt = new ColumnHeader();
            ChdDuration = new ColumnHeader();
            CmsCourt = new ContextMenuStrip(components);
            MnuMatchcard = new ToolStripMenuItem();
            MnuEnterResult = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            MnuCourtNone = new ToolStripMenuItem();
            MnuCourt1 = new ToolStripMenuItem();
            MnuCourt2 = new ToolStripMenuItem();
            MnuCourt3 = new ToolStripMenuItem();
            MnuCourt4 = new ToolStripMenuItem();
            MnuCourt5 = new ToolStripMenuItem();
            MnuCourt6 = new ToolStripMenuItem();
            MnuCourt7 = new ToolStripMenuItem();
            MnuCourt8 = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            SpcEntries = new SplitContainer();
            BtnTeams = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnAdd = new Button();
            LvwEntries = new ListView();
            ChrResultsRound = new ColumnHeader();
            ChrResultsTeam1 = new ColumnHeader();
            ChrResultsRound2 = new ColumnHeader();
            ChrResultsGames = new ColumnHeader();
            ChrResultsSets = new ColumnHeader();
            ChrResultsPoints = new ColumnHeader();
            TmrDuration = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)SpcMain).BeginInit();
            SpcMain.Panel1.SuspendLayout();
            SpcMain.Panel2.SuspendLayout();
            SpcMain.SuspendLayout();
            tabControl1.SuspendLayout();
            TpgRanking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpcRanking).BeginInit();
            SpcRanking.Panel1.SuspendLayout();
            SpcRanking.Panel2.SuspendLayout();
            SpcRanking.SuspendLayout();
            TpgDraws.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudRound).BeginInit();
            CmsCourt.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpcEntries).BeginInit();
            SpcEntries.Panel1.SuspendLayout();
            SpcEntries.Panel2.SuspendLayout();
            SpcEntries.SuspendLayout();
            SuspendLayout();
            // 
            // SpcMain
            // 
            SpcMain.Dock = DockStyle.Fill;
            SpcMain.FixedPanel = FixedPanel.Panel2;
            SpcMain.Location = new Point(0, 0);
            SpcMain.Name = "SpcMain";
            // 
            // SpcMain.Panel1
            // 
            SpcMain.Panel1.Controls.Add(tabControl1);
            // 
            // SpcMain.Panel2
            // 
            SpcMain.Panel2.Controls.Add(groupBox2);
            SpcMain.Size = new Size(1398, 818);
            SpcMain.SplitterDistance = 947;
            SpcMain.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TpgRanking);
            tabControl1.Controls.Add(TpgDraws);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(947, 818);
            tabControl1.TabIndex = 1;
            // 
            // TpgRanking
            // 
            TpgRanking.BackColor = SystemColors.Control;
            TpgRanking.Controls.Add(SpcRanking);
            TpgRanking.Location = new Point(4, 24);
            TpgRanking.Name = "TpgRanking";
            TpgRanking.Padding = new Padding(3);
            TpgRanking.Size = new Size(939, 790);
            TpgRanking.TabIndex = 0;
            TpgRanking.Text = "Rangliste";
            // 
            // SpcRanking
            // 
            SpcRanking.Cursor = Cursors.HSplit;
            SpcRanking.Dock = DockStyle.Fill;
            SpcRanking.Location = new Point(3, 3);
            SpcRanking.Name = "SpcRanking";
            SpcRanking.Orientation = Orientation.Horizontal;
            // 
            // SpcRanking.Panel1
            // 
            SpcRanking.Panel1.Controls.Add(BtnDisplay);
            SpcRanking.Panel1.Controls.Add(BtnPrint);
            // 
            // SpcRanking.Panel2
            // 
            SpcRanking.Panel2.Controls.Add(LvwRanking);
            SpcRanking.Size = new Size(933, 784);
            SpcRanking.SplitterDistance = 35;
            SpcRanking.SplitterWidth = 5;
            SpcRanking.TabIndex = 1;
            // 
            // BtnDisplay
            // 
            BtnDisplay.Location = new Point(82, 3);
            BtnDisplay.Name = "BtnDisplay";
            BtnDisplay.Size = new Size(74, 26);
            BtnDisplay.TabIndex = 2;
            BtnDisplay.Text = "Display";
            BtnDisplay.UseVisualStyleBackColor = true;
            BtnDisplay.Click += BtnDisplay_Click;
            // 
            // BtnPrint
            // 
            BtnPrint.Location = new Point(3, 3);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(74, 26);
            BtnPrint.TabIndex = 1;
            BtnPrint.Text = "Drucken";
            BtnPrint.UseVisualStyleBackColor = true;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // LvwRanking
            // 
            LvwRanking.Columns.AddRange(new ColumnHeader[] { ChrRank, ChrId, ChrName, ChrRounds, ChrPoints, ChrBuchholz, ChrFeinbuchholz, ChrGames, ChrGamesDiff, ChrSets, ChrSetsDiff, ChrGamepoints, ChrGamepointsDiff });
            LvwRanking.Dock = DockStyle.Fill;
            LvwRanking.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LvwRanking.FullRowSelect = true;
            LvwRanking.Location = new Point(0, 0);
            LvwRanking.Name = "LvwRanking";
            LvwRanking.OwnerDraw = true;
            LvwRanking.Size = new Size(933, 744);
            LvwRanking.TabIndex = 0;
            LvwRanking.UseCompatibleStateImageBehavior = false;
            LvwRanking.View = View.Details;
            LvwRanking.DrawColumnHeader += LvwRanking_DrawColumnHeader;
            LvwRanking.DrawItem += LvwRanking_DrawItem;
            // 
            // ChrRank
            // 
            ChrRank.Text = "Rang";
            ChrRank.Width = 50;
            // 
            // ChrId
            // 
            ChrId.Text = "Id";
            ChrId.TextAlign = HorizontalAlignment.Center;
            ChrId.Width = 50;
            // 
            // ChrName
            // 
            ChrName.Text = "Name";
            ChrName.Width = 180;
            // 
            // ChrRounds
            // 
            ChrRounds.Text = "R";
            ChrRounds.TextAlign = HorizontalAlignment.Center;
            ChrRounds.Width = 30;
            // 
            // ChrPoints
            // 
            ChrPoints.Text = "P";
            ChrPoints.TextAlign = HorizontalAlignment.Center;
            ChrPoints.Width = 40;
            // 
            // ChrBuchholz
            // 
            ChrBuchholz.Text = "BHZ";
            ChrBuchholz.TextAlign = HorizontalAlignment.Center;
            ChrBuchholz.Width = 45;
            // 
            // ChrFeinbuchholz
            // 
            ChrFeinbuchholz.Text = "FBHZ";
            ChrFeinbuchholz.TextAlign = HorizontalAlignment.Center;
            ChrFeinbuchholz.Width = 0;
            // 
            // ChrGames
            // 
            ChrGames.Text = "G";
            ChrGames.TextAlign = HorizontalAlignment.Center;
            ChrGames.Width = 40;
            // 
            // ChrGamesDiff
            // 
            ChrGamesDiff.Text = "G Diff";
            ChrGamesDiff.TextAlign = HorizontalAlignment.Center;
            ChrGamesDiff.Width = 55;
            // 
            // ChrSets
            // 
            ChrSets.Text = "S";
            ChrSets.TextAlign = HorizontalAlignment.Center;
            ChrSets.Width = 40;
            // 
            // ChrSetsDiff
            // 
            ChrSetsDiff.Text = "S Diff";
            ChrSetsDiff.TextAlign = HorizontalAlignment.Center;
            ChrSetsDiff.Width = 50;
            // 
            // ChrGamepoints
            // 
            ChrGamepoints.Text = "P";
            ChrGamepoints.TextAlign = HorizontalAlignment.Center;
            ChrGamepoints.Width = 50;
            // 
            // ChrGamepointsDiff
            // 
            ChrGamepointsDiff.Text = "P Diff";
            ChrGamepointsDiff.TextAlign = HorizontalAlignment.Center;
            // 
            // TpgDraws
            // 
            TpgDraws.BackColor = SystemColors.Control;
            TpgDraws.Controls.Add(label1);
            TpgDraws.Controls.Add(BtnCustomMatchcard);
            TpgDraws.Controls.Add(NudRound);
            TpgDraws.Controls.Add(BtnTest);
            TpgDraws.Controls.Add(BtnEmptyMatchcard);
            TpgDraws.Controls.Add(BtnRandomDraw);
            TpgDraws.Controls.Add(BtnClearDraws);
            TpgDraws.Controls.Add(BtnAddDraw);
            TpgDraws.Controls.Add(LvwDraws);
            TpgDraws.Location = new Point(4, 24);
            TpgDraws.Name = "TpgDraws";
            TpgDraws.Padding = new Padding(3);
            TpgDraws.Size = new Size(939, 790);
            TpgDraws.TabIndex = 1;
            TpgDraws.Text = "Auslosungen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 10);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 8;
            label1.Text = "Runde:";
            // 
            // BtnCustomMatchcard
            // 
            BtnCustomMatchcard.Location = new Point(647, 6);
            BtnCustomMatchcard.Name = "BtnCustomMatchcard";
            BtnCustomMatchcard.Size = new Size(130, 23);
            BtnCustomMatchcard.TabIndex = 6;
            BtnCustomMatchcard.Text = "Eigenes Matchblatt";
            BtnCustomMatchcard.UseVisualStyleBackColor = true;
            BtnCustomMatchcard.Click += BtnCustomMatchcard_Click;
            // 
            // NudRound
            // 
            NudRound.Location = new Point(318, 8);
            NudRound.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudRound.Name = "NudRound";
            NudRound.Size = new Size(37, 23);
            NudRound.TabIndex = 7;
            NudRound.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NudRound.ValueChanged += NudRound_ValueChanged;
            // 
            // BtnTest
            // 
            BtnTest.Location = new Point(783, 6);
            BtnTest.Name = "BtnTest";
            BtnTest.Size = new Size(75, 23);
            BtnTest.TabIndex = 6;
            BtnTest.Text = "Test";
            BtnTest.UseVisualStyleBackColor = true;
            BtnTest.Click += BtnTest_Click;
            // 
            // BtnEmptyMatchcard
            // 
            BtnEmptyMatchcard.Location = new Point(522, 6);
            BtnEmptyMatchcard.Name = "BtnEmptyMatchcard";
            BtnEmptyMatchcard.Size = new Size(119, 23);
            BtnEmptyMatchcard.TabIndex = 5;
            BtnEmptyMatchcard.Text = "Leeres Matchblatt";
            BtnEmptyMatchcard.UseVisualStyleBackColor = true;
            BtnEmptyMatchcard.Click += BtnEmptyMatchcard_Click;
            // 
            // BtnRandomDraw
            // 
            BtnRandomDraw.Location = new Point(133, 6);
            BtnRandomDraw.Name = "BtnRandomDraw";
            BtnRandomDraw.Size = new Size(129, 23);
            BtnRandomDraw.TabIndex = 4;
            BtnRandomDraw.Text = "Auslosung zufällig";
            BtnRandomDraw.UseVisualStyleBackColor = true;
            BtnRandomDraw.Click += BtnRandomDraw_Click;
            // 
            // BtnClearDraws
            // 
            BtnClearDraws.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClearDraws.Location = new Point(864, 6);
            BtnClearDraws.Name = "BtnClearDraws";
            BtnClearDraws.Size = new Size(69, 23);
            BtnClearDraws.TabIndex = 3;
            BtnClearDraws.Text = "Löschen";
            BtnClearDraws.UseVisualStyleBackColor = true;
            BtnClearDraws.Visible = false;
            BtnClearDraws.Click += BtnClearDraws_Click;
            // 
            // BtnAddDraw
            // 
            BtnAddDraw.Location = new Point(8, 6);
            BtnAddDraw.Name = "BtnAddDraw";
            BtnAddDraw.Size = new Size(119, 23);
            BtnAddDraw.TabIndex = 2;
            BtnAddDraw.Text = "Auslosung Schoch";
            BtnAddDraw.UseVisualStyleBackColor = true;
            BtnAddDraw.Click += BtnAddDraw_Click;
            // 
            // LvwDraws
            // 
            LvwDraws.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LvwDraws.Columns.AddRange(new ColumnHeader[] { ChdOpp1, ChdDrawTeam1, ChdPoints1, ChdPoints2, ChdDrawTeam2, ChdOpp2, ChdCourt, ChdDuration });
            LvwDraws.ContextMenuStrip = CmsCourt;
            LvwDraws.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LvwDraws.FullRowSelect = true;
            LvwDraws.Location = new Point(8, 35);
            LvwDraws.Name = "LvwDraws";
            LvwDraws.OwnerDraw = true;
            LvwDraws.Size = new Size(925, 747);
            LvwDraws.TabIndex = 1;
            LvwDraws.UseCompatibleStateImageBehavior = false;
            LvwDraws.View = View.Details;
            LvwDraws.DrawColumnHeader += LvwDraws_DrawColumnHeader;
            LvwDraws.DrawItem += LvwDraws_DrawItem;
            LvwDraws.MouseDoubleClick += LvwDraws_MouseDoubleClick;
            // 
            // ChdOpp1
            // 
            ChdOpp1.Text = "Gegner Team 1";
            ChdOpp1.Width = 120;
            // 
            // ChdDrawTeam1
            // 
            ChdDrawTeam1.Text = "Team 1";
            ChdDrawTeam1.Width = 230;
            // 
            // ChdPoints1
            // 
            ChdPoints1.Text = "";
            ChdPoints1.TextAlign = HorizontalAlignment.Center;
            ChdPoints1.Width = 30;
            // 
            // ChdPoints2
            // 
            ChdPoints2.Text = "";
            ChdPoints2.TextAlign = HorizontalAlignment.Center;
            ChdPoints2.Width = 30;
            // 
            // ChdDrawTeam2
            // 
            ChdDrawTeam2.Text = "Team2";
            ChdDrawTeam2.Width = 230;
            // 
            // ChdOpp2
            // 
            ChdOpp2.Text = "Gegner Team 2";
            ChdOpp2.Width = 120;
            // 
            // ChdCourt
            // 
            ChdCourt.Text = "Feld";
            ChdCourt.Width = 50;
            // 
            // ChdDuration
            // 
            ChdDuration.Text = "Dauer";
            ChdDuration.TextAlign = HorizontalAlignment.Right;
            // 
            // CmsCourt
            // 
            CmsCourt.Items.AddRange(new ToolStripItem[] { MnuMatchcard, MnuEnterResult, toolStripSeparator1, MnuCourtNone, MnuCourt1, MnuCourt2, MnuCourt3, MnuCourt4, MnuCourt5, MnuCourt6, MnuCourt7, MnuCourt8 });
            CmsCourt.Name = "CmsCourt";
            CmsCourt.Size = new Size(170, 252);
            CmsCourt.Opening += CmsCourt_Opening;
            // 
            // MnuMatchcard
            // 
            MnuMatchcard.Name = "MnuMatchcard";
            MnuMatchcard.Size = new Size(169, 22);
            MnuMatchcard.Text = "Matchblatt";
            MnuMatchcard.Click += MnuMatchcard_Click;
            // 
            // MnuEnterResult
            // 
            MnuEnterResult.Name = "MnuEnterResult";
            MnuEnterResult.Size = new Size(169, 22);
            MnuEnterResult.Text = "Resultat eintragen";
            MnuEnterResult.Click += MnuEnterResult_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(166, 6);
            // 
            // MnuCourtNone
            // 
            MnuCourtNone.Name = "MnuCourtNone";
            MnuCourtNone.Size = new Size(169, 22);
            MnuCourtNone.Tag = "0";
            MnuCourtNone.Text = "kein Feld";
            MnuCourtNone.Click += MnuCourt_Click;
            // 
            // MnuCourt1
            // 
            MnuCourt1.Name = "MnuCourt1";
            MnuCourt1.Size = new Size(169, 22);
            MnuCourt1.Tag = "1";
            MnuCourt1.Text = "Feld 1";
            MnuCourt1.Click += MnuCourt_Click;
            // 
            // MnuCourt2
            // 
            MnuCourt2.Name = "MnuCourt2";
            MnuCourt2.Size = new Size(169, 22);
            MnuCourt2.Tag = "2";
            MnuCourt2.Text = "Feld 2";
            MnuCourt2.Click += MnuCourt_Click;
            // 
            // MnuCourt3
            // 
            MnuCourt3.Name = "MnuCourt3";
            MnuCourt3.Size = new Size(169, 22);
            MnuCourt3.Tag = "3";
            MnuCourt3.Text = "Feld 3";
            MnuCourt3.Click += MnuCourt_Click;
            // 
            // MnuCourt4
            // 
            MnuCourt4.Name = "MnuCourt4";
            MnuCourt4.Size = new Size(169, 22);
            MnuCourt4.Tag = "4";
            MnuCourt4.Text = "Feld 4";
            MnuCourt4.Click += MnuCourt_Click;
            // 
            // MnuCourt5
            // 
            MnuCourt5.Name = "MnuCourt5";
            MnuCourt5.Size = new Size(169, 22);
            MnuCourt5.Tag = "5";
            MnuCourt5.Text = "Feld 5";
            MnuCourt5.Click += MnuCourt_Click;
            // 
            // MnuCourt6
            // 
            MnuCourt6.Name = "MnuCourt6";
            MnuCourt6.Size = new Size(169, 22);
            MnuCourt6.Tag = "6";
            MnuCourt6.Text = "Feld 6";
            MnuCourt6.Click += MnuCourt_Click;
            // 
            // MnuCourt7
            // 
            MnuCourt7.Name = "MnuCourt7";
            MnuCourt7.Size = new Size(169, 22);
            MnuCourt7.Tag = "7";
            MnuCourt7.Text = "Feld 7";
            MnuCourt7.Click += MnuCourt_Click;
            // 
            // MnuCourt8
            // 
            MnuCourt8.Name = "MnuCourt8";
            MnuCourt8.Size = new Size(169, 22);
            MnuCourt8.Tag = "8";
            MnuCourt8.Text = "Feld 8";
            MnuCourt8.Click += MnuCourt_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SpcEntries);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 818);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Begegnungen";
            // 
            // SpcEntries
            // 
            SpcEntries.Cursor = Cursors.HSplit;
            SpcEntries.Dock = DockStyle.Fill;
            SpcEntries.Location = new Point(3, 19);
            SpcEntries.Name = "SpcEntries";
            SpcEntries.Orientation = Orientation.Horizontal;
            // 
            // SpcEntries.Panel1
            // 
            SpcEntries.Panel1.Controls.Add(BtnTeams);
            SpcEntries.Panel1.Controls.Add(BtnDelete);
            SpcEntries.Panel1.Controls.Add(BtnEdit);
            SpcEntries.Panel1.Controls.Add(BtnAdd);
            // 
            // SpcEntries.Panel2
            // 
            SpcEntries.Panel2.Controls.Add(LvwEntries);
            SpcEntries.Size = new Size(441, 796);
            SpcEntries.SplitterDistance = 32;
            SpcEntries.SplitterWidth = 5;
            SpcEntries.TabIndex = 0;
            // 
            // BtnTeams
            // 
            BtnTeams.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnTeams.Location = new Point(360, 3);
            BtnTeams.Name = "BtnTeams";
            BtnTeams.Size = new Size(74, 26);
            BtnTeams.TabIndex = 1;
            BtnTeams.Text = "Teams";
            BtnTeams.UseVisualStyleBackColor = true;
            BtnTeams.Click += BtnTeams_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(187, 3);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(86, 26);
            BtnDelete.TabIndex = 0;
            BtnDelete.Text = "Löschen";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(95, 3);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(86, 26);
            BtnEdit.TabIndex = 0;
            BtnEdit.Text = "Bearbeiten...";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(3, 3);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(86, 26);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Hinzufügen...";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // LvwEntries
            // 
            LvwEntries.Columns.AddRange(new ColumnHeader[] { ChrResultsRound, ChrResultsTeam1, ChrResultsRound2, ChrResultsGames, ChrResultsSets, ChrResultsPoints });
            LvwEntries.Dock = DockStyle.Fill;
            LvwEntries.FullRowSelect = true;
            LvwEntries.Location = new Point(0, 0);
            LvwEntries.Name = "LvwEntries";
            LvwEntries.OwnerDraw = true;
            LvwEntries.Size = new Size(441, 759);
            LvwEntries.TabIndex = 0;
            LvwEntries.UseCompatibleStateImageBehavior = false;
            LvwEntries.View = View.Details;
            LvwEntries.DrawColumnHeader += LvwEntries_DrawColumnHeader;
            LvwEntries.DrawItem += LvwEntries_DrawItem;
            LvwEntries.MouseDoubleClick += LvwEntries_MouseDoubleClick;
            // 
            // ChrResultsRound
            // 
            ChrResultsRound.Text = "R";
            ChrResultsRound.Width = 30;
            // 
            // ChrResultsTeam1
            // 
            ChrResultsTeam1.Text = "Team 1";
            ChrResultsTeam1.Width = 120;
            // 
            // ChrResultsRound2
            // 
            ChrResultsRound2.Text = "Team 2";
            ChrResultsRound2.Width = 120;
            // 
            // ChrResultsGames
            // 
            ChrResultsGames.Text = "G";
            ChrResultsGames.Width = 40;
            // 
            // ChrResultsSets
            // 
            ChrResultsSets.Text = "S";
            ChrResultsSets.Width = 40;
            // 
            // ChrResultsPoints
            // 
            ChrResultsPoints.Text = "P";
            // 
            // TmrDuration
            // 
            TmrDuration.Enabled = true;
            TmrDuration.Interval = 1000;
            TmrDuration.Tick += TmrDuration_Tick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1398, 818);
            Controls.Add(SpcMain);
            DoubleBuffered = true;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sir Schoch-A-Lot 1.4";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            SpcMain.Panel1.ResumeLayout(false);
            SpcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SpcMain).EndInit();
            SpcMain.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            TpgRanking.ResumeLayout(false);
            SpcRanking.Panel1.ResumeLayout(false);
            SpcRanking.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SpcRanking).EndInit();
            SpcRanking.ResumeLayout(false);
            TpgDraws.ResumeLayout(false);
            TpgDraws.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudRound).EndInit();
            CmsCourt.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            SpcEntries.Panel1.ResumeLayout(false);
            SpcEntries.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SpcEntries).EndInit();
            SpcEntries.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer SpcMain;
        private ListView LvwRanking;
        private ColumnHeader ChrName;
        private ColumnHeader ChrPoints;
        private ColumnHeader ChrGames;
        private ColumnHeader ChrBuchholz;
        private ColumnHeader ChrFeinbuchholz;
        private GroupBox groupBox2;
        private ColumnHeader ChrGamesDiff;
        private ColumnHeader ChrSets;
        private ColumnHeader ChrSetsDiff;
        private ColumnHeader ChrRounds;
        private ListView LvwEntries;
        private ColumnHeader ChrResultsRound;
        private ColumnHeader ChrResultsTeam1;
        private ColumnHeader ChrResultsRound2;
        private ColumnHeader ChrResultsGames;
        private ColumnHeader ChrResultsSets;
        private SplitContainer SpcEntries;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnAdd;
        private Button BtnTeams;
        private Button BtnPrint;
        private SplitContainer SpcRanking;
        private ColumnHeader ChrRank;
        private ColumnHeader ChrId;
        private Button BtnDisplay;
        private ColumnHeader ChrResultsPoints;
        private ColumnHeader ChrGamepoints;
        private ColumnHeader ChrGamepointsDiff;
        private TabControl tabControl1;
        private TabPage TpgRanking;
        private TabPage TpgDraws;
        private Button BtnAddDraw;
        private ListView LvwDraws;
        private ColumnHeader ChdDrawTeam1;
        private ColumnHeader ChdDrawTeam2;
        private ColumnHeader ChdOpp1;
        private ColumnHeader ChdOpp2;
        private ColumnHeader ChdPoints1;
        private ColumnHeader ChdPoints2;
        private Button BtnClearDraws;
        private Button BtnRandomDraw;
        private Button BtnEmptyMatchcard;
        private Button BtnTest;
        private NumericUpDown NudRound;
        private Button BtnCustomMatchcard;
        private ColumnHeader ChdCourt;
        private ContextMenuStrip CmsCourt;
        private ToolStripMenuItem MnuCourtNone;
        private ToolStripMenuItem MnuCourt1;
        private ToolStripMenuItem MnuCourt2;
        private ToolStripMenuItem MnuCourt3;
        private ToolStripMenuItem MnuCourt4;
        private ToolStripMenuItem MnuCourt5;
        private ToolStripMenuItem MnuCourt6;
        private ToolStripMenuItem MnuCourt7;
        private ToolStripMenuItem MnuCourt8;
        private Label label1;
        private ToolStripMenuItem MnuMatchcard;
        private ToolStripMenuItem MnuEnterResult;
        private ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer TmrDuration;
        private ColumnHeader ChdDuration;
    }
}