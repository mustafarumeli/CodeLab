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
    public partial class SeeComments : MetroFramework.Forms.MetroForm
    {
        public SeeComments()
        {
            InitializeComponent();
            CommentContainer.Init();
        }

     
    }
}
