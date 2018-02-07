using CodeLab.Classes;
using CodeLab.Classes.Database;
using CodeLab.Classes.Database.Entities;
using System;
using System.Drawing;
using System.IO;

namespace CodeLab.Forms
{
    public partial class Code : MetroFramework.Forms.MetroForm
    {
        private readonly string _id;
        public static  CodePiece CurrentCodePiece;
       
        public Code(string id)
        {
            InitializeComponent();
            _id = id;
            
        }


        private async void Code_LoadAsync(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Hide();
            using (Waiting wating = new Waiting(_id))
            {

                wating.ShowDialog();
                CurrentCodePiece = wating.CodePiece;
            }
            if(CurrentCodePiece.Language.ToLower() == "c#")
            {
                BtnRun.Visible = true;
            }
            //codePiece = await _codePieceCrud.GetOne(_id);
            
            LblDesc.Text = CurrentCodePiece.Description;
            TbCode.Text = CurrentCodePiece.Code;
            using (var ms = new MemoryStream(CurrentCodePiece.Picture))
            {
                PBpicture.Image = Image.FromStream(ms);
            }
            this.Text = CurrentCodePiece.Title;
          
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            TbStatus.AppendText("Build Started.",Color.Black);
          CodeRunner cr = new CodeRunner(TbCode.Text);
            (object result,bool success) = cr.Result;
            Color color = Color.Red;
            string text = result.ToString();
            if (success)
            {
                color = Color.Green;
            }
            TbStatus.AppendText(text,color);

        }

        private void BtnOriginal_Click(object sender, EventArgs e)
        {
            TbCode.Text = CurrentCodePiece.Code;
        }

        private void BtnSeeComments_Click(object sender, EventArgs e)
        {
            using (var sc = new SeeComments())
            {
                sc.ShowDialog();
            }
        }
    }
}
