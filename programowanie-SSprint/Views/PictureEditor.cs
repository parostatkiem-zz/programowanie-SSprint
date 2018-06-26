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
    public partial class PictureEditor : Form,IErrorable
    {
        #region EVENTS
        public event Func<IErrorable, picture, bool> insertPicture; //jesli color.id==null, to dodaje nowy obraz, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<picture>> getAllPictures; //zwraca listę wszystkich obrazow
        public event Func<IErrorable, picture, bool> removePicture; //usuwa obraz. Istotne jest tylko picture.id. Zwraca bool czy się udało

        #endregion
        public PictureEditor()
        {
            InitializeComponent();
        }
        public void ShowError(string message, string longMessage = null, string title = null)
        {
            var ErrorWindow = new Views.HelperViews.Error(message, longMessage, title);
            ErrorWindow.ShowDialog();
        }
        #region PRIVATE
        private picture currentlyEditedPicture;
        private picture currentlySelectedPicture;

        private picture CurrentlySelectedPicture
        {
            get { return currentlySelectedPicture; }
            set
            {
                currentlySelectedPicture = value;
                displaySinglePicture(currentlySelectedPicture);
            }
        }
        #endregion

      

        private void RefreshPictureList()
        {
            lvPictures.Items.Clear();

            List<picture> recievedPictures = getAllPictures(this);

            ListViewItem item;
            foreach (var c in recievedPictures)
            {
                item = new ListViewItem(c.id.ToString());
                item.Tag = c;
                item.SubItems.Add(c.name);
               item.SubItems.Add(c.orders.ToString()); //TODO do poprawki
                lvPictures.Items.Add(item);
            }
        }

        private void displaySinglePicture(picture p)
        {
            currentlyEditedPicture = p;
            if (p != null)
            {
                tbName.Text = p.name;
                tbID.Text = p.id.ToString();
                //TODO: dodać wyświetlanie obrazka
            }
            else
            {
                //wyswietlanie pustego obrazka
                tbName.Text = "";
                tbID.Text = "";
                //tbHex.Text = "";
            }
            return;
        }

        #region GENERATED_EVENTS
        private void PictureEditor_Load(object sender, EventArgs e)
        {
            RefreshPictureList();
        }
        #endregion

        private void lvPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPictures.SelectedItems.Count <= 0 || lvPictures.SelectedItems[0].Tag == null) return; //nic nie jest zaznaczone

            CurrentlySelectedPicture = lvPictures.SelectedItems[0].Tag as picture;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text.Length <= 0) { return; }//error

            currentlyEditedPicture.name = tbName.Text;
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            //sprawdzanie poprawnosci
            if (currentlyEditedPicture == null) return;
            insertPicture(this, currentlyEditedPicture);
            groupBoxGraphicList.Visible = true;
            RefreshPictureList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //wypada dać potwierdzenie
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz odrzucić wprowadzone zmiany?", "Potwierdzenie odrzucenia zmian", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            groupBoxGraphicList.Visible = true;
            currentlyEditedPicture = null;
            CurrentlySelectedPicture = CurrentlySelectedPicture; //odswiezenie
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            CurrentlySelectedPicture = null;
            currentlyEditedPicture = new picture();
            groupBoxGraphicList.Visible = false;
        }
    }
}
