using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace programowanie_SSprint
{
    public partial class ColorEditor : Form, IErrorable, ICommunicative
    {
        #region EVENTS
        public event Action<IErrorable, ICommunicative, color> insertColor; //jesli color.id==null, to dodaje nowy color, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Action<IErrorable, ICommunicative> getAllColors; //zwraca listę wszystkich kolorów
        public event Action<IErrorable, ICommunicative, color> removeColor; //usuwa kolor. Istotne jest tylko color.id. Zwraca bool czy się udało

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
            currentlyEditedColor = new color();
        }
        public void ReturnListOfObjects(List<object> obj)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                _ReturnListOfObjects(obj);
            }));
        }
        
        public void PushNotification(string text, int type = 0)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                notificationPanel1.PushNotification(text, type);
            }));
           
        }

        #endregion

        #region PRIVATE
        private color currentlyEditedColor;
        private color currentlySelectedColor;
        private EditMode editMode;
        private color CurrentlySelectedColor
        {
            get { return currentlySelectedColor; }
            set
            {
                currentlySelectedColor = value;
                DisplaySingleColor(currentlySelectedColor);
            }
        }

        private Regex hexFieldRegex = new Regex(@"^(^$|[#][0-9abcdefABCDEF]{3}|[#][0-9abcdefABCDEF]{6})$");
        private void RefreshColorList()
        {
            getAllColors(this, this);
        }
        private void _ReturnListOfObjects(List<object> obj)
        {
            List<color> recievedColors = obj.OfType<color>().ToList();
            if (recievedColors != null)
            {
                DisplayColorList(recievedColors);
                return;
            }
        }

        private void DisplayColorList(List<color> theList)
        {
            lvColors.Items.Clear();
            ListViewItem item;
            foreach (var c in theList)
            {
                item = new ListViewItem(c.id.ToString());
                item.Tag = c;
                item.SubItems.Add(c.name);
                item.SubItems.Add(c.hex_value);
                lvColors.Items.Add(item);
            }
        }
        private void DisplaySingleColor(color c)
        {
            if (editMode != EditMode.AddNew)
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
        #endregion

        #region GENERATED_EVENTS
        private void ColorEditor_Load(object sender, EventArgs e)
        {
            RefreshColorList();
        }

        private void lvColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvColors.SelectedItems.Count <= 0 || lvColors.SelectedItems[0].Tag == null) return; //nic nie jest zaznaczone
            editMode = EditMode.Edit;
            CurrentlySelectedColor = lvColors.SelectedItems[0].Tag as color;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text.Length <= 0)
            {
                errorProvider1.SetError(tbName, "Wartośc nie może byc pusta");
                return;
            }//error
            errorProvider1.SetError(tbName, "");
            currentlyEditedColor.name = tbName.Text;
        }

        private void tbHex_TextChanged(object sender, EventArgs e)
        {
            //  if (tbHex.Text.Length <= 0) { return; }//error
            if (!hexFieldRegex.IsMatch(tbHex.Text))
            {
                errorProvider1.SetError(tbHex, "Wprowadź wartość w formacie: #aaa lub #aaaaaa");
                return;
             }
            errorProvider1.SetError(tbHex, "");
            currentlyEditedColor.hex_value = tbHex.Text;
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBoxEditArea.Controls)
            {
                if (errorProvider1.GetError(c).Length > 0) return;
            }

            if (currentlyEditedColor == null) return;
            insertColor(this, this, currentlyEditedColor);
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
            editMode = EditMode.AddNew;
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

            removeColor(this, this, CurrentlySelectedColor);
            RefreshColorList();
        }
        #endregion

    }
}
