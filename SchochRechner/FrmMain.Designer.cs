namespace SchochRechner
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
            this.SpcMain = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SpcRanking = new System.Windows.Forms.SplitContainer();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.LvwRanking = new System.Windows.Forms.ListView();
            this.ChrRank = new System.Windows.Forms.ColumnHeader();
            this.ChrId = new System.Windows.Forms.ColumnHeader();
            this.ChrName = new System.Windows.Forms.ColumnHeader();
            this.ChrRounds = new System.Windows.Forms.ColumnHeader();
            this.ChrPoints = new System.Windows.Forms.ColumnHeader();
            this.ChrGames = new System.Windows.Forms.ColumnHeader();
            this.ChrGamesDiff = new System.Windows.Forms.ColumnHeader();
            this.ChrBuchholz = new System.Windows.Forms.ColumnHeader();
            this.ChrFeinbuchholz = new System.Windows.Forms.ColumnHeader();
            this.ChrSets = new System.Windows.Forms.ColumnHeader();
            this.ChrSetsDiff = new System.Windows.Forms.ColumnHeader();
            this.ChrGamepoints = new System.Windows.Forms.ColumnHeader();
            this.ChrGamepointsDiff = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SpcEntries = new System.Windows.Forms.SplitContainer();
            this.BtnTeams = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LvwEntries = new System.Windows.Forms.ListView();
            this.ChrResultsRound = new System.Windows.Forms.ColumnHeader();
            this.ChrResultsTeam1 = new System.Windows.Forms.ColumnHeader();
            this.ChrResultsRound2 = new System.Windows.Forms.ColumnHeader();
            this.ChrResultsGames = new System.Windows.Forms.ColumnHeader();
            this.ChrResultsSets = new System.Windows.Forms.ColumnHeader();
            this.ChrResultsPoints = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.SpcMain)).BeginInit();
            this.SpcMain.Panel1.SuspendLayout();
            this.SpcMain.Panel2.SuspendLayout();
            this.SpcMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpcRanking)).BeginInit();
            this.SpcRanking.Panel1.SuspendLayout();
            this.SpcRanking.Panel2.SuspendLayout();
            this.SpcRanking.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpcEntries)).BeginInit();
            this.SpcEntries.Panel1.SuspendLayout();
            this.SpcEntries.Panel2.SuspendLayout();
            this.SpcEntries.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpcMain
            // 
            this.SpcMain.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.SpcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpcMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SpcMain.Location = new System.Drawing.Point(0, 0);
            this.SpcMain.Margin = new System.Windows.Forms.Padding(4);
            this.SpcMain.Name = "SpcMain";
            // 
            // SpcMain.Panel1
            // 
            this.SpcMain.Panel1.Controls.Add(this.groupBox1);
            // 
            // SpcMain.Panel2
            // 
            this.SpcMain.Panel2.Controls.Add(this.groupBox2);
            this.SpcMain.Size = new System.Drawing.Size(1916, 1110);
            this.SpcMain.SplitterDistance = 1465;
            this.SpcMain.SplitterWidth = 6;
            this.SpcMain.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SpcRanking);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1465, 1110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rangliste";
            // 
            // SpcRanking
            // 
            this.SpcRanking.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.SpcRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpcRanking.Location = new System.Drawing.Point(4, 28);
            this.SpcRanking.Margin = new System.Windows.Forms.Padding(4);
            this.SpcRanking.Name = "SpcRanking";
            this.SpcRanking.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpcRanking.Panel1
            // 
            this.SpcRanking.Panel1.Controls.Add(this.BtnDisplay);
            this.SpcRanking.Panel1.Controls.Add(this.BtnPrint);
            // 
            // SpcRanking.Panel2
            // 
            this.SpcRanking.Panel2.Controls.Add(this.LvwRanking);
            this.SpcRanking.Size = new System.Drawing.Size(1457, 1078);
            this.SpcRanking.SplitterDistance = 49;
            this.SpcRanking.SplitterWidth = 8;
            this.SpcRanking.TabIndex = 1;
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Location = new System.Drawing.Point(123, 4);
            this.BtnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(111, 39);
            this.BtnDisplay.TabIndex = 2;
            this.BtnDisplay.Text = "Display";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            this.BtnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(4, 4);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(111, 39);
            this.BtnPrint.TabIndex = 1;
            this.BtnPrint.Text = "Drucken";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // LvwRanking
            // 
            this.LvwRanking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChrRank,
            this.ChrId,
            this.ChrName,
            this.ChrPoints,
            this.ChrRounds,
            this.ChrBuchholz,
            this.ChrFeinbuchholz,
            this.ChrGames,
            this.ChrGamesDiff,
            this.ChrSets,
            this.ChrSetsDiff,
            this.ChrGamepoints,
            this.ChrGamepointsDiff});
            this.LvwRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwRanking.FullRowSelect = true;
            this.LvwRanking.Location = new System.Drawing.Point(0, 0);
            this.LvwRanking.Margin = new System.Windows.Forms.Padding(4);
            this.LvwRanking.Name = "LvwRanking";
            this.LvwRanking.OwnerDraw = true;
            this.LvwRanking.Size = new System.Drawing.Size(1457, 1021);
            this.LvwRanking.TabIndex = 0;
            this.LvwRanking.UseCompatibleStateImageBehavior = false;
            this.LvwRanking.View = System.Windows.Forms.View.Details;
            this.LvwRanking.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.LvwRanking_DrawColumnHeader);
            this.LvwRanking.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.LvwRanking_DrawItem);
            // 
            // ChrRank
            // 
            this.ChrRank.Text = "Rang";
            // 
            // ChrId
            // 
            this.ChrId.Text = "Id";
            this.ChrId.Width = 50;
            // 
            // ChrName
            // 
            this.ChrName.Text = "Name";
            this.ChrName.Width = 150;
            // 
            // ChrRounds
            // 
            this.ChrRounds.Text = "R";
            this.ChrRounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrRounds.Width = 30;
            // 
            // ChrPoints
            // 
            this.ChrPoints.Text = "P";
            this.ChrPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrPoints.Width = 40;
            // 
            // ChrGames
            // 
            this.ChrGames.Text = "G";
            this.ChrGames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrGames.Width = 40;
            // 
            // ChrGamesDiff
            // 
            this.ChrGamesDiff.Text = "G Diff";
            this.ChrGamesDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrGamesDiff.Width = 50;
            // 
            // ChrBuchholz
            // 
            this.ChrBuchholz.Text = "BHZ";
            this.ChrBuchholz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrBuchholz.Width = 40;
            // 
            // ChrFeinbuchholz
            // 
            this.ChrFeinbuchholz.Text = "FBHZ";
            this.ChrFeinbuchholz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrFeinbuchholz.Width = 45;
            // 
            // ChrSets
            // 
            this.ChrSets.Text = "S";
            this.ChrSets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrSets.Width = 40;
            // 
            // ChrSetsDiff
            // 
            this.ChrSetsDiff.Text = "S Diff";
            this.ChrSetsDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrSetsDiff.Width = 50;
            // 
            // ChrGamepoints
            // 
            this.ChrGamepoints.Text = "P";
            this.ChrGamepoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrGamepoints.Width = 50;
            // 
            // ChrGamepointsDiff
            // 
            this.ChrGamepointsDiff.Text = "P Diff";
            this.ChrGamepointsDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SpcEntries);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(445, 1110);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Begegnungen";
            // 
            // SpcEntries
            // 
            this.SpcEntries.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.SpcEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpcEntries.Location = new System.Drawing.Point(4, 28);
            this.SpcEntries.Margin = new System.Windows.Forms.Padding(4);
            this.SpcEntries.Name = "SpcEntries";
            this.SpcEntries.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpcEntries.Panel1
            // 
            this.SpcEntries.Panel1.Controls.Add(this.BtnTeams);
            this.SpcEntries.Panel1.Controls.Add(this.BtnDelete);
            this.SpcEntries.Panel1.Controls.Add(this.BtnEdit);
            this.SpcEntries.Panel1.Controls.Add(this.BtnAdd);
            // 
            // SpcEntries.Panel2
            // 
            this.SpcEntries.Panel2.Controls.Add(this.LvwEntries);
            this.SpcEntries.Size = new System.Drawing.Size(437, 1078);
            this.SpcEntries.SplitterDistance = 45;
            this.SpcEntries.SplitterWidth = 8;
            this.SpcEntries.TabIndex = 0;
            // 
            // BtnTeams
            // 
            this.BtnTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTeams.Location = new System.Drawing.Point(315, 4);
            this.BtnTeams.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTeams.Name = "BtnTeams";
            this.BtnTeams.Size = new System.Drawing.Size(111, 39);
            this.BtnTeams.TabIndex = 1;
            this.BtnTeams.Text = "Teams";
            this.BtnTeams.UseVisualStyleBackColor = true;
            this.BtnTeams.Click += new System.EventHandler(this.BtnTeams_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(280, 4);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(129, 39);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Löschen";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(142, 4);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(129, 39);
            this.BtnEdit.TabIndex = 0;
            this.BtnEdit.Text = "Bearbeiten...";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(4, 4);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(129, 39);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Neu...";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LvwEntries
            // 
            this.LvwEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChrResultsRound,
            this.ChrResultsTeam1,
            this.ChrResultsRound2,
            this.ChrResultsGames,
            this.ChrResultsSets,
            this.ChrResultsPoints});
            this.LvwEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwEntries.FullRowSelect = true;
            this.LvwEntries.Location = new System.Drawing.Point(0, 0);
            this.LvwEntries.Margin = new System.Windows.Forms.Padding(4);
            this.LvwEntries.Name = "LvwEntries";
            this.LvwEntries.OwnerDraw = true;
            this.LvwEntries.Size = new System.Drawing.Size(437, 1025);
            this.LvwEntries.TabIndex = 0;
            this.LvwEntries.UseCompatibleStateImageBehavior = false;
            this.LvwEntries.View = System.Windows.Forms.View.Details;
            this.LvwEntries.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.LvwEntries_DrawColumnHeader);
            this.LvwEntries.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.LvwEntries_DrawItem);
            // 
            // ChrResultsRound
            // 
            this.ChrResultsRound.Text = "R";
            this.ChrResultsRound.Width = 30;
            // 
            // ChrResultsTeam1
            // 
            this.ChrResultsTeam1.Text = "Team 1";
            this.ChrResultsTeam1.Width = 120;
            // 
            // ChrResultsRound2
            // 
            this.ChrResultsRound2.Text = "Team 2";
            this.ChrResultsRound2.Width = 120;
            // 
            // ChrResultsGames
            // 
            this.ChrResultsGames.Text = "G";
            this.ChrResultsGames.Width = 40;
            // 
            // ChrResultsSets
            // 
            this.ChrResultsSets.Text = "S";
            this.ChrResultsSets.Width = 40;
            // 
            // ChrResultsPoints
            // 
            this.ChrResultsPoints.Text = "P";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1916, 1110);
            this.Controls.Add(this.SpcMain);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schoch Rechner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.SpcMain.Panel1.ResumeLayout(false);
            this.SpcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpcMain)).EndInit();
            this.SpcMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.SpcRanking.Panel1.ResumeLayout(false);
            this.SpcRanking.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpcRanking)).EndInit();
            this.SpcRanking.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.SpcEntries.Panel1.ResumeLayout(false);
            this.SpcEntries.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpcEntries)).EndInit();
            this.SpcEntries.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer SpcMain;
        private GroupBox groupBox1;
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
    }
}