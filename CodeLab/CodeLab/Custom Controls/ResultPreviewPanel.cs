using System;
using System.Drawing;
using System.Windows.Forms;
using CodeLab.Classes;
using CodeLab.Forms;
using System.Linq;
using CodeLab.Classes.Database.Entities;

namespace CodeLab.Custom_Controls
{
    public partial class ResultPreviewPanel : UserControl
    {
        public ResultPreviewPanel(string _id,string header, string date, Rate rating, Languages language, string author,int totalVoteCount)
        {
            InitializeComponent();
            this._header = header;
            Setup(_id,header, date, rating, language, author,totalVoteCount);

        }

        private string _header = "";
        private string _id = ""; // ID eklenecek tabii

        private void Setup(string _id , string header, string date, Rate rating, Languages language, string author,int totalVoteCount)
        {
            if (MainForm.CurrentUser?.SearchHistories.FirstOrDefault(x => x.CodePieceId == _id) != null)
            {
                this.BackColor = Color.SeaGreen;
            }
            LblHeader.Text = header;
            LblDate.Text = "Added on: " + date;
            LblLang.Text = language.ToString();
            LblAuthor.Text +=": "+ author;
            LblVote.Text = totalVoteCount.ToString();
            this._id = _id;
         
        }

        private void BtnGotoCode_Click(object sender, EventArgs e)
        {
            var code = new Code(_id);
            this.BackColor = Color.SeaGreen;
            code.ShowDialog();
        }
    }
}
