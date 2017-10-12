using CodeLab.Classes;
using CodeLab.Classes.Database;
using CodeLab.Classes.Database.Entities;
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
        CodePieceCRUD codePieceCRUD;
        public ListResults(string searchText)
        {
            InitializeComponent();
            LblResult.Text += searchText;
            codePieceCRUD = new CodePieceCRUD();
        }
        
        private async void ListResults_LoadAsync(object sender, EventArgs e)
        {

            var results = await codePieceCRUD.GetAll(new MongoDB.Bson.BsonDocument());
            foreach (var result in results)
            { 
                User user = await new UserCRUD().GetOne(result.Contributer);
                resultContainer1.Add(new ResultPreviewPanel(result._id, result.Title, result.Date.ToString(), result.Scores, result.Language, user.Name));
            }
            
        }
    }
}
