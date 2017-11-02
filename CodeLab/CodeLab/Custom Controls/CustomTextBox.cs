using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLab.Custom_Controls
{
    public class CustomRichTextBox:RichTextBox
    { 
        public void AppendText(string text, Color color)
        {
            SelectionStart = TextLength;
            SelectionLength = 0;

            SelectionColor = color;
            AppendText(text+Environment.NewLine);
            SelectionColor = ForeColor;
        }
    }
}
