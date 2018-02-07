using CodeLab.Classes.Database.Entities;
using CodeLab.Forms.Auth;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CodeLab.Forms
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public static User CurrentUser;
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var selectedLanguages= new string[clbLanguages.CheckedItems.Count];
            for (var i = 0; i < selectedLanguages.Length; i++)
            {
                selectedLanguages[i] = clbLanguages.CheckedItems[i].ToString();
            }
            var lr = new ListResults(TbSearch.Text,selectedLanguages);
            lr.Show();
            MainForm_Load(null, null);
        }

        private void LblAuth_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.ShowDialog();
            if (CurrentUser == null) return;
            LoggedIn("Welcome");
        }

        private void LoggedIn(string message)
        {
            LblContribute.Visible = true;
            LblAuth.Text = message + " " + CurrentUser.Name.Substring(0, 4)+"..";
            LblAuth.Click -= LblAuth_Click;
            LblAuth.Click += LblAuth_LogOut;
        }
        private void LblAuth_LogOut(object sender, EventArgs e)
        {
        
            if (MessageBox.Show("Are you sure you want to log out? ","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                CurrentUser = null;
                LblContribute.Visible = false;
                LblAuth.Text = "SignUp/Register";
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.UserId = "";
                Properties.Settings.Default.Save();
                LblAuth.Click -= LblAuth_LogOut;
                LblAuth.Click += LblAuth_Click;
            }
        }
        private void LblContribute_Click(object sender, EventArgs e)
        {
            using (var frm = new UserAddCodeForm())
            {
                frm.ShowDialog();
            }
            MainForm_Load(null, null);
        }
        /// <summary>
        /// Placeholder
        /// </summary>
        private void TbSearch_Enter(object sender, EventArgs e)
        {
            TbSearch.Text="";
            TbSearch.ForeColor = Color.Black;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            clbLanguages.Items.Clear();
            clbLanguages.Items.AddRange(Classes.Database.DbFactory.CodePieceCrud.GetDistinctLanguages());
            if(Properties.Settings.Default.RememberMe == true)
            {
                CurrentUser = await Classes.Database.DbFactory.UserCrud.GetOne(Properties.Settings.Default.UserId);
                LoggedIn("Welcome Back");
            }
        }

        
    }
}
