using CodeLab.Classes;
using CodeLab.Custom_Controls;
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
    public partial class ListResults : MetroFramework.Forms.MetroForm
    {
        public ListResults()
        {
            InitializeComponent();
        }

        private void ListResults_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                MahmutEkle();
            }

            void MahmutEkle()
            {
                Random rnd = new Random();
                var mahmut = new ResultPreviewPanel("Mail atma2 Programı", DateTime.Now.ToShortTimeString(), new Rate(rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100)), "c#", "Mahmut-San");
                resultContainer1.Add(mahmut);
            }
        }
    }
}
