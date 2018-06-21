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
    public partial class PictureEditor : Form
    {
        #region EVENTS
        public event Func<IErrorable, DB_classes.Picture, bool> insertPicture; //jesli color.id==null, to dodaje nowy obraz, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<DB_classes.Picture>> getAllPictures; //zwraca listę wszystkich obrazow
        public event Func<IErrorable, DB_classes.Picture, bool> removePicture; //usuwa obraz. Istotne jest tylko picture.id. Zwraca bool czy się udało

        #endregion
        public PictureEditor()
        {
            InitializeComponent();
        }

    }
}
