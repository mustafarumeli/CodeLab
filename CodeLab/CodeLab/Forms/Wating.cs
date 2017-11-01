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
    public partial class Waiting : Form
    {
        private readonly Classes.Database.CodePieceCrud _codePieceCrud;
        string _id;
        public Waiting(string id)
        {
            InitializeComponent();
            _codePieceCrud = new Classes.Database.CodePieceCrud();
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
