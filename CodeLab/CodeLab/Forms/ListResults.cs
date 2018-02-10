using CodeLab.Classes;
using CodeLab.Classes.Database;
using CodeLab.Classes.Database.Entities;
using CodeLab.Custom_Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CodeLab.Forms
{
    public partial class ListResults : MetroFramework.Forms.MetroForm
    {
        private readonly string _searchText;
        private readonly MongoDB.Bson.BsonDocument _filter;
        public ListResults(string searchText, MongoDB.Bson.BsonDocument filter)
        {
            InitializeComponent();
            _searchText = searchText;
            _filter = filter;
        }
        
        private async void ListResults_LoadAsync(object sender, EventArgs e)
        {
            LblResult.Text = "Listing";
            var thread = new Threader(LblResult,"Listing");
            thread.Run();
            List<CodePiece> results = await DbFactory.CodePieceCrud.GetAll(_filter);
            results = results.OrderByDescending(x => x.Votes.TotalPoint).ToList();
            bool IsAViableResult(CodePiece result)
            {
                string searchInto = result.Title + result.Description;
                searchInto = searchInto.ToLower();
                int searchTextLenght = _searchText.Length;
                int occurance = 0;
                for (int i = 0; i < searchInto.Length-searchTextLenght; i++)
                {
                    string currentSlice = searchInto.Substring(i, searchTextLenght);
                    if (currentSlice == _searchText)
                    {
                        occurance++;
                    }
                }
                if (occurance > 0)
                {
                    return true;
                }
                else
                {
                   return false;
                }
            }
            thread.Stop();
            bool hasResults = false;
            foreach (var result in results)
            {
                if (IsAViableResult(result) == true)
                {
                    if (hasResults == false)
                    {
                        hasResults = true;
                    }
                    var user = await new UserCrud().GetOne(result.Contributer);
                    resultContainer1.Add(new ResultPreviewPanel(result._id, result.Title, result.Date.ToString(CultureInfo.InvariantCulture), result.Scores, result.Language, user.Name));
                }

            }
            LblResult.Text += " " + _searchText;
            if (hasResults == false)
            {
                LblResult.ForeColor = System.Drawing.Color.Red;
                LblResult.Text += Environment.NewLine + "NO RESULT";
            }

        }
    }
}
