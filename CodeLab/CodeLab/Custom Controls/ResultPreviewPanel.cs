﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeLab.Classes;
using CodeLab.Forms;

namespace CodeLab.Custom_Controls
{
    public partial class ResultPreviewPanel : UserControl
    {
        public ResultPreviewPanel(string _id,string header, string date, Rate rating, string language, string author)
        {
            InitializeComponent();
            this._header = header;
            Setup(_id,header, date, rating, language, author);

        }
        const int MAX_STAR_COUNT = 4;
        private string _header = "";
        private string _id = ""; // ID eklenecek tabii
        void Setup(string _id , string header, string date, Rate rating, string language, string author)
        {
            LblHeader.Text = header;
            LblDate.Text = date;
            LblLang.Text = language;
            LblAuthor.Text = author;
            this._id = _id;
            var starCount = rating.StarCount;
            var hasHalf = false;
            if (starCount < 0)
            {
                starCount = starCount * -1;
                hasHalf = true;
            }
            var b = new Bitmap(128, 32);
            var g = Graphics.FromImage(b);

            int i;
            for (i = 0; i < starCount; i++)
            {
                g.DrawImage(IlStartImages.Images[0], i * 32, 0, 32, 32);

            }
            if (hasHalf)
            {
                g.DrawImage(IlStartImages.Images[1], i * 32, 0, 32, 32);
            }
            var emptyStarCount = MAX_STAR_COUNT - starCount;
            for (var j = 0; j < emptyStarCount; j++)
            {
                g.DrawImage(IlStartImages.Images[2], (i + j) * 32, 0, 32, 32);
            }

            PbStars.Image = b;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            var code = new Code(_id);
            code.ShowDialog();
        }
    }
}
