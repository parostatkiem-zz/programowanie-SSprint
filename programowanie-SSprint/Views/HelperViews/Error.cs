using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programowanie_SSprint.Views.HelperViews
{
    public partial class Error : Form
    {
        public Error(string message, string longMessage = null ,string title="Error")
        {
            InitializeComponent();
            lMessage.Text = message;
            Text = title;
            if(longMessage==null)
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
