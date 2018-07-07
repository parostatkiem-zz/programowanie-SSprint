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
    public partial class PictureEditor : Form,IErrorable, ICommunicative
    {
        #region EVENTS
       
        public event Func<IErrorable, ICommunicative, picture, bool> insertPicture; //jesli color.id==null, to dodaje nowy obraz, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, ICommunicative, List<picture>> getAllPictures; //zwraca listę wszystkich obrazow
        public event Func<IErrorable, ICommunicative, picture, bool> removePicture; //usuwa obraz. Istotne jest tylko picture.id. Zwraca bool czy się udało

        public event Action<object> ReturnSingleObject;
        public event Action<List<object>> ReturnListOfObjects;

        #endregion
        public PictureEditor()
        {
            InitializeComponent();
            currentlySelectedPicture = null;
            currentlyEditedPicture = new picture();
            this.ReturnListOfObjects += PictureEditor_ReturnListOfObjects;
        }

        private void PictureEditor_ReturnListOfObjects(List<object> obj)
        {
            List<picture> recievedPictures = obj.OfType<picture>().ToList();
            if (recievedPictures != null)
            {
                DisplayPictureList(recievedPictures);
                return;
            }
        }

        public void ShowError(string message, string longMessage = null, string title = null)
        {
            var ErrorWindow = new Views.HelperViews.Error(message, longMessage, title);
            ErrorWindow.ShowDialog();
        }
        public void PushNotification(string text, int type = 0)
        {
            notificationPanel1.PushNotification(text, type);
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
          getAllPictures(this, this);
        }

        private void DisplayPictureList(List<picture> theList)
        {
            lvPictures.Items.Clear();


            ListViewItem item;
            foreach (var c in theList)
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
            insertPicture(this, this, currentlyEditedPicture);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (CurrentlySelectedPicture == null)
            {
                ShowError("Wygląda na to, że żaden obrazek nie jest zaznaczony");
                return;
            }

            removePicture(this, this, CurrentlySelectedPicture);
        }
    }
}
