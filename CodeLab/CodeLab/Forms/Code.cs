using CodeLab.Classes;
using CodeLab.Classes.Database;
using CodeLab.Classes.Database.Entities;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
                PbRun.Visible = true;
            }
            //codePiece = await _codePieceCrud.GetOne(_id);
            
            TbCode.Text = CurrentCodePiece.Code;
         /*   using (var ms = new MemoryStream(CurrentCodePiece.Picture))
            {
                PBpicture.Image = Image.FromStream(ms);
            }*/
            this.Text = CurrentCodePiece.Title;
            MainForm.CurrentUser.AddOrUpdateSearchHistory(CurrentCodePiece._id, 10);
        }

      

        private void BtnOriginal_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnSeeComments_Click(object sender, EventArgs e)
        {
            using (var sc = new SeeComments())
            {
                sc.ShowDialog();
            }
        }

        private void BtnMakeComment_Click(object sender, EventArgs e)
        {
            using (var sc = new SeeComments())
            {
                sc.PrepareForm();
                sc.ShowDialog();
            }
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            TbStatus.AppendText("Build Started.", Color.Black);
            CodeRunner cr = new CodeRunner(TbCode.Text);
            (object result, bool success) = cr.Result;
            Color color = Color.Red;
            string text = result.ToString();
            if (success)
            {
                color = Color.Green;
            }
            TbStatus.AppendText(text, color);

        }

        private void BtnOrginal_Click(object sender, EventArgs e)
        {
            TbCode.Text = CurrentCodePiece.Code;
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TbCode.Text);
        }

        private void BtnRun_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(sender as Control, "Execute");
        }

        private void BtnCopy_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(sender as Control, "Copy To Clipboard");
        }

        private void BtnOrginal_MouseLeave(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(sender as Control, "Return the original version");
        }

        private void BtnSeeComments_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(sender as Control, "See Comments");
        }

        private void BtnMakeComment_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(sender as Control, "Make Comment");
        }
    }
}
