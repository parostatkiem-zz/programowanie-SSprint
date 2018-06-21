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
    public partial class ColorEditor : Form
    {
        #region EVENTS
        public event Func<IErrorable, DB_classes.Color, bool> insertColor; //jesli color.id==null, to dodaje nowy color, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<DB_classes.Color>> getAllColors; //zwraca listę wszystkich kolorów
        public event Func<IErrorable, DB_classes.Color, bool> removeColor; //usuwa kolor. Istotne jest tylko color.id. Zwraca bool czy się udało

        #endregion
        public ColorEditor()
        {
            InitializeComponent();
        }
    }
}
