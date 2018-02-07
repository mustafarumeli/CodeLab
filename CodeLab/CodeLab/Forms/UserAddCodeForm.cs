using CodeLab.Classes.Database.Entities;
using System;
using System.IO;
using System.Windows.Forms;
using CodeLab.Classes.Database;

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
                if (_image != null && TxtCodeTitle.TextLength > 3 && TxtCodeDescription.TextLength > 10 && TxtCodeTags.TextLength > 2 && ClbLanguages.SelectedItems.Count > 0)
                {
                    return true;
                }
                return false;
            }
        }

        private byte[] _image;
        private async void CbtnSend_ClickAsync(object sender, EventArgs e)
        {
      
            if (CheckValidations == true && MainForm.CurrentUser != null)
            {
                {
                }
               
                Random rnd = new Random();
                var cPiece = new CodePiece
                {
                    
                    Contributer = MainForm.CurrentUser._id,
                    Date = DateTime.Now,
                    Description = TxtCodeDescription.Text,
                    Language =  ClbLanguages.SelectedItem.ToString(),
                    Scores = new Classes.Rate(rnd.Next(0,100), rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100)),
                    Tags = TxtCodeTags.Text.Split(','),
                    Title = TxtCodeTitle.Text,
                    Picture = _image
                };
                using (InsertCode ic = new InsertCode(cPiece))
                {
                    ic.ShowDialog();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter all fields properly");
            }
        }

        private void BtnPicture_Click(object sender, EventArgs e)
        {
          
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files |*.jpg;*.png;*.gif;*.bmp";
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

        private void UserAddCodeForm_Load(object sender, EventArgs e)
        {
            ClbLanguages.Items.AddRange(DbFactory.CodePieceCrud.GetDistinctLanguages());
        }
    }
}
