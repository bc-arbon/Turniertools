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
            CbxTeam1 = new ComboBox();
            groupBox2 = new GroupBox();
            CbxTeam2 = new ComboBox();
            BtnOk = new Button();
            TxtTeam1 = new TextBox();
            TxtTeam2 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            BtnOk.Location = new Point(417, 108);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 2;
            BtnOk.Text = "OK";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // TxtTeam1
            // 
            TxtTeam1.Location = new Point(6, 51);
            TxtTeam1.Name = "TxtTeam1";
            TxtTeam1.Size = new Size(223, 23);
            TxtTeam1.TabIndex = 1;
            // 
            // TxtTeam2
            // 
            TxtTeam2.Location = new Point(6, 51);
            TxtTeam2.Name = "TxtTeam2";
            TxtTeam2.Size = new Size(223, 23);
            TxtTeam2.TabIndex = 2;
            // 
            // FrmCustomMatchcard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 143);
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
    }
}