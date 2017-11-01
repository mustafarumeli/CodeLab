using CodeLab.Classes;
using CodeLab.Classes.Database;
using CodeLab.Classes.Database.Entities;
using CodeLab.Custom_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLab.Forms
{
    public partial class ListResults : MetroFramework.Forms.MetroForm
    {
        private readonly CodePieceCrud _codePieceCrud;
        public ListResults(string searchText)
        {
            InitializeComponent();
            LblResult.Text += searchText;
            _codePieceCrud = new CodePieceCrud();
        }
        
        private async void ListResults_LoadAsync(object sender, EventArgs e)
        {
            var text = LblResult.Text;
            LblResult.Text = "Listing";
            System.Threading.ThreadStart childref = WaitingText();
            System.Threading.Thread childThread = new System.Threading.Thread(childref);
            childThread.Start();
            var results = await _codePieceCrud.GetAll(new MongoDB.Bson.BsonDocument());
            childThread.Abort();
            LblResult.Text = text;

            foreach (var result in results)
            {
                var user = await new UserCrud().GetOne(result.Contributer);
                resultContainer1.Add(new ResultPreviewPanel(result._id, result.Title, result.Date.ToString(CultureInfo.InvariantCulture), result.Scores, result.GetLanguages(), user.Name));
            }

        }

        private System.Threading.ThreadStart WaitingText()
        {
            return new System.Threading.ThreadStart(() =>
            {
                head:
                for (int i = 0; i < 4; i++)
                {
                    System.Threading.Thread.Sleep(100);
                    Invoke((MethodInvoker)(() => LblResult.Text += '.'));
                    Application.DoEvents();
                }
                Invoke((MethodInvoker)(() => LblResult.Text = "Listing"));
                Application.DoEvents();
                goto head;
            });
        }
    }
}
