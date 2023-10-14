namespace SchochRechner
{
    partial class FrmMatchcard
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
            button1 = new Button();
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(12, 576);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmMatchcard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 611);
            Controls.Add(button1);
            Controls.Add(ctlMatchcard1);
            Name = "FrmMatchcard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Matchblatt";
            Load += FrmMatchcard_Load;
            ResumeLayout(false);
        }

        #endregion

        private CtlMatchcard ctlMatchcard1;
        private Button button1;
    }
}