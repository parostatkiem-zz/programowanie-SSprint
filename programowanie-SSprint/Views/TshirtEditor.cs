using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programowanie_SSprint.Views
{
    public partial class TshirtEditor : Form
    {
        #region EVENTS
        public event Func<IErrorable, List<DB_classes.Tshirt>> getAllThsirts; //pobiera wszystkie dane z tabeli Tshirts
        public event Func<IErrorable, DB_classes.Tshirt, bool> insertSingleTshirt;//jesli tshirt.id==null, to dodaje nowy tshirt, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<DB_classes.Color>> getAllColors; //zwraca listę wszystkich kolorów
        public event Func<IErrorable, List<DB_classes.Company>> getAllCompanies; //zwraca listę wszystkich firm


        #endregion
        public TshirtEditor()
        {
            InitializeComponent();
        }
    }
}
