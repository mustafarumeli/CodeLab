using CodeLab.Classes.Database.Entities;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CodeLab.Classes.Database;
using CodeLab.Classes;

namespace CodeLab.Forms
{
    public partial class UserEditCodeForm : MetroFramework.Forms.MetroForm
    {
        private readonly string _codeId;
        CodePiece _codePiece;


        public UserEditCodeForm(string codeId)
        {
            _codeId = codeId;
            InitializeComponent();
            LoadObject(codeId);
        }

        private async void LoadObject(string codeId)
        {
            _codePiece = await DbFactory.CodePieceCrud.GetOne(codeId);


            TxtCodeTitle.Text = _codePiece.Title;
            TxtCodeDescription.Text = _codePiece.Description;
            StringBuilder tags = new StringBuilder();
            foreach (var tag in _codePiece.Tags)
            {
                tags.Append(tag);
            }
            TxtCodeTags.Text = tags.ToString();
            ClbLanguages.SetItemChecked((int)_codePiece.Language,true);
            _image = _codePiece.Picture;
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
                var cPiece = new CodePiece
                {
                    _id = _codeId,
                    Contributer = MainForm.CurrentUser._id,
                    Date = DateTime.Now,
                    Description = TxtCodeDescription.Text,
                    Language = EnumHelper<Languages>.GetValueFromAttribute(ClbLanguages.SelectedItem.ToString()),
                    Scores = _codePiece.Scores,
                    Tags = TxtCodeTags.Text.Split(','),
                    Title = TxtCodeTitle.Text,
                    Picture = _image,
                    Code = _codePiece.Code,
                    Comments = _codePiece.Comments,
                    CreationDate = _codePiece.CreationDate,
                    Votes = _codePiece.Votes
                };
                using (EditCode ic = new EditCode(cPiece))
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
            //ClbLanguages.Items.AddRange(DbFactory.CodePieceCrud.GetDistinctLanguages());
               
            ClbLanguages.DataSource = (EnumHelper<Languages>.GetDisplayValues(new Languages()));
        }
    }
}

