using SchochRechner.ObjectModel;
using System.Drawing.Printing;
using System.Drawing.Text;

namespace SchochRechner
{
    public partial class FrmMatchcard : Form
    {
        private PrintDocument? pd;

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
            var printDocument = this.pd ?? throw new InvalidOperationException("Das Druckdokument wurde noch nicht initialisiert.");
            using var preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.ShowDialog();
        }

        private static void DrawLabels(Graphics graphics, Control parent, float parentX, float parentY, float scale)
        {
            foreach (Control child in parent.Controls)
            {
                var x = parentX + child.Left * scale;
                var y = parentY + child.Top * scale;
                if (child is Label label)
                {
                    var bounds = new RectangleF(x, y, label.Width * scale, label.Height * scale);
                    if (label.BorderStyle == BorderStyle.FixedSingle)
                    {
                        using var pen = new Pen(label.ForeColor, 0.75f);
                        graphics.DrawRectangle(pen, bounds.X + 0.375f, bounds.Y + 0.375f, bounds.Width - 0.75f, bounds.Height - 0.75f);
                    }

                    using var brush = new SolidBrush(label.ForeColor);
                    using var format = new StringFormat
                    {
                        Alignment = label.TextAlign is ContentAlignment.TopCenter or ContentAlignment.MiddleCenter or ContentAlignment.BottomCenter
                            ? StringAlignment.Center
                            : label.TextAlign is ContentAlignment.TopRight or ContentAlignment.MiddleRight or ContentAlignment.BottomRight
                                ? StringAlignment.Far
                                : StringAlignment.Near,
                        LineAlignment = label.TextAlign is ContentAlignment.MiddleLeft or ContentAlignment.MiddleCenter or ContentAlignment.MiddleRight
                            ? StringAlignment.Center
                            : label.TextAlign is ContentAlignment.BottomLeft or ContentAlignment.BottomCenter or ContentAlignment.BottomRight
                                ? StringAlignment.Far
                                : StringAlignment.Near,
                        Trimming = StringTrimming.EllipsisCharacter,
                    };
                    graphics.DrawString(label.Text, label.Font, brush, bounds, format);
                }
                else
                {
                    DrawLabels(graphics, child, x, y, scale);
                }
            }
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
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            var source = this.ctlMatchcard1;
            DrawLabels(e.Graphics, source, 100, 100, 100f / source.DeviceDpi);
        }
    }
}