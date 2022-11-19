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
            this.LvwRanking = new System.Windows.Forms.ListView();
            this.ChrHidden = new System.Windows.Forms.ColumnHeader();
            this.ChrRank = new System.Windows.Forms.ColumnHeader();
            this.ChrTeam = new System.Windows.Forms.ColumnHeader();
            this.ChrPoints = new System.Windows.Forms.ColumnHeader();
            this.ChrRounds = new System.Windows.Forms.ColumnHeader();
            this.ChrBuchholz = new System.Windows.Forms.ColumnHeader();
            this.ChrGames = new System.Windows.Forms.ColumnHeader();
            this.ChrGamesDiff = new System.Windows.Forms.ColumnHeader();
            this.ChrSets = new System.Windows.Forms.ColumnHeader();
            this.ChrSetsDiff = new System.Windows.Forms.ColumnHeader();
            this.ChrGamepoints = new System.Windows.Forms.ColumnHeader();
            this.ChrGamepointsDiff = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // LvwRanking
            // 
            this.LvwRanking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChrHidden,
            this.ChrRank,
            this.ChrTeam,
            this.ChrPoints,
            this.ChrRounds,
            this.ChrBuchholz,
            this.ChrGames,
            this.ChrGamesDiff,
            this.ChrSets,
            this.ChrSetsDiff,
            this.ChrGamepoints,
            this.ChrGamepointsDiff});
            this.LvwRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwRanking.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvwRanking.Location = new System.Drawing.Point(0, 0);
            this.LvwRanking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LvwRanking.Name = "LvwRanking";
            this.LvwRanking.OwnerDraw = true;
            this.LvwRanking.Size = new System.Drawing.Size(2720, 1735);
            this.LvwRanking.TabIndex = 0;
            this.LvwRanking.UseCompatibleStateImageBehavior = false;
            this.LvwRanking.View = System.Windows.Forms.View.Details;
            this.LvwRanking.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.LvwRanking_DrawColumnHeader);
            this.LvwRanking.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.LvwRanking_DrawItem);
            // 
            // ChrHidden
            // 
            this.ChrHidden.Width = 0;
            // 
            // ChrRank
            // 
            this.ChrRank.Text = "Rang";
            this.ChrRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrRank.Width = 100;
            // 
            // ChrTeam
            // 
            this.ChrTeam.Text = "Name";
            this.ChrTeam.Width = 700;
            // 
            // ChrPoints
            // 
            this.ChrPoints.Text = "Punkte";
            this.ChrPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrPoints.Width = 130;
            // 
            // ChrRounds
            // 
            this.ChrRounds.Text = "Runden";
            this.ChrRounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrRounds.Width = 140;
            // 
            // ChrBuchholz
            // 
            this.ChrBuchholz.Text = "BHZ";
            this.ChrBuchholz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrBuchholz.Width = 80;
            // 
            // ChrGames
            // 
            this.ChrGames.Text = "Spiele";
            this.ChrGames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrGames.Width = 120;
            // 
            // ChrGamesDiff
            // 
            this.ChrGamesDiff.Text = "";
            this.ChrGamesDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrGamesDiff.Width = 100;
            // 
            // ChrSets
            // 
            this.ChrSets.Text = "Sätze";
            this.ChrSets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrSets.Width = 110;
            // 
            // ChrSetsDiff
            // 
            this.ChrSetsDiff.Text = "";
            this.ChrSetsDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrSetsDiff.Width = 100;
            // 
            // ChrGamepoints
            // 
            this.ChrGamepoints.Text = "SP";
            this.ChrGamepoints.Width = 140;
            // 
            // ChrGamepointsDiff
            // 
            this.ChrGamepointsDiff.Text = "";
            this.ChrGamepointsDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrGamepointsDiff.Width = 100;
            // 
            // FrmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2720, 1735);
            this.Controls.Add(this.LvwRanking);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDisplay";
            this.Text = "FrmDisplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDisplay_FormClosing);
            this.ResumeLayout(false);

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