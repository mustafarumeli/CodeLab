using CodeLab.Classes.Database.Entities;
using MongoDB.Bson.IO;
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

namespace CodeLab.Forms
{
    public partial class UserAddCodeForm : MetroFramework.Forms.MetroForm
    {
        public UserAddCodeForm()
        {
            InitializeComponent();
        }

        public bool CheckValidations
        {
            get
            {
                if (_image != null && TxtCodeTitle.TextLength > 3 && RtxtCodes.TextLength > 10 && TxtCodeDescription.TextLength > 10 && TxtCodeTags.TextLength > 2 && ClbLanguages.SelectedItems.Count > 0)
                {
                    return true;
                }
                return false;
            }
        }
        byte[] _image;
        private async void CbtnSend_ClickAsync(object sender, EventArgs e)
        {
      
            if (CheckValidations == true && MainForm.CurrentUser != null)
            {
                var cPiece = new CodePiece
                {
                    Code = RtxtCodes.Text,
                    Contributer = MainForm.CurrentUser._id,
                    Date = DateTime.Now,
                    Description = TxtCodeDescription.Text,
                    Language = ClbLanguages.SelectedItem.ToString(),
                    Scores = new Classes.Rate(85, 65, 100, 69),
                    Tags = TxtCodeTags.Text.Split(','),
                    Title = TxtCodeTitle.Text,
                    Picture = _image
                };
                await new Classes.Database.CodePieceCrud().Insert(cPiece);
                MessageBox.Show("OK OK");
            }
            else
            {
                MessageBox.Show("Please enter all fields properly");
            }
        }

        private void BtnPicture_Click(object sender, EventArgs e)
        {
          
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Jpeg files (*.jpg)|*.jpg|Png files (*.png)|*.png";
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                    _image = new byte[16777216];
                    var file = File.Open(openFileDialog.FileName, FileMode.Open);

                    var size = new FileInfo(openFileDialog.FileName).Length;

                    if (size < 16777216)
                    {
                        using (var theReader = new BinaryReader(file))
                        {
                            _image = theReader.ReadBytes((int)file.Length);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Your File is too big");
                    }
            }
        }
    }
}
