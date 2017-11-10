using System.Drawing;
using System.Windows.Forms;

namespace CodeLab.Custom_Controls
{
    public partial class ResultContainer : UserControl
    {
        public ResultContainer()
        {
            InitializeComponent();
        }
        private int _lastY = 0;
        public void Add(UserControl userControl)
        {
            userControl.Location = new Point(userControl.Location.X, _lastY);
            this.Controls.Add(userControl);
            _lastY += userControl.Size.Height + 10;
        }
     
    }
}
