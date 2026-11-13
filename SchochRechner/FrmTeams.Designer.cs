namespace SchochRechner
{
    partial class FrmTeams
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
            LvwTeams = new ListView();
            ChrId = new ColumnHeader();
            ChrName = new ColumnHeader();
            BtnNew = new Button();
            BtnClose = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            CbxGroup = new ComboBox();
            BtnAddGroup = new Button();
            BtnRenameGroup = new Button();
            BtnDeleteGroup = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(LvwTeams);
            groupBox1.Location = new Point(12, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(656, 344);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Teams";
            // 
            // LvwTeams
            // 
            LvwTeams.Columns.AddRange(new ColumnHeader[] { ChrId, ChrName });
            LvwTeams.Dock = DockStyle.Fill;
            LvwTeams.FullRowSelect = true;
            LvwTeams.Location = new Point(3, 19);
            LvwTeams.Name = "LvwTeams";
            LvwTeams.OwnerDraw = true;
            LvwTeams.Size = new Size(650, 322);
            LvwTeams.TabIndex = 0;
            LvwTeams.UseCompatibleStateImageBehavior = false;
            LvwTeams.View = View.Details;
            LvwTeams.ColumnClick += LvwTeams_ColumnClick;
            LvwTeams.DrawColumnHeader += LvwTeams_DrawColumnHeader;
            LvwTeams.DrawItem += LvwTeams_DrawItem;
            // 
            // ChrId
            // 
            ChrId.Text = "Id";
            ChrId.Width = 30;
            // 
            // ChrName
            // 
            ChrName.Text = "Name";
            ChrName.Width = 250;
            // 
            // BtnNew
            // 
            BtnNew.Location = new Point(86, 12);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(75, 23);
            BtnNew.TabIndex = 1;
            BtnNew.Text = "Neu";
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnClose.DialogResult = DialogResult.OK;
            BtnClose.Location = new Point(593, 427);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(75, 23);
            BtnClose.TabIndex = 2;
            BtnClose.Text = "OK";
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(167, 12);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 23);
            BtnEdit.TabIndex = 3;
            BtnEdit.Text = "Bearbeiten";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(248, 12);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 4;
            BtnDelete.Text = "Löschen";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // CbxGroup
            // 
            CbxGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxGroup.FormattingEnabled = true;
            CbxGroup.Location = new Point(86, 48);
            CbxGroup.Name = "CbxGroup";
            CbxGroup.Size = new Size(125, 23);
            CbxGroup.TabIndex = 5;
            CbxGroup.SelectedIndexChanged += CbxGroup_SelectedIndexChanged;
            // 
            // BtnAddGroup
            // 
            BtnAddGroup.Location = new Point(410, 48);
            BtnAddGroup.Name = "BtnAddGroup";
            BtnAddGroup.Size = new Size(89, 23);
            BtnAddGroup.TabIndex = 6;
            BtnAddGroup.Text = "Neue Gruppe";
            BtnAddGroup.UseVisualStyleBackColor = true;
            BtnAddGroup.Click += BtnAddGroup_Click;
            // 
            // BtnRenameGroup
            // 
            BtnRenameGroup.Location = new Point(217, 48);
            BtnRenameGroup.Name = "BtnRenameGroup";
            BtnRenameGroup.Size = new Size(89, 23);
            BtnRenameGroup.TabIndex = 7;
            BtnRenameGroup.Text = "Umbenennen";
            BtnRenameGroup.UseVisualStyleBackColor = true;
            BtnRenameGroup.Click += BtnRenameGroup_Click;
            // 
            // BtnDeleteGroup
            // 
            BtnDeleteGroup.Location = new Point(310, 48);
            BtnDeleteGroup.Name = "BtnDeleteGroup";
            BtnDeleteGroup.Size = new Size(94, 23);
            BtnDeleteGroup.TabIndex = 8;
            BtnDeleteGroup.Text = "Gruppe löschen";
            BtnDeleteGroup.UseVisualStyleBackColor = true;
            BtnDeleteGroup.Click += BtnDeleteGroup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 9;
            label1.Text = "Team:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 52);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 9;
            label2.Text = "Gruppe:";
            // 
            // FrmTeams
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 462);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnDeleteGroup);
            Controls.Add(BtnRenameGroup);
            Controls.Add(BtnAddGroup);
            Controls.Add(CbxGroup);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(BtnClose);
            Controls.Add(BtnNew);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "FrmTeams";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teams";
            Load += FrmTeams_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView LvwTeams;
        private ColumnHeader ChrId;
        private ColumnHeader ChrName;
        private Button BtnNew;
        private Button BtnClose;
        private Button BtnEdit;
        private Button BtnDelete;
        private ComboBox CbxGroup;
        private Button BtnAddGroup;
        private Button BtnRenameGroup;
        private Button BtnDeleteGroup;
        private Label label1;
        private Label label2;
    }
}
