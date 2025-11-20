namespace SchochRechner
{
    partial class FrmDisplay
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
            components = new System.ComponentModel.Container();
            LvwRanking = new ListView();
            ChrHidden = new ColumnHeader();
            ChrRank = new ColumnHeader();
            ChrTeam = new ColumnHeader();
            ChrRounds = new ColumnHeader();
            ChrPoints = new ColumnHeader();
            ChrBuchholz = new ColumnHeader();
            ChrGames = new ColumnHeader();
            ChrGamesDiff = new ColumnHeader();
            ChrSets = new ColumnHeader();
            ChrSetsDiff = new ColumnHeader();
            ChrGamepoints = new ColumnHeader();
            ChrGamepointsDiff = new ColumnHeader();
            LvwDraw = new ListView();
            ChrSpacer = new ColumnHeader();
            ChrCourt = new ColumnHeader();
            ChrTeam1 = new ColumnHeader();
            ChrVs = new ColumnHeader();
            ChrTeam2 = new ColumnHeader();
            ChrResult = new ColumnHeader();
            TmrChangeView = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            LblDrawsRound = new Label();
            TclDisplay = new TabControl();
            TpgRanking = new TabPage();
            TpgDraw = new TabPage();
            tableLayoutPanel1.SuspendLayout();
            TclDisplay.SuspendLayout();
            TpgRanking.SuspendLayout();
            TpgDraw.SuspendLayout();
            SuspendLayout();
            // 
            // LvwRanking
            // 
            LvwRanking.Columns.AddRange(new ColumnHeader[] { ChrHidden, ChrRank, ChrTeam, ChrRounds, ChrPoints, ChrBuchholz, ChrGames, ChrGamesDiff, ChrSets, ChrSetsDiff, ChrGamepoints, ChrGamepointsDiff });
            LvwRanking.Dock = DockStyle.Fill;
            LvwRanking.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LvwRanking.Location = new Point(3, 3);
            LvwRanking.Name = "LvwRanking";
            LvwRanking.OwnerDraw = true;
            LvwRanking.Size = new Size(1639, 723);
            LvwRanking.TabIndex = 0;
            LvwRanking.UseCompatibleStateImageBehavior = false;
            LvwRanking.View = View.Details;
            LvwRanking.DrawColumnHeader += LvwRanking_DrawColumnHeader;
            LvwRanking.DrawItem += LvwRanking_DrawItem;
            // 
            // ChrHidden
            // 
            ChrHidden.Width = 0;
            // 
            // ChrRank
            // 
            ChrRank.Text = "Rang";
            ChrRank.TextAlign = HorizontalAlignment.Center;
            ChrRank.Width = 100;
            // 
            // ChrTeam
            // 
            ChrTeam.Text = "Name";
            ChrTeam.Width = 700;
            // 
            // ChrRounds
            // 
            ChrRounds.Text = "Runden";
            ChrRounds.TextAlign = HorizontalAlignment.Center;
            ChrRounds.Width = 140;
            // 
            // ChrPoints
            // 
            ChrPoints.Text = "Punkte";
            ChrPoints.TextAlign = HorizontalAlignment.Center;
            ChrPoints.Width = 130;
            // 
            // ChrBuchholz
            // 
            ChrBuchholz.Text = "BHZ";
            ChrBuchholz.TextAlign = HorizontalAlignment.Center;
            ChrBuchholz.Width = 80;
            // 
            // ChrGames
            // 
            ChrGames.Text = "Spiele";
            ChrGames.TextAlign = HorizontalAlignment.Center;
            ChrGames.Width = 120;
            // 
            // ChrGamesDiff
            // 
            ChrGamesDiff.Text = "";
            ChrGamesDiff.TextAlign = HorizontalAlignment.Center;
            ChrGamesDiff.Width = 100;
            // 
            // ChrSets
            // 
            ChrSets.Text = "Sätze";
            ChrSets.TextAlign = HorizontalAlignment.Center;
            ChrSets.Width = 110;
            // 
            // ChrSetsDiff
            // 
            ChrSetsDiff.Text = "";
            ChrSetsDiff.TextAlign = HorizontalAlignment.Center;
            ChrSetsDiff.Width = 100;
            // 
            // ChrGamepoints
            // 
            ChrGamepoints.Text = "SP";
            ChrGamepoints.TextAlign = HorizontalAlignment.Center;
            ChrGamepoints.Width = 140;
            // 
            // ChrGamepointsDiff
            // 
            ChrGamepointsDiff.Text = "";
            ChrGamepointsDiff.TextAlign = HorizontalAlignment.Center;
            ChrGamepointsDiff.Width = 100;
            // 
            // LvwDraw
            // 
            LvwDraw.Columns.AddRange(new ColumnHeader[] { ChrSpacer, ChrCourt, ChrTeam1, ChrVs, ChrTeam2, ChrResult });
            LvwDraw.Dock = DockStyle.Fill;
            LvwDraw.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LvwDraw.Location = new Point(3, 63);
            LvwDraw.Name = "LvwDraw";
            LvwDraw.OwnerDraw = true;
            LvwDraw.Size = new Size(1633, 657);
            LvwDraw.TabIndex = 1;
            LvwDraw.UseCompatibleStateImageBehavior = false;
            LvwDraw.View = View.Details;
            LvwDraw.DrawColumnHeader += LvwRanking_DrawColumnHeader;
            LvwDraw.DrawItem += LvwRanking_DrawItem;
            // 
            // ChrSpacer
            // 
            ChrSpacer.Text = "";
            ChrSpacer.Width = 10;
            // 
            // ChrCourt
            // 
            ChrCourt.Text = "Feld";
            ChrCourt.TextAlign = HorizontalAlignment.Center;
            ChrCourt.Width = 80;
            // 
            // ChrTeam1
            // 
            ChrTeam1.Text = "Team 1";
            ChrTeam1.TextAlign = HorizontalAlignment.Right;
            ChrTeam1.Width = 600;
            // 
            // ChrVs
            // 
            ChrVs.Text = "";
            ChrVs.TextAlign = HorizontalAlignment.Center;
            // 
            // ChrTeam2
            // 
            ChrTeam2.Text = "Team 2";
            ChrTeam2.Width = 600;
            // 
            // ChrResult
            // 
            ChrResult.Text = "Resultat";
            ChrResult.TextAlign = HorizontalAlignment.Center;
            ChrResult.Width = 140;
            // 
            // TmrChangeView
            // 
            TmrChangeView.Enabled = true;
            TmrChangeView.Interval = 30000;
            TmrChangeView.Tick += TmrChangeView_Tick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(LvwDraw, 0, 1);
            tableLayoutPanel1.Controls.Add(LblDrawsRound, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1639, 723);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // LblDrawsRound
            // 
            LblDrawsRound.AutoSize = true;
            LblDrawsRound.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDrawsRound.Location = new Point(3, 0);
            LblDrawsRound.Name = "LblDrawsRound";
            LblDrawsRound.Size = new Size(203, 60);
            LblDrawsRound.TabIndex = 2;
            LblDrawsRound.Text = "Runde 0";
            // 
            // TclDisplay
            // 
            TclDisplay.Controls.Add(TpgRanking);
            TclDisplay.Controls.Add(TpgDraw);
            TclDisplay.Dock = DockStyle.Fill;
            TclDisplay.Location = new Point(0, 0);
            TclDisplay.Name = "TclDisplay";
            TclDisplay.SelectedIndex = 0;
            TclDisplay.Size = new Size(1653, 757);
            TclDisplay.TabIndex = 3;
            // 
            // TpgRanking
            // 
            TpgRanking.Controls.Add(LvwRanking);
            TpgRanking.Location = new Point(4, 24);
            TpgRanking.Name = "TpgRanking";
            TpgRanking.Padding = new Padding(3);
            TpgRanking.Size = new Size(1645, 729);
            TpgRanking.TabIndex = 0;
            TpgRanking.Text = "Rangliste";
            TpgRanking.UseVisualStyleBackColor = true;
            // 
            // TpgDraw
            // 
            TpgDraw.Controls.Add(tableLayoutPanel1);
            TpgDraw.Location = new Point(4, 24);
            TpgDraw.Name = "TpgDraw";
            TpgDraw.Padding = new Padding(3);
            TpgDraw.Size = new Size(1645, 729);
            TpgDraw.TabIndex = 1;
            TpgDraw.Text = "Auslosung";
            TpgDraw.UseVisualStyleBackColor = true;
            // 
            // FrmDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 757);
            Controls.Add(TclDisplay);
            Name = "FrmDisplay";
            Text = "Display";
            FormClosing += FrmDisplay_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            TclDisplay.ResumeLayout(false);
            TpgRanking.ResumeLayout(false);
            TpgDraw.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView LvwRanking;
        private ColumnHeader ChrRank;
        private ColumnHeader ChrTeam;
        private ColumnHeader ChrPoints;
        private ColumnHeader ChrSets;
        private ColumnHeader ChrBuchholz;
        private ColumnHeader ChrRounds;
        private ColumnHeader ChrHidden;
        private ColumnHeader ChrGamesDiff;
        private ColumnHeader ChrSetsDiff;
        private ColumnHeader ChrGamepoints;
        private ColumnHeader ChrGamepointsDiff;
        private ColumnHeader ChrGames;
        private ListView LvwDraw;
        private ColumnHeader ChrCourt;
        private ColumnHeader ChrTeam1;
        private ColumnHeader ChrTeam2;
        private ColumnHeader ChrSpacer;
        private System.Windows.Forms.Timer TmrChangeView;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LblDrawsRound;
        private TabControl TclDisplay;
        private TabPage TpgRanking;
        private TabPage TpgDraw;
        private ColumnHeader ChrVs;
        private ColumnHeader ChrResult;
    }
}