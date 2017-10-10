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
        public ListResults(string searchText)
        {
            InitializeComponent();
            LblResult.Text += searchText;
        }
        
        private async void ListResults_LoadAsync(object sender, EventArgs e)
        {

          var results = await Server.GetValuesAsync<CodePiece>(new MongoDB.Bson.BsonDocument());
            foreach (var result in results)
            {

                var user =  await Server.GetValue<User>(new MongoDB.Bson.BsonDocument { { "_id", result.Contributer } });
                resultContainer1.Add(new ResultPreviewPanel(result._id,result.Title, result.Date.ToString(), result.Scores, result.Language, user.Name));
            }
            
        }
    }
}
