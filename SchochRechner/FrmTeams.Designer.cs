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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(LvwTeams);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 380);
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
            LvwTeams.Size = new Size(353, 358);
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
            BtnNew.Location = new Point(15, 12);
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
            BtnClose.Location = new Point(293, 427);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(75, 23);
            BtnClose.TabIndex = 2;
            BtnClose.Text = "OK";
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(96, 12);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 23);
            BtnEdit.TabIndex = 3;
            BtnEdit.Text = "Bearbeiten";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(177, 12);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 4;
            BtnDelete.Text = "Löschen";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // FrmTeams
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 462);
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
    }
}