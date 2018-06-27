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
        public event Action saveDatabaseToRemote; //zapisuje dane do bazy zdalnej
        public event Func<IErrorable, color, bool> insertColor; //jesli color.id==null, to dodaje nowy color, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<color>> getAllColors; //zwraca listę wszystkich kolorów
        public event Func<IErrorable, color, bool> removeColor; //usuwa kolor. Istotne jest tylko color.id. Zwraca bool czy się udało

        #endregion

        #region PUBLIC
        public void ShowError(string message, string longMessage = null, string title = null)
        {
            var ErrorWindow = new Views.HelperViews.Error(message, longMessage, title);
            ErrorWindow.ShowDialog();
        }
       
        public ColorEditor()
        {
            InitializeComponent();
            currentlySelectedColor = null;
            currentlyEditedColor = null;
        }
        #endregion
        private color currentlyEditedColor;
        private color currentlySelectedColor;
        private color CurrentlySelectedColor
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

            List<color> recievedColors = getAllColors(this);

            ListViewItem item;
            foreach(var c in recievedColors)
            {
                item = new ListViewItem(c.id.ToString());
                item.Tag = c;
                item.SubItems.Add(c.name);
                item.SubItems.Add(c.hex_value);
                lvColors.Items.Add(item);
            }
        }

        private void lvColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvColors.SelectedItems.Count <= 0 || lvColors.SelectedItems[0].Tag == null) return; //nic nie jest zaznaczone

            CurrentlySelectedColor = lvColors.SelectedItems[0].Tag as color;
        }

        private void displaySingleColor(color c)
        {
            currentlyEditedColor = c;
            if (c != null)
            {
                tbName.Text = c.name;
                tbID.Text = c.id.ToString();
                tbHex.Text = c.hex_value;
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

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text.Length <= 0) { return; }//error

            currentlyEditedColor.name = tbName.Text;
        }

        private void tbHex_TextChanged(object sender, EventArgs e)
        {
            if (tbHex.Text.Length <= 0) { return; }//error

            currentlyEditedColor.hex_value = tbHex.Text;
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            //sprawdzanie poprawnosci
            if (currentlyEditedColor == null) return;
            insertColor(this, currentlyEditedColor);
            groupBoxColorList.Visible = true;
            RefreshColorList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //wypada dać potwierdzenie
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz odrzucić wprowadzone zmiany?", "Potwierdzenie odrzucenia zmian", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;
            
            groupBoxColorList.Visible = true;
            currentlyEditedColor = null;
            CurrentlySelectedColor = CurrentlySelectedColor; //odswiezenie

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            CurrentlySelectedColor = null;
            currentlyEditedColor = new color();
            groupBoxColorList.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CurrentlySelectedColor == null)
            {
                ShowError("Wygląda na to, że żaden kolor nie jest zaznaczony");
                return;
            }

            removeColor(this, CurrentlySelectedColor);
        }

        private void ColorEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveDatabaseToRemote();
        }
    }
}
