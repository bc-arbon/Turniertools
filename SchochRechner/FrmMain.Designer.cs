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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LvwRanking = new System.Windows.Forms.ListView();
            this.ChrName = new System.Windows.Forms.ColumnHeader();
            this.ChrRounds = new System.Windows.Forms.ColumnHeader();
            this.ChrGameWins = new System.Windows.Forms.ColumnHeader();
            this.ChrGameLosses = new System.Windows.Forms.ColumnHeader();
            this.ChrGamesDiff = new System.Windows.Forms.ColumnHeader();
            this.ChrSetWins = new System.Windows.Forms.ColumnHeader();
            this.ChrSetLosses = new System.Windows.Forms.ColumnHeader();
            this.ChrSetsDiff = new System.Windows.Forms.ColumnHeader();
            this.ChrBuchholz = new System.Windows.Forms.ColumnHeader();
            this.ChrFeinbuchholz = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ChrRound = new System.Windows.Forms.ColumnHeader();
            this.ChrTeam1 = new System.Windows.Forms.ColumnHeader();
            this.ChrRound2 = new System.Windows.Forms.ColumnHeader();
            this.ChrGames = new System.Windows.Forms.ColumnHeader();
            this.ChrSets = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1236, 558);
            this.splitContainer1.SplitterDistance = 696;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LvwRanking);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 558);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rangliste";
            // 
            // LvwRanking
            // 
            this.LvwRanking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChrName,
            this.ChrRounds,
            this.ChrGameWins,
            this.ChrGameLosses,
            this.ChrGamesDiff,
            this.ChrSetWins,
            this.ChrSetLosses,
            this.ChrSetsDiff,
            this.ChrBuchholz,
            this.ChrFeinbuchholz});
            this.LvwRanking.Cursor = System.Windows.Forms.Cursors.Default;
            this.LvwRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwRanking.FullRowSelect = true;
            this.LvwRanking.Location = new System.Drawing.Point(3, 19);
            this.LvwRanking.Name = "LvwRanking";
            this.LvwRanking.Size = new System.Drawing.Size(690, 536);
            this.LvwRanking.TabIndex = 0;
            this.LvwRanking.UseCompatibleStateImageBehavior = false;
            this.LvwRanking.View = System.Windows.Forms.View.Details;
            // 
            // ChrName
            // 
            this.ChrName.Text = "Name";
            this.ChrName.Width = 120;
            // 
            // ChrRounds
            // 
            this.ChrRounds.Text = "R";
            this.ChrRounds.Width = 30;
            // 
            // ChrGameWins
            // 
            this.ChrGameWins.Text = "G W";
            // 
            // ChrGameLosses
            // 
            this.ChrGameLosses.Text = "G L";
            // 
            // ChrGamesDiff
            // 
            this.ChrGamesDiff.Text = "G Diff";
            // 
            // ChrSetWins
            // 
            this.ChrSetWins.Text = "S W";
            // 
            // ChrSetLosses
            // 
            this.ChrSetLosses.Text = "S L";
            // 
            // ChrSetsDiff
            // 
            this.ChrSetsDiff.Text = "S Diff";
            // 
            // ChrBuchholz
            // 
            this.ChrBuchholz.Text = "BHZ";
            // 
            // ChrFeinbuchholz
            // 
            this.ChrFeinbuchholz.Text = "FBHZ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 558);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChrRound,
            this.ChrTeam1,
            this.ChrRound2,
            this.ChrGames,
            this.ChrSets});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(530, 536);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ChrRound
            // 
            this.ChrRound.Text = "R";
            this.ChrRound.Width = 30;
            // 
            // ChrTeam1
            // 
            this.ChrTeam1.Text = "Team 1";
            this.ChrTeam1.Width = 120;
            // 
            // ChrRound2
            // 
            this.ChrRound2.Text = "Team 2";
            this.ChrRound2.Width = 120;
            // 
            // ChrGames
            // 
            this.ChrGames.Text = "G";
            this.ChrGames.Width = 40;
            // 
            // ChrSets
            // 
            this.ChrSets.Text = "S";
            this.ChrSets.Width = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 558);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private ListView LvwRanking;
        private ColumnHeader ChrName;
        private ColumnHeader ChrGameWins;
        private ColumnHeader ChrGameLosses;
        private ColumnHeader ChrBuchholz;
        private ColumnHeader ChrFeinbuchholz;
        private GroupBox groupBox2;
        private ColumnHeader ChrGamesDiff;
        private ColumnHeader ChrSetWins;
        private ColumnHeader ChrSetLosses;
        private ColumnHeader ChrSetsDiff;
        private ColumnHeader ChrRounds;
        private ListView listView1;
        private ColumnHeader ChrRound;
        private ColumnHeader ChrTeam1;
        private ColumnHeader ChrRound2;
        private ColumnHeader ChrGames;
        private ColumnHeader ChrSets;
        private Button button1;
    }
}