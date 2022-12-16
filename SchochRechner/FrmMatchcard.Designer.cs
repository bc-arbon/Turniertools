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
            this.ctlMatchcard1 = new SchochRechner.CtlMatchcard();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctlMatchcard1
            // 
            this.ctlMatchcard1.Location = new System.Drawing.Point(12, 59);
            this.ctlMatchcard1.Name = "ctlMatchcard1";
            this.ctlMatchcard1.Size = new System.Drawing.Size(949, 418);
            this.ctlMatchcard1.TabIndex = 0;
            this.ctlMatchcard1.Team1 = "Team 1";
            this.ctlMatchcard1.Team2 = "Team 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMatchcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctlMatchcard1);
            this.Name = "FrmMatchcard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matchblatt";
            this.ResumeLayout(false);

        }

        #endregion

        private CtlMatchcard ctlMatchcard1;
        private Button button1;
    }
}