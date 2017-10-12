using CodeLab.Classes.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLab.Forms
{
    public partial class UserAddCodeForm : MetroFramework.Forms.MetroForm
    {
        public UserAddCodeForm()
        {
            InitializeComponent();
        }

        public bool CheckValidations {
            get {
                if (TxtCodeTitle.TextLength > 3 && RtxtCodes.TextLength > 10 && TxtCodeDescription.TextLength>10 && TxtCodeTags.TextLength>2 && ClbLanguages.SelectedItems.Count>0)
                {
                    return true;
                }
                return false;
            }
        }

        private async void CbtnSend_ClickAsync(object sender, EventArgs e)
        {
            if (CheckValidations)
            {
                var cPiece = new CodePiece {
                    Code = RtxtCodes.Text,
                    Contributer = Guid.NewGuid().ToString(),
                    Date = DateTime.Now,
                    Description = TxtCodeDescription.Text,
                    Language = ClbLanguages.SelectedItem.ToString(),
                    Scores = new Classes.Rate(85, 65, 100, 69),
                    Tags = TxtCodeTags.Text.Split(','),
                    Title=TxtCodeTitle.Text
                };
                await new Classes.Database.CodePieceCRUD().Insert(cPiece);
                MessageBox.Show("OK OK");
            }
            else
            {
                MessageBox.Show("Please enter all fields properly");
            }
        }
    }
}
