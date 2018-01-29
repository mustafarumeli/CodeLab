using System;
using CodeLab.Classes.Database;
using CodeLab.Classes.Database.Entities;

namespace CodeLab.Forms
{
    public partial class Waiting
    {
        private readonly CodePieceCRUD _codePieceCrud;
        private readonly string _id;
        public Waiting(string id)
        {
            InitializeComponent();
            _codePieceCrud = DbFactory.CodePieceCrud;
            _id = id;
        }
        public Classes.Database.Entities.CodePiece CodePiece;
        private async void Wating_LoadAsync(object sender, EventArgs e)
        {
            CodePiece= await _codePieceCrud.GetOne(_id);
            Close();
        }

       
    }
}
