using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeLab.Classes;

namespace CodeLab.Custom_Controls
{
    public partial class ResultPreviewPanel : UserControl
    {
        public ResultPreviewPanel(string header, string date, Rate rating, string language, string author)
        {
            InitializeComponent();
            Setup(header, date, rating, language, author);

        }
        const int MAX_STAR_COUNT = 4;

        void Setup(string header, string date, Rate rating, string language, string author)
        {
            LblHeader.Text = header;
            LblDate.Text = date;
            LblLang.Text = language;
            LblAuthor.Text = author;
            var starCount = rating.StarCount;
            bool hasHalf = false;
            if (starCount < 0)
            {
                starCount = starCount * -1;
                hasHalf = true;
            }
            Bitmap b = new Bitmap(128, 32);
            Graphics g = Graphics.FromImage(b);

            int i;
            for (i = 0; i < starCount; i++)
            {
                g.DrawImage(IlStartImages.Images[0], i * 32, 0, 32, 32);

            }
            if (hasHalf)
            {
                g.DrawImage(IlStartImages.Images[1], i * 32, 0, 32, 32);
            }
            int emptyStarCount = MAX_STAR_COUNT - starCount;
            for (int j = 0; j < emptyStarCount; j++)
            {
                g.DrawImage(IlStartImages.Images[2], (i + j) * 32, 0, 32, 32);
            }

            PbStars.Image = b;
        }
        private void ResultPreviewPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
