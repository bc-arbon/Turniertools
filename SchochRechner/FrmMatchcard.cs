using SchochRechner.ObjectModel;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;

namespace SchochRechner
{
    public partial class FrmMatchcard : Form
    {
        public FrmMatchcard()
        {
            this.InitializeComponent();
        }

        public FrmMatchcard(Draw draw) : this()
        {
            this.ctlMatchcard1.Team1 = draw.Team1.Name;
            this.ctlMatchcard1.Team2 = draw.Team2.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true;
            
            pd.PrintPage += (s, e) =>
            {
                var bitmap = new Bitmap(this.ctlMatchcard1.ClientSize.Width, this.ctlMatchcard1.ClientSize.Height);
                this.ctlMatchcard1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.ctlMatchcard1.Width, this.ctlMatchcard1.Height));
                e.PageSettings.Landscape = true;
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                e.Graphics.DrawImage(bitmap, 100, 100);
                bitmap.Dispose();
            };

            var preview = new PrintPreviewDialog();
            preview.Document = pd;            
            preview.ShowDialog();
        }
    }
}
