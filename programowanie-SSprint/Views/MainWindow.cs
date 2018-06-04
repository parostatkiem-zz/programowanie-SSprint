using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programowanie_SSprint
{
    public partial class MainWindow : Form, ImainView
    {

        #region EVENTS
        public event Func<List<DB_classes.Tshirt>> getAllThsirts; //pobiera wszystkie dane z tabeli Tshirts
        public event Func<int, DB_classes.Order> getSingleOrder; //pobiera jeden order o danym ID

        public event Func<DB_classes.Order, bool> insertSingleOrder;//jesli order.id==null, to dodaje nowy order, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<List<DB_classes.SingleItemOrder>,bool> insertListOfItems;//wstawia listę zamówionych koszulek. MAją one ustawione order_id. Zwraca bool czy się udało
        #endregion

        #region PUBLIC

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion
        #region GENERATED_EVENTS
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region PRIVATE_VARIABLES_PROPERTIES
        #endregion
        #region PRIVATE_METHODS
        #endregion


    }
}
