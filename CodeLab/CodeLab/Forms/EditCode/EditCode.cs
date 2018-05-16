using CodeLab.Classes.Database;
using CodeLab.Classes.Database.Entities;
using System;
using System.IO;
using System.Windows.Forms;

namespace CodeLab.Forms
{
    public partial class EditCode : MetroFramework.Forms.MetroForm
    {
        private CodePiece _current;
        public EditCode(CodePiece current)
        {
            InitializeComponent();
            _current = current;
            SetPreCode();
        }

        void SetPreCode()
        {

            TbCode.Text = _current.Code;
        }
        public async void BtnComplete_Click(object sender, EventArgs e)
        {
            if (TbCode.TextLength > 3)
            {
                _current.Code = TbCode.Text;
              

                await DbFactory.CodePieceCrud.Update(_current._id,_current);
                MessageBox.Show("Your Code Has Been Edited " + Environment.NewLine + "Thank you");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Code Is Not Long Enough");
            }

        }
    }
}
