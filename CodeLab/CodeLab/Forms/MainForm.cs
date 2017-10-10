using CodeLab.Classes;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ListResults lr = new ListResults(TbSearch.Text);
            lr.Show();
        }

        private void LblAuth_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void LblContribute_Click(object sender, EventArgs e)
        {
            using (var frm = new UserAddCodeForm())
            {
                frm.ShowDialog();
            }
        }

        private async void customButton1_ClickAsync(object sender, EventArgs e)
        {
            Server server = new Server();
            await server.InsertAsync();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            Server server = new Server();
            await server.GetValuesAsync();
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            Server server = new Server();
            await server.UpdateOneAsync();
        }

        private async void button3_ClickAsync(object sender, EventArgs e)
        {
            Server server = new Server();
            await server.DeleteOneAsync();
        }
    }
}
