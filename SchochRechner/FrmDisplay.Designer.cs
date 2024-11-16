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
            LvwRanking = new ListView();
            ChrHidden = new ColumnHeader();
            ChrRank = new ColumnHeader();
            ChrTeam = new ColumnHeader();
            ChrPoints = new ColumnHeader();
            ChrRounds = new ColumnHeader();
            ChrBuchholz = new ColumnHeader();
            ChrGames = new ColumnHeader();
            ChrGamesDiff = new ColumnHeader();
            ChrSets = new ColumnHeader();
            ChrSetsDiff = new ColumnHeader();
            ChrGamepoints = new ColumnHeader();
            ChrGamepointsDiff = new ColumnHeader();
            SuspendLayout();
            // 
            // LvwRanking
            // 
            LvwRanking.Columns.AddRange(new ColumnHeader[] { ChrHidden, ChrRank, ChrTeam, ChrRounds, ChrPoints, ChrBuchholz, ChrGames, ChrGamesDiff, ChrSets, ChrSetsDiff, ChrGamepoints, ChrGamepointsDiff });
            LvwRanking.Dock = DockStyle.Fill;
            LvwRanking.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            LvwRanking.Location = new Point(0, 0);
            LvwRanking.Name = "LvwRanking";
            LvwRanking.OwnerDraw = true;
            LvwRanking.Size = new Size(1653, 757);
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
            // ChrPoints
            // 
            ChrPoints.Text = "Punkte";
            ChrPoints.TextAlign = HorizontalAlignment.Center;
            ChrPoints.Width = 130;
            // 
            // ChrRounds
            // 
            ChrRounds.Text = "Runden";
            ChrRounds.TextAlign = HorizontalAlignment.Center;
            ChrRounds.Width = 140;
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
            ChrGamepoints.Width = 140;
            // 
            // ChrGamepointsDiff
            // 
            ChrGamepointsDiff.Text = "";
            ChrGamepointsDiff.TextAlign = HorizontalAlignment.Center;
            ChrGamepointsDiff.Width = 100;
            // 
            // FrmDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 757);
            Controls.Add(LvwRanking);
            Name = "FrmDisplay";
            Text = "Display";
            FormClosing += FrmDisplay_FormClosing;
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
    }
}