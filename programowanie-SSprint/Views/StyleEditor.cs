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
    public partial class StyleEditor : Form,IErrorable
    {
      

      
        public event Func<IErrorable, style, bool> insertStyle; //jesli style.id==null, to dodaje nowy style, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<style>> getAllStyles; //zwraca listę wszystkich kolorów
        public event Func<IErrorable, style, bool> removeStyle; //usuwa kolor. Istotne jest tylko style.id. Zwraca bool czy się udało



        #region PUBLIC
        public void ShowError(string message, string longMessage = null, string title = null)
        {
            var ErrorWindow = new Views.HelperViews.Error(message, longMessage, title);
            ErrorWindow.ShowDialog();
        }

    
        public StyleEditor()
        {
            InitializeComponent();
            currentlySelectedStyle = null;
            currentlyEditedStyle = new style();
        }
        #endregion
        private style currentlyEditedStyle;
        private style currentlySelectedStyle;
        private style CurrentlySelectedStyle
        {
            get { return currentlySelectedStyle; }
            set
            {
                currentlySelectedStyle = value;
                displaySingleStyle(currentlySelectedStyle);
            }
        }

        private void StyleEditor_Load(object sender, EventArgs e)
        {
            RefreshStyleList();
        }

        private void RefreshStyleList()
        {
            lvStyles.Items.Clear();

            List<style> recievedStyles = getAllStyles(this);

            ListViewItem item;
            foreach (var c in recievedStyles)
            {
                item = new ListViewItem(c.id.ToString());
                item.Tag = c;
                item.SubItems.Add(c.name);
                lvStyles.Items.Add(item);
            }
        }

        private void lvStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStyles.SelectedItems.Count <= 0 || lvStyles.SelectedItems[0].Tag == null) return; //nic nie jest zaznaczone

            CurrentlySelectedStyle = lvStyles.SelectedItems[0].Tag as style;
        }

        private void displaySingleStyle(style c)
        {
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

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text.Length <= 0) { return; }//error

            currentlyEditedStyle.name = tbName.Text;
        }


        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            //sprawdzanie poprawnosci
            if (currentlyEditedStyle == null) return;
            insertStyle(this, currentlyEditedStyle);
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

            removeStyle(this, CurrentlySelectedStyle);
        }

    }
}
