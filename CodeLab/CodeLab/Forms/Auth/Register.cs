using CodeLab.Classes.Database;
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

namespace CodeLab.Forms.Auth
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        private bool _isViable = false;
        public Register()
        {
            InitializeComponent();
            CbSecurityQuestion.SelectedIndex = 0;
        }

        private void TbName_Leave(object sender, EventArgs e)
        {
            if (TbName.TextLength < 4)
            {
                LName.Text = "Name should be at least 4 characters";
                _isViable = false;
            }
            else
            {
                LName.Text = "";
                _isViable = true;
            }
        }



        private async void TbEmail_Leave(object sender, EventArgs e)
        {
            if (!IsValid(TbEmail.Text))
            {
                LEmail.Text = "E-Mail is not valid";
                _isViable = false;
            }
            else
            {
                if (await new UserCrud().EMailValidation(TbEmail.Text) == true)
                {
                    LEmail.Text = "This E-Mail is already registered";
                    _isViable = false;
                }
                else
                {
                    LEmail.Text = "";
                    _isViable = true;
                }
            }
            bool IsValid(string emailaddress)
            {
                try
                {
                    if (string.IsNullOrEmpty(emailaddress))
                    {
                        return false;
                    }
                    var m = new System.Net.Mail.MailAddress(emailaddress);

                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
        }

        private void TbSecurityAnswer_Leave(object sender, EventArgs e)
        {
            if (TbSecurityAnswer.TextLength > 0)
            {
                LSecurityAnswer.Text = "";
                _isViable = false;
            }
            else
            {
                LSecurityAnswer.Text = "Field can not be empty";
                _isViable = true;
            }
        }

        private async void TbUserName_Leave(object sender, EventArgs e)
        {
            if (TbUserName.TextLength < 3)
            {
                LUsername.Text = "User Name cannot be shorter than 3 characters";
                _isViable = false;
            }
            else
            {
                if (await new UserCrud().UserNameValidation(TbUserName.Text) == true)
                {
                    LUsername.Text = "This User Name is already taken";
                    _isViable = false;
                }
                else
                {
                    LUsername.Text = "";
                    _isViable = true;
                }
            }
          

        }

        private void TbPassword_Leave(object sender, EventArgs e)
        {

            if (TbRePassword.Text != TbPassword.Text)
            {
                LRePassword.Text = "Passwords don't match";
                _isViable = false;
            }
            else
            {
                LRePassword.Text = "";
                _isViable = true;
            }
            if (TbPassword.TextLength < 6)
            {
                LPassword.Text = "Password cannot be shorter than 6 characters";
                _isViable = false;
            }
            else
            {
                LPassword.Text = "";
                _isViable = true;
            }
        }

        private void TbRePassword_Leave(object sender, EventArgs e)
        {
            if (TbRePassword.Text != TbPassword.Text)
            {
                LRePassword.Text = "Passwords don't match";
                _isViable = false;
            }
            else
            {
                LRePassword.Text = "";
                _isViable = true;
            }
            if (TbPassword.TextLength < 6)
            {
                LPassword.Text = "Password cannot be shorter than 6 characters";
                _isViable = false;
            }
        }

        private async void BtnApply_Click(object sender, EventArgs e)
        {
            if (_isViable == true)
            {
                var user = new User {
                    Name = TbName.Text,
                    Email = TbEmail.Text,
                    Password = TbPassword.Text,
                    SecurityQuestion = CbSecurityQuestion.SelectedItem.ToString(),
                    SecurityAnswer = TbSecurityAnswer.Text,
                    UserName = TbUserName.Text
                };
                if (await new UserCrud().Insert(user) == true)
                {
                    MessageBox.Show("Welcome To the Jungle");
                    MainForm.CurrentUser = user;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fix all errors to continue","Error",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            } 
        }
    }
}
