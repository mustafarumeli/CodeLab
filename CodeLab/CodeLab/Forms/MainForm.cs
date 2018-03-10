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
            MongoDB.Bson.BsonDocument filter = new MongoDB.Bson.BsonDocument();
            if (clbLanguages.CheckedItems.Count > 0 )
            {
                filter = new MongoDB.Bson.BsonDocument("Language",clbLanguages.CheckedItems[0]?.ToString()); 
            }
            string searchText = TbSearch.Text;
            if (TbSearch.ForeColor==Color.Silver)
            {
                searchText = "";
            }
            var lr = new ListResults(searchText, filter);
            lr.Show();
            MainForm_Load(null, null);
        }

        private void LoggedIn(string message)
        {
            PbContribute.Visible = true;
            //LblAuth.Text = message + " " + CurrentUser.Name.Substring(0, 4)+"..";
            //LblAuth.Click -= LblAuth_Click;
            //LblAuth.Click += LblAuth_LogOut;
            PbLoginRegister.Image = Properties.Resources.lgout64;
            PbLoginRegister.Click -= PbLoginRegister_Click;
            PbLoginRegister.Click += PbLoginRegister_Logout;

        }
        private void PbLoginRegister_Logout(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out? ", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CurrentUser = null;
                PbContribute.Visible = false;
                PbLoginRegister.Image = Properties.Resources.lgn64;
                //LblAuth.Text = "SignUp/Register";
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.UserId = "";
                Properties.Settings.Default.Save();
                //LblAuth.Click -= LblAuth_LogOut;
                //LblAuth.Click += LblAuth_Click;
                PbLoginRegister.Click -= PbLoginRegister_Logout;
                PbLoginRegister.Click += PbLoginRegister_Click ;
            }
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
            var items = Classes.Database.DbFactory.CodePieceCrud.GetDistinctLanguages();
            if (items.Length > 0)
            {
                clbLanguages.Visible = true;
                clbLanguages.Items.AddRange(items);
            }
            if (Properties.Settings.Default.RememberMe == true)
            {
                CurrentUser = await Classes.Database.DbFactory.UserCrud.GetOne(Properties.Settings.Default.UserId);
                LoggedIn("Welcome Back");
            }
        }

        private void PbLoginRegister_Click(object sender, EventArgs e)
        {
            using (var login = new Login())
            {
                login.ShowDialog();
            }
            if (CurrentUser == null) return;
            LoggedIn("Welcome");
        }

        private void PbContribute_Click(object sender, EventArgs e)
        {
            using (var frm = new UserAddCodeForm())
            {
                frm.ShowDialog();
            }
            MainForm_Load(null, null);
        }

        private void PbContribute_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(sender as Control, "Contribute");
        }

        private void PbLoginRegister_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            if (CurrentUser == null)
            {
                tt.SetToolTip(sender as Control, "Login");
            }
            else
            {
                tt.SetToolTip(sender as Control, "Log out");
            }
        }
    }
}
