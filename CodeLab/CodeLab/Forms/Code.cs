using CodeLab.Classes;
using CodeLab.Classes.Database;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLab.Forms
{
    public partial class Code : MetroFramework.Forms.MetroForm
    {
        private readonly string _id;
        private readonly CodePieceCrud _codePieceCrud;
        public Code(string id)
        {
            InitializeComponent();
            _id = id;
            _codePieceCrud = new CodePieceCrud();
        }


        private async void Code_LoadAsync(object sender, EventArgs e)
        {
            var codePiece = await _codePieceCrud.GetOne(_id);
            LblDesc.Text = codePiece.Description;
            TbCode.Text = codePiece.Code;
            using (var ms = new MemoryStream(codePiece.Picture))
            {
                PBpicture.Image = Image.FromStream(ms);
            }
            this.Text = codePiece.Title;

        }
    }
}
