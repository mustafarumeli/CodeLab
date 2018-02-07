using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeLab.Classes;
using CodeLab.Classes.Database;

namespace CodeLab.Forms.Auth
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        private void LblRegister_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.ShowDialog();
            if (MainForm.CurrentUser != null)
            {
                this.Close();
            }

        }

        private async void LoginButton_ClickAsync(object sender, EventArgs e)
        {
            var threader = new Threader(LoginButton,"Loggining in");
            threader.Run();

            if (await CheckLogin())
            {
                threader.Stop();
                Close();
            }
            threader.Stop();
            LoginButton.Text = "Login";
        }
        private async Task<bool> CheckLogin()
        {
            if (TbUserName.TextLength > 2 && MtbPassword.TextLength > 5)
            {
                var correctLogin = await new UserCrud().CheckAuthentication(TbUserName.Text, MtbPassword.Text);
                if (correctLogin != null)
                {
                    MainForm.CurrentUser = correctLogin;
                    if (CbRemember.Checked == true)
                    {
                        Properties.Settings.Default.RememberMe = true;
                        Properties.Settings.Default.UserId = correctLogin._id;
                        Properties.Settings.Default.Save();
                    }
                    return true;
                }
                MessageBox.Show("You have entered wrong credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Information you have entered is not long enough.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }
        private void TbUserName_Enter(object sender, EventArgs e)
        {
            TbUserName.Text = "";
            TbUserName.ForeColor = Color.Black;
            TbUserName.TextAlign = HorizontalAlignment.Left;
        }

        private void MtbPassword_Enter(object sender, EventArgs e)
        {
            MtbPassword.Text = "";
            MtbPassword.ForeColor = Color.Black;
            MtbPassword.PasswordChar = '*';
            MtbPassword.TextAlign = HorizontalAlignment.Left;
        }

        private void MtbPassword_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void LblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var frm = new ForgotPassword())
            {
                frm.ShowDialog();
            }
        }
    }
}
