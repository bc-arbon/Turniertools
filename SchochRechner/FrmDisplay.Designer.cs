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
            this.ChrRounds = new System.Windows.Forms.ColumnHeader();
            this.ChrGames = new System.Windows.Forms.ColumnHeader();
            this.ChrGamesDiff = new System.Windows.Forms.ColumnHeader();
            this.ChrSets = new System.Windows.Forms.ColumnHeader();
            this.ChrSetsDiff = new System.Windows.Forms.ColumnHeader();
            this.ChrBuchholz = new System.Windows.Forms.ColumnHeader();
            this.ChrFeinbuchholz = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // LvwRanking
            // 
            this.LvwRanking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChrHidden,
            this.ChrRank,
            this.ChrTeam,
            this.ChrRounds,
            this.ChrGames,
            this.ChrGamesDiff,
            this.ChrSets,
            this.ChrSetsDiff,
            this.ChrBuchholz,
            this.ChrFeinbuchholz});
            this.LvwRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwRanking.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvwRanking.Location = new System.Drawing.Point(0, 0);
            this.LvwRanking.Name = "LvwRanking";
            this.LvwRanking.OwnerDraw = true;
            this.LvwRanking.Size = new System.Drawing.Size(1904, 1041);
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
            // ChrRounds
            // 
            this.ChrRounds.Text = "Runden";
            this.ChrRounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrRounds.Width = 140;
            // 
            // ChrGames
            // 
            this.ChrGames.Text = "Spiele";
            this.ChrGames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrGames.Width = 110;
            // 
            // ChrGamesDiff
            // 
            this.ChrGamesDiff.Text = "Diff";
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
            this.ChrSetsDiff.Text = "Diff";
            this.ChrSetsDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrSetsDiff.Width = 100;
            // 
            // ChrBuchholz
            // 
            this.ChrBuchholz.Text = "BHZ";
            this.ChrBuchholz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrBuchholz.Width = 0;
            // 
            // ChrFeinbuchholz
            // 
            this.ChrFeinbuchholz.Text = "FBHZ";
            this.ChrFeinbuchholz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChrFeinbuchholz.Width = 0;
            // 
            // FrmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.LvwRanking);
            this.Name = "FrmDisplay";
            this.Text = "FrmDisplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDisplay_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView LvwRanking;
        private ColumnHeader ChrRank;
        private ColumnHeader ChrTeam;
        private ColumnHeader ChrGames;
        private ColumnHeader ChrSets;
        private ColumnHeader ChrBuchholz;
        private ColumnHeader ChrRounds;
        private ColumnHeader ChrFeinbuchholz;
        private ColumnHeader ChrHidden;
        private ColumnHeader ChrGamesDiff;
        private ColumnHeader ChrSetsDiff;
    }
}