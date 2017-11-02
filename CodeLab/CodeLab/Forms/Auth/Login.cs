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
            checkLogin();
        }
        private async void checkLogin()
        {
            if (TbUserName.TextLength > 2 && MtbPassword.TextLength > 5)
            {
                var correctLogin = await new Classes.Database.UserCrud().CheckAuthentication(TbUserName.Text, MtbPassword.Text);
                if (correctLogin != null)
                {
                    MainForm.CurrentUser = correctLogin;
                    Close();
                }
                else
                {
                    MessageBox.Show("You have entered wrong credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Information you have entered is not long enough.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
