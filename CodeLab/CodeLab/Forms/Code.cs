using CodeLab.Classes;
using CodeLab.Classes.Database;
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
        CodePieceCRUD codePieceCrud;
        public Code(string id)
        {
            InitializeComponent();
            _id = id;
            codePieceCrud = new CodePieceCRUD();
        }


        private async void Code_LoadAsync(object sender, EventArgs e)
        {
            var codePiece = await codePieceCrud.GetOne(_id);
            LblDesc.Text = codePiece.Description;
            TbCode.Text = codePiece.Code;
            this.Text = codePiece.Title;

        }
    }
}
