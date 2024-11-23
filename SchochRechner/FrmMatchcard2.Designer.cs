namespace SchochRechner
{
    partial class FrmMatchcard2
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
            ctlMatchcard1 = new CtlMatchcard();
            BtnPrint = new Button();
            SuspendLayout();
            // 
            // ctlMatchcard1
            // 
            ctlMatchcard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ctlMatchcard1.Location = new Point(12, 59);
            ctlMatchcard1.Name = "ctlMatchcard1";
            ctlMatchcard1.Size = new Size(960, 461);
            ctlMatchcard1.TabIndex = 0;
            ctlMatchcard1.Team1 = "Team 1";
            ctlMatchcard1.Team2 = "Team 2";
            // 
            // BtnPrint
            // 
            BtnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnPrint.Location = new Point(12, 576);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Size = new Size(75, 23);
            BtnPrint.TabIndex = 1;
            BtnPrint.Text = "Drucken...";
            BtnPrint.UseVisualStyleBackColor = true;
            BtnPrint.Click += BtnPrint_Click;
            // 
            // FrmMatchcard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 611);
            Controls.Add(BtnPrint);
            Controls.Add(ctlMatchcard1);
            Name = "FrmMatchcard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Matchblatt";
            Load += FrmMatchcard_Load;
            ResumeLayout(false);
        }

        #endregion

        private CtlMatchcard ctlMatchcard1;
        private Button BtnPrint;
    }
}