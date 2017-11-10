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
        private readonly CRUD<CodePiece> _codePieceCrud;
        private CodePiece _codePiece;
       
        public Code(string id)
        {
            InitializeComponent();
            _id = id;
            _codePieceCrud = new CRUD<CodePiece>(DbFactory.CodePieces);
        }


        private async void Code_LoadAsync(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Hide();
            using (Waiting wating = new Waiting(_id))
            {

                wating.ShowDialog();
                _codePiece = wating.CodePiece;
            }
            if (_codePiece.Languages.Length == 1 && _codePiece.Languages[0] == "C#")
            {
                BtnRun.Visible = true;
            }
            //codePiece = await _codePieceCrud.GetOne(_id);
            
            LblDesc.Text = _codePiece.Description;
            TbCode.Text = _codePiece.Code;
            using (var ms = new MemoryStream(_codePiece.Picture))
            {
                PBpicture.Image = Image.FromStream(ms);
            }
            this.Text = _codePiece.Title;
          
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
            TbCode.Text = _codePiece.Code;
        }
    }
}
