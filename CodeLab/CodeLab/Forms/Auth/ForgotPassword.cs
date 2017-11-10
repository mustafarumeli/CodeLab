using CodeLab.Classes.Database;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLab.Forms.Auth
{
    public partial class ForgotPassword : MetroFramework.Forms.MetroForm
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private async Task<(string sequrityQuestion, string answer,string password)> CheckIfUserExistsAsync(string userNameOrEmail)
        {
            Classes.Database.Entities.User user = await new UserCrud().FindUser(userNameOrEmail);
            if (user != null) return (user.SecurityQuestion, user.SecurityAnswer, user.Password);
            if (MessageBox.Show("Username or Email is seem to wrong tome my dear user", "Error",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) != DialogResult.Cancel) return ("", "", "");
            Close();
            return ("","","");
        }

        private string _answer;
        private string _password;
        private async void BtnAccept_ClickAsync(object sender, EventArgs e)
        {
            if(_password != "" && _answer!="" && !string.IsNullOrEmpty(TBQuestion.Text))
            {
                if (TBAnswer.TextLength > 3)
                {
                    if (_answer == TBAnswer.Text)
                    {
                        MessageBox.Show("Your Password is : "+_password); // Todo : Email Send
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Answer");
                    }
                }
                else
                {
                    MessageBox.Show("Answer is too short");
                }
            }
            else if (TBUser.TextLength>2)
            {
                string question;
                (question, _answer,_password) = await CheckIfUserExistsAsync(TBUser.Text);
                if (question == "" && _answer == "" && _password == "") return;
                TBQuestion.Text = question;
                GBAuthentication.Visible = true;
                TBUser.Enabled = false;
                BtnAccept.Text = "Confirm";
            }
            else
            {
                MessageBox.Show("Username or Email is too short");
            }
        }
    }
}
