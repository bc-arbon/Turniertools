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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1087, 549);
            this.splitContainer1.SplitterDistance = 734;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LvwRanking);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 549);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            this.LvwRanking.Size = new System.Drawing.Size(728, 527);
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
            this.ChrRounds.Text = "Rounds";
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
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 549);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 549);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
    }
}