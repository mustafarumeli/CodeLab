using CodeLab.Classes.Database;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLab.Forms.Auth
{
    public partial class ForgotPassword : MetroFramework.Forms.MetroForm
    {
        private Classes.Database.Entities.User user=null;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private async Task<(string sequrityQuestion, string answer,string password)> CheckIfUserExistsAsync(string userNameOrEmail)
        {
            user = await new UserCrud().FindUser(userNameOrEmail);
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
                        SmtpClient client = new SmtpClient("smtpout.secureserver.net",465);
                        client.UseDefaultCredentials = false;
                        client.EnableSsl = true;
                        client.Credentials = new NetworkCredential("info@ohmsoftware.org","741895623ohm");
                        
                        MailMessage mm = new MailMessage("info@ohmsoftware.org",user.Email);
                        mm.Subject = "Your Password Recovery Code";
                        var replace = System.IO.Path.GetRandomFileName().Replace(".","");
                        mm.Body = "Your code is below. Enter the code before the time runs out. <br/><h3>"+replace+ "</h3>";
                        client.Send(mm);
                        using (PasswordRecovery pR = new PasswordRecovery(replace))
                        {
                            if (pR.ShowDialog()==DialogResult.OK)
                            {
                                user.Password = pR.Encrypt;
                                await DbFactory.UserCrud.Update(user._id, user);
                                Close();
                            }
                        }
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
