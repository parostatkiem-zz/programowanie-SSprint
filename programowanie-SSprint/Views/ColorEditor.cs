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
    public partial class ColorEditor : Form,IErrorable
    {
        #region EVENTS
        public event Func<IErrorable, DB_classes.Color, bool> insertColor; //jesli color.id==null, to dodaje nowy color, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<DB_classes.Color>> getAllColors; //zwraca listę wszystkich kolorów
        public event Func<IErrorable, DB_classes.Color, bool> removeColor; //usuwa kolor. Istotne jest tylko color.id. Zwraca bool czy się udało

        #endregion

        #region PUBLIC
        public void ShowError(string message, string longMessage = null, string title = null)
        {
            var ErrorWindow = new Views.HelperViews.Error(message, longMessage, title);
            ErrorWindow.ShowDialog();
        }
        #endregion
        public ColorEditor()
        {
            InitializeComponent();
            currentlySelectedColor = null;
            currentlyEditedColor = null;
        }
        private DB_classes.Color currentlyEditedColor;
        private DB_classes.Color currentlySelectedColor;
        private DB_classes.Color CurrentlySelectedColor
        {
            get { return currentlySelectedColor; }
            set
            {
                currentlySelectedColor = value;
                displaySingleColor(currentlySelectedColor);
            }
        }

        private void ColorEditor_Load(object sender, EventArgs e)
        {
            RefreshColorList();
        }

        private void RefreshColorList()
        {
            lvColors.Items.Clear();

            List<DB_classes.Color> recievedColors = getAllColors(this);

            ListViewItem item;
            foreach(var c in recievedColors)
            {
                item = new ListViewItem(c.Id.ToString());
                item.Tag = c;
                item.SubItems.Add(c.Name);
                item.SubItems.Add(c.Hex_value);
                lvColors.Items.Add(item);
            }
        }

        private void lvColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvColors.SelectedItems.Count <= 0 || lvColors.SelectedItems[0].Tag == null) return; //nic nie jest zaznaczone

            CurrentlySelectedColor = lvColors.SelectedItems[0].Tag as DB_classes.Color;
        }

        private void displaySingleColor(DB_classes.Color c)
        {
            currentlyEditedColor = c;
            if (c != null)
            { 
                tbName.Text = c.Name;
                tbID.Text = c.Id.ToString();
                tbHex.Text = c.Hex_value;
            }
            else
            {
                //wyswietlanie pustego koloru
                tbName.Text = "";
                tbID.Text = "";
                tbHex.Text = "";
            }
            return;
        }
    }
}
