using CodeLab.Classes.Database;
using CodeLab.Classes.Database.Entities;
using System;
using System.IO;
using System.Windows.Forms;

namespace CodeLab.Forms
{
    public partial class InsertCode : MetroFramework.Forms.MetroForm
    {
        private CodePiece _current;
        public InsertCode(CodePiece current)
        {
            InitializeComponent();
            _current = current;
            SetPreCode();
        }

        void SetPreCode()
        {
            string currentLanguage = _current.Language.ToLower();
            string filePath = "../../Resources/LanguagePre/" + currentLanguage + ".txt";
            if (File.Exists(filePath)) 
                TbCode.Text = File.ReadAllText(filePath);
        }
        public async void BtnComplete_Click(object sender, EventArgs e)
        {
            if (TbCode.TextLength > 3)
            {
                _current.Code = TbCode.Text;
              

                await DbFactory.CodePieceCrud.Insert(_current);
                MessageBox.Show("Your Code Has Been Added " + Environment.NewLine + "Thank you");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Code IsNot Long Enough");
            }

        }
    }
}
