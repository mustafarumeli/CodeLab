using CodeLab.Classes;
using CodeLab.Classes.Database;
using CodeLab.Classes.Database.Entities;
using CodeLab.Custom_Controls;
using System;
using System.Globalization;

namespace CodeLab.Forms
{
    public partial class ListResults : MetroFramework.Forms.MetroForm
    {
        private readonly CodePieceCRUD _codePieceCrud;
        private readonly string _resultText;
        private readonly string[] _selectedLanguages;
        public ListResults(string searchText, string[] selectedLanguages)
        {
            InitializeComponent();
            _resultText = LblResult.Text += searchText;
            _selectedLanguages = selectedLanguages;
            _codePieceCrud = DbFactory.CodePieceCrud;
        }
        
        private async void ListResults_LoadAsync(object sender, EventArgs e)
        {
            LblResult.Text = "Listing";
            var thread = new Threader(LblResult,"Listing");
            thread.Run();
            var results = await _codePieceCrud.GetAll(new MongoDB.Bson.BsonDocument());
            thread.Stop();
            foreach (var result in results)
            {
                var user = await new UserCrud().GetOne(result.Contributer);
                resultContainer1.Add(new ResultPreviewPanel(result._id, result.Title, result.Date.ToString(CultureInfo.InvariantCulture), result.Scores, result.Language, user.Name));
            }
            LblResult.Text = _resultText;
        }
    }
}
