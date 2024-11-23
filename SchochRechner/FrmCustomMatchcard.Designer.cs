namespace SchochRechner
{
    partial class FrmCustomMatchcard
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
            groupBox1 = new GroupBox();
            TxtTeam1 = new TextBox();
            CbxTeam1 = new ComboBox();
            groupBox2 = new GroupBox();
            TxtTeam2 = new TextBox();
            CbxTeam2 = new ComboBox();
            BtnOk = new Button();
            groupBox3 = new GroupBox();
            TxtRound = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtCourt = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtTeam1);
            groupBox1.Controls.Add(CbxTeam1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Team 1";
            // 
            // TxtTeam1
            // 
            TxtTeam1.Location = new Point(6, 51);
            TxtTeam1.Name = "TxtTeam1";
            TxtTeam1.Size = new Size(223, 23);
            TxtTeam1.TabIndex = 1;
            // 
            // CbxTeam1
            // 
            CbxTeam1.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxTeam1.FormattingEnabled = true;
            CbxTeam1.Location = new Point(6, 22);
            CbxTeam1.Name = "CbxTeam1";
            CbxTeam1.Size = new Size(223, 23);
            CbxTeam1.TabIndex = 0;
            CbxTeam1.SelectedIndexChanged += CbxTeam1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtTeam2);
            groupBox2.Controls.Add(CbxTeam2);
            groupBox2.Location = new Point(257, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(235, 88);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Team 2";
            // 
            // TxtTeam2
            // 
            TxtTeam2.Location = new Point(6, 51);
            TxtTeam2.Name = "TxtTeam2";
            TxtTeam2.Size = new Size(223, 23);
            TxtTeam2.TabIndex = 2;
            // 
            // CbxTeam2
            // 
            CbxTeam2.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxTeam2.FormattingEnabled = true;
            CbxTeam2.Location = new Point(6, 22);
            CbxTeam2.Name = "CbxTeam2";
            CbxTeam2.Size = new Size(223, 23);
            CbxTeam2.TabIndex = 0;
            CbxTeam2.SelectedIndexChanged += CbxTeam2_SelectedIndexChanged;
            // 
            // BtnOk
            // 
            BtnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnOk.Location = new Point(417, 163);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 2;
            BtnOk.Text = "OK";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(TxtCourt);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(TxtRound);
            groupBox3.Location = new Point(12, 106);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(474, 51);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // TxtRound
            // 
            TxtRound.Location = new Point(56, 19);
            TxtRound.Name = "TxtRound";
            TxtRound.Size = new Size(50, 23);
            TxtRound.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Runde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 22);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "Feld:";
            // 
            // TxtCourt
            // 
            TxtCourt.Location = new Point(185, 19);
            TxtCourt.Name = "TxtCourt";
            TxtCourt.Size = new Size(50, 23);
            TxtCourt.TabIndex = 3;
            // 
            // FrmCustomMatchcard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 198);
            Controls.Add(groupBox3);
            Controls.Add(BtnOk);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCustomMatchcard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Matchblatt";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox CbxTeam1;
        private GroupBox groupBox2;
        private ComboBox CbxTeam2;
        private Button BtnOk;
        private TextBox TxtTeam1;
        private TextBox TxtTeam2;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox TxtCourt;
        private Label label1;
        private TextBox TxtRound;
    }
}