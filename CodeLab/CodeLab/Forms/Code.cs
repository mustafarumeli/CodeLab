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


        private  void Code_LoadAsync(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Hide();
            using (Waiting wating = new Waiting(_id))
            {
                wating.ShowDialog();
                CurrentCodePiece = wating.CodePiece;
            }
       
            TbCode.Text = CurrentCodePiece.Code;
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

        private async void BtnRun_ClickAsync(object sender, EventArgs e)
        {
            var debug = new CodeLab.Classes.Database.Entities.Debug();
            debug.Code = TbCode.Text;
            debug.Language = CurrentCodePiece.Language;
            if (await DbFactory.DebugCrud.Insert(debug))
            {
                CodeRunner cr = new CodeRunner();
                cr.ConnectionStatus += Cr_ConnectionStatus;
                cr.OnReceived += Cr_OnReceived;
                await cr.SendCode(debug._id);
            }
         
        }
        private async void Cr_OnReceived(string _id)
        {
            var debug = await DbFactory.DebugCrud.GetOne(_id);
            Invoke(new Action(() =>
            {
                TbStatus.AppendText(debug.SuccessResult, Color.Green);
                TbStatus.AppendText(debug.ErrorResult, Color.Red);
            }));
            await DbFactory.DebugCrud.Delete(_id);
        }

        private void Cr_ConnectionStatus(string obj)
        {
            TbStatus.AppendText(obj, Color.Black);

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
