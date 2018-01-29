using CodeLab.Classes.Database;
using CodeLab.Classes.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeLab.Properties;

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
            string currentLanguage = _current.Languages[0];
            if (currentLanguage != "c#")
            {
                using (StreamReader stream = new StreamReader(Application.StartupPath + "\\LanguagePre\\" + currentLanguage + ".mhsn"))
                {
                    TbCode.Text = stream.ReadToEnd();
                }
            }
          
        }
        private async void BtnComplete_Click(object sender, EventArgs e)
        {
            if (TbCode.TextLength > 3)
            {
                _current.Code = TbCode.Text;

                await DbFactory.CodePieceCrud.Insert(_current);
                MessageBox.Show("Your Code Has Been Added " + Environment.NewLine + "Thank you");
            }
            else
            {
                MessageBox.Show("Code IsNot Long Enough");
            }

        }
    }
}
