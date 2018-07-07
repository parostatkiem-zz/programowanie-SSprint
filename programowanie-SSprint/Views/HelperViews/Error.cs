using System.Windows.Forms;

namespace programowanie_SSprint.Views.HelperViews
{
    public partial class Error : Form
    {
        public Error(string message, string longMessage = null, string title = "Error")
        {
            InitializeComponent();
            lMessage.Text = message;
            Text = title;
            if (longMessage == null)
            {
                tbLongMessage.Visible = false;
            }
            else
            {
                tbLongMessage.Text = longMessage;
            }
            Width = 100;
        }
    }
}
