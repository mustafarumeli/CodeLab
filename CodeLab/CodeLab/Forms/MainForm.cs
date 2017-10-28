using CodeLab.Classes;
using CodeLab.Classes.Database.Entities;
using CodeLab.Forms.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var lr = new ListResults(TbSearch.Text);
            lr.Show();
        }

        private void LblAuth_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.ShowDialog();
            if (CurrentUser == null) return;
            LblContribute.Visible = true;
            LblAuth.Text = "Welcome " + CurrentUser.Name;
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
        }
        /// <summary>
        /// Placeholder
        /// </summary>
        private void TbSearch_Enter(object sender, EventArgs e)
        {
            TbSearch.Text="";
            TbSearch.ForeColor = Color.Black;
        }
    }
}
