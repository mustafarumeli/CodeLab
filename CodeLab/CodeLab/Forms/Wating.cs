using System;
using CodeLab.Classes.Database;
using CodeLab.Classes.Database.Entities;

namespace CodeLab.Forms
{
    public partial class Waiting
    {
        private readonly Classes.Database.CRUD<CodePiece> _codePieceCrud;
        private readonly string _id;
        public Waiting(string id)
        {
            InitializeComponent();
            _codePieceCrud = new Classes.Database.CRUD<CodePiece>(DbFactory.CodePieces);
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
