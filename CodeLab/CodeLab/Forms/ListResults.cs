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
            this.Text = "Listing";
            var thread = new Threader(this,"Listing");
            thread.Run();
            List<CodePiece> results = await DbFactory.CodePieceCrud.GetAll(_filter);
            bool hasResults = false;
            results = ReDesignResults();
            List<CodePiece> ReDesignResults()
            {
                List<CodePiece> returnList = new List<CodePiece>();
                List<CodePiece> viableList = new List<CodePiece>();//CodePiece._id
                var currentUsersSearchHistory = MainForm.CurrentUser.SearchHistories;
               
                foreach (var result in results)
                {

                    if (IsAViableResult(result) == true)
                    {
                        if (hasResults == false)
                        {
                            hasResults = true;
                        }
                        viableList.Add(result);
                    }

                }
                Dictionary<CodePiece,int> primaryDict = new Dictionary<CodePiece, int>();
                foreach (var item in currentUsersSearchHistory)
                {
                    CodePiece currentItemInViableList = viableList.FirstOrDefault(x => x._id == item.CodePieceId);
                    if (currentItemInViableList != null)
                    {
                        primaryDict.Add(currentItemInViableList,item.Point);
                        viableList.Remove(currentItemInViableList);
                    }
                }
                viableList = viableList.OrderByDescending(x => x.Votes.TotalPoint).ToList();
                returnList.AddRange(primaryDict.OrderByDescending(x => x.Value).Select(x => x.Key).ToList());
                returnList.AddRange(viableList);
                return returnList;
            }
            bool IsAViableResult(CodePiece result)
            {
                string searchInto = result.Title + result.Description;
                searchInto = searchInto.ToLower();
                string searchTextTemp = _searchText.ToLower();
                int searchTextLenght = _searchText.Length;
                int occurance = 0;
                for (int i = 0; i < searchInto.Length-searchTextLenght; i++)
                {
                    string currentSlice = searchInto.Substring(i, searchTextLenght);
                    if (currentSlice == searchTextTemp)
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
            foreach (var result in results)
            {       var user = await new UserCrud().GetOne(result.Contributer);
                    resultContainer1.Add(new ResultPreviewPanel(result._id, result.Title, result.Date.ToShortDateString(), result.Scores, result.Language, user.Name,result.Votes.TotalPoint));
            }
            this.Text = _searchText == "" ? "Showing All Results" : "Results for : " + _searchText;
            if (hasResults == false)
            {
                this.Text +=  "NO RESULT";
            }

        }
    }
}
