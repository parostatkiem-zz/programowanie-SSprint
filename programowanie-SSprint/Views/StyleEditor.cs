using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace programowanie_SSprint
{
    public partial class StyleEditor : Form, IErrorable, ICommunicative
    {



        public event Func<IErrorable, ICommunicative, style, bool> insertStyle; //jesli style.id==null, to dodaje nowy style, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, ICommunicative, List<style>> getAllStyles; //zwraca listę wszystkich kolorów
        public event Func<IErrorable, ICommunicative, style, bool> removeStyle; //usuwa kolor. Istotne jest tylko style.id. Zwraca bool czy się udało


        #region PUBLIC
        public StyleEditor()
        {
            InitializeComponent();
            currentlySelectedStyle = null;
            currentlyEditedStyle = new style();
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


        public void ReturnListOfObjects(List<object> obj)
        {
            List<style> recievedStyles = obj.OfType<style>().ToList();
            if (recievedStyles != null)
            {
                DisplayStyleList(recievedStyles);
                return;
            }
        }
        #endregion
        private style currentlyEditedStyle;
        private style currentlySelectedStyle;
        private EditMode editMode;
        private style CurrentlySelectedStyle
        {
            get { return currentlySelectedStyle; }
            set
            {
                currentlySelectedStyle = value;
                DisplaySingleStyle(currentlySelectedStyle);
            }
        }


        private void RefreshStyleList()
        {
            getAllStyles(this, this);
        }


        private void DisplayStyleList(List<style> theList)
        {
            lvStyles.Items.Clear();

            ListViewItem item;
            foreach (var c in theList)
            {
                item = new ListViewItem(c.id.ToString());
                item.Tag = c;
                item.SubItems.Add(c.name);
                lvStyles.Items.Add(item);
            }
        }

        private void DisplaySingleStyle(style c)
        {
            if (editMode != EditMode.AddNew)
                currentlyEditedStyle = c;
            if (c != null)
            {
                tbName.Text = c.name;
                tbID.Text = c.id.ToString();
            }
            else
            {
                //wyswietlanie pustego koloru
                tbName.Text = "";
                tbID.Text = "";
            }
            return;
        }

        #region GENERATED_EVENTS
        private void StyleEditor_Load(object sender, EventArgs e)
        {
            RefreshStyleList();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text.Length <= 0)
            {
                errorProvider1.SetError(tbName, "Wartośc nie może byc pusta");
                return;
            }//error

            currentlyEditedStyle.name = tbName.Text;
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBoxEditArea.Controls)
            {
                if (errorProvider1.GetError(c).Length > 0) return;
            }
            if (currentlyEditedStyle == null) return;
            insertStyle(this, this, currentlyEditedStyle);
            groupBoxStyleList.Visible = true;
            RefreshStyleList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //wypada dać potwierdzenie
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz odrzucić wprowadzone zmiany?", "Potwierdzenie odrzucenia zmian", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            groupBoxStyleList.Visible = true;
            currentlyEditedStyle = null;
            CurrentlySelectedStyle = CurrentlySelectedStyle; //odswiezenie

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            editMode = EditMode.AddNew;
            CurrentlySelectedStyle = null;
            currentlyEditedStyle = new style();
            groupBoxStyleList.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CurrentlySelectedStyle == null)
            {
                ShowError("Wygląda na to, że żaden styl nie jest zaznaczony");
                return;
            }

            removeStyle(this, this, CurrentlySelectedStyle);
            RefreshStyleList();
        }
        private void lvStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStyles.SelectedItems.Count <= 0 || lvStyles.SelectedItems[0].Tag == null) return; //nic nie jest zaznaczone
            editMode = EditMode.Edit;
            CurrentlySelectedStyle = lvStyles.SelectedItems[0].Tag as style;
        }

        #endregion
    }
}
