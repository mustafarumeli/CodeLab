using CodeLab.Classes;
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
    public partial class Code : MetroFramework.Forms.MetroForm
    {
        string _id;
        public Code(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void Code_LoadAsync(object sender, EventArgs e)
        {
            var codePiece = await Server.GetValue<CodePiece>(new MongoDB.Bson.BsonDocument { { "_id", _id } });
            LblDesc.Text = codePiece.Description;
            TbCode.Text = codePiece.Code;
            this.Text = codePiece.Title;

        }
    }
}
