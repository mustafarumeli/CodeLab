using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeLab.Classes;

namespace CodeLab.Forms.Auth
{
    public partial class PasswordRecovery : MetroFramework.Forms.MetroForm
    {
        private uint _timeCount = 180;
        private string _generatedCode ="";
        public string Encrypt;

        public PasswordRecovery(string generatedCode)
        {
            _generatedCode = generatedCode;
            InitializeComponent();
            TimerCounter.Start();
        }

        private void TimerCounter_Tick(object sender, EventArgs e)
        {
            LabelTimer.Text = (--_timeCount).ToString();
            if (_timeCount <= 0)
            {
                Close();
                TimerCounter.Stop();
            }
        }

        private void TextBoxGeneratedCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBoxGeneratedCode.Text == _generatedCode)
                {
                    TimerCounter.Stop();
                    PanelBefore.Visible = false;
                    PanelPasswordSend.Location = PanelBefore.Location;
                    PanelBefore.Visible = true;
                    //todo enter new password
                }
                else
                {
                    MessageBox.Show("Code is Incorrect");
                }
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (TextBoxNewPassword.Text == TextBoxPasswordAgain.Text)
            {
                Encrypt = CryptoService.Encrypt(TextBoxNewPassword.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Passwords you have entered do not match");
            }
        }

    }
}
