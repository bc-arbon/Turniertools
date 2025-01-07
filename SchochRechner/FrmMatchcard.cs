using SchochRechner.ObjectModel;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;

namespace SchochRechner
{
    public partial class FrmMatchcard : Form
    {
        private Bitmap memoryImage;
        private PrintDocument pd;

        public FrmMatchcard()
        {
            this.InitializeComponent();
            this.ctlMatchcard1.Team1 = string.Empty;
            this.ctlMatchcard1.Team2 = string.Empty;
            this.ctlMatchcard1.Round = string.Empty;
            this.ctlMatchcard1.Court = string.Empty;
        }

        public FrmMatchcard(Draw draw, int round) : this(draw.Team1.Name, draw.Team2.Name, round, draw.Court)
        {
        }

        public FrmMatchcard(string team1, string team2, int round, int court) : this()
        {
            this.ctlMatchcard1.Team1 = team1;
            this.ctlMatchcard1.Team2 = team2;
            this.ctlMatchcard1.Court = court.ToString();
            this.ctlMatchcard1.Round = round.ToString();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            var size = new Size(this.ctlMatchcard1.ClientSize.Width, this.ctlMatchcard1.ClientSize.Height + 100);

            //var myGraphics = this.CreateGraphics();
            memoryImage = new Bitmap(size.Width, size.Height);
            var memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X + 20, this.Location.Y + 40, 0, 0, size);

            var preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();
        }

        private void FrmMatchcard_Load(object sender, EventArgs e)
        {
            this.pd = new PrintDocument();
            this.pd.DefaultPageSettings.Landscape = true;
            this.pd.PrintPage += this.Pd_PrintPage;
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.PageSettings.Landscape = true;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            e.Graphics.DrawImage(this.memoryImage, 100, 100);
        }
    }
}