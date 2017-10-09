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
    public partial class UserAddCodeForm : MetroFramework.Forms.MetroForm
    {
        public UserAddCodeForm()
        {
            InitializeComponent();
        }

        public bool CheckValidations {
            get {
                if (TxtCodeTitle.TextLength > 3 && RtxtCodes.TextLength > 10 && TxtCodeDescription.TextLength>10 && TxtCodeTags.TextLength>2 && ClbLanguages.SelectedItems.Count>0)
                {
                    return true;
                }
                return false;
            }
        }

        private void CbtnSend_Click(object sender, EventArgs e)
        {
            if (CheckValidations)
            {
                // Bir şeyler yap
            }
            else
            {
                MessageBox.Show("Please enter all fields properly");
            }
        }
    }
}
