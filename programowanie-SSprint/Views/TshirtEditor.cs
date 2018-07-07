using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace programowanie_SSprint
{
    public partial class TshirtEditor : Form, IErrorable, ICommunicative
    {
        #region EVENTS
        public event Func<IErrorable, ICommunicative, List<tshirt>> getAllThsirts; //pobiera wszystkie dane z tabeli Tshirts
        public event Func<IErrorable, ICommunicative, tshirt, bool> insertSingleTshirt;//jesli tshirt.id==null, to dodaje nowy tshirt, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, ICommunicative, tshirt, bool> removeTshirt;
        public event Func<IErrorable, ICommunicative, List<company>> getAllCompanies; //zwraca listę wszystkich firm
        public event Func<IErrorable, ICommunicative, List<color>> getAllColors; //zwraca listę wszystkich kolorów
        public event Func<IErrorable, ICommunicative, List<style>> getAllStyles; //zwraca listę wszystkich kolorów


        public event Action<List<object>> ReturnListOfObjects;


        #endregion

        #region PUBLIC
        public TshirtEditor()
        {
            InitializeComponent();
            this.ReturnListOfObjects += TshirtEditor_ReturnListOfObjects;

        }

        private void TshirtEditor_ReturnListOfObjects(List<object> obj)
        {
            List<tshirt> recievedTshirts = obj.OfType<tshirt>().ToList();
            if (recievedTshirts != null)
            {
                DisplayTshirtList(recievedTshirts);
                return;
            }

            List<company> recievedCompanies = obj.OfType<company>().ToList();
            if (recievedCompanies != null)
            {
                DisplayCompanyList(recievedCompanies);
                return;
            }

            List<color> recievedColors = obj.OfType<color>().ToList();
            if (recievedColors != null)
            {
                DisplayColorList(recievedColors);
                return;
            }

            List<style> recievedStyles = obj.OfType<style>().ToList();
            if (recievedStyles != null)
            {
                DisplayStyleList(recievedStyles);
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


        #endregion

        #region GENERATED_EVENTS
        private void btnEditCompanies_Click(object sender, EventArgs e)
        {
            CompanyEditor companyDialog = new CompanyEditor();
            companyDialog.ShowDialog();
            FillCompanyControl();
        }

        private void btnEditColors_Click(object sender, EventArgs e)
        {
            ColorEditor colorDialog = new ColorEditor();

            colorDialog.Show();
            FillColorControl();
        }
        private void TshirtEditor_Load(object sender, EventArgs e)
        {
            getAllThsirts(this, this);
            FillAllControls();
            CurrentlySelectedTshirt = null;
        }

        private void treeViewProductBrowser_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ((treeViewProductBrowser.SelectedNode.Tag as tshirt) == null) return;
            CurrentlySelectedTshirt = treeViewProductBrowser.SelectedNode.Tag as tshirt;
        }


        private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCompany.SelectedItem == null) return;
            currentlyEditedTshirt.company_id = (comboBoxCompany.SelectedItem as company).id;
        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSex.SelectedItem == null) return;
            currentlyEditedTshirt.sex = comboBoxSex.SelectedItem.ToString();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxModel.SelectedItem == null) return;
            currentlyEditedTshirt.style_id = (comboBoxModel.SelectedItem as style).id;
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxColor.SelectedItem == null) return;
            currentlyEditedTshirt.color_id = (comboBoxColor.SelectedItem as color).id;
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSize.SelectedItem == null) return;
            currentlyEditedTshirt.size = comboBoxSize.SelectedItem.ToString();
        }

        private void numericDefaultLoss_ValueChanged(object sender, EventArgs e)
        {
            if (currentlyEditedTshirt == null) return;
            currentlyEditedTshirt.default_loss_percentage = (int)numericDefaultLoss.Value;
        }

        private void numInStock_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentlySelectedTshirt != null && numInStock.Value < CurrentlySelectedTshirt.getOrdered())
            {
                ShowError("Ilosć koszulek w magazynie nie może być mniejsza, niż ilośc zarezerwowana");
                numInStock.Value = CurrentlySelectedTshirt.in_stock;
                return;
            }
            currentlyEditedTshirt.in_stock = (int)numInStock.Value;
            tbAvailable.Text = currentlyEditedTshirt.getNotOrdered().ToString();
            tbReserved.Text = currentlyEditedTshirt.getOrdered().ToString();
        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {
            currentlyEditedTshirt.price = (int)numPrice.Value;
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            insertSingleTshirt(this, this, currentlyEditedTshirt);
            if (!treeViewProductBrowser.Visible)
            {

                treeViewProductBrowser.Visible = true;

            }
            btnAddNew.Visible = true;
            btnDelete.Visible = true;
            getAllThsirts(this, this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CurrentlySelectedTshirt == null) return;
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz nieodwracalnie usunąć wybraną koszulkę (" + CurrentlySelectedTshirt.ToString() + ")?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            removeTshirt(this, this, CurrentlySelectedTshirt);
            getAllThsirts(this, this);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz odrzucić wprowadzone zmiany?", "Potwierdzenie odrzucenia zmian", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            DisplaySingleTshirt(CurrentlySelectedTshirt);
            treeViewProductBrowser.Visible = true;
            btnAddNew.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            treeViewProductBrowser.Visible = false;
            CurrentlySelectedTshirt = null;
            currentlyEditedTshirt = new tshirt();
            currentlyEditedTshirt.singleItemOrders = new List<singleItemOrder>();
            btnAddNew.Visible = false;
            btnDelete.Visible = false;
            getAllThsirts(this, this);
        }

        #endregion

        #region PRIVATE
        private tshirt currentlyEditedTshirt;
        private tshirt currentlySelectedTshirt;
        private tshirt CurrentlySelectedTshirt
        {
            get { return currentlySelectedTshirt; }
            set
            {
                currentlySelectedTshirt = value;
                DisplaySingleTshirt(currentlySelectedTshirt);

                currentlyEditedTshirt = new tshirt();
                if (value != null)
                {
                    currentlyEditedTshirt.CopyFrom(currentlySelectedTshirt);
                    currentlyEditedTshirt.id = CurrentlySelectedTshirt.id;
                    gbTshirtProperties.Visible = true;
                }
                else
                {
                    gbTshirtProperties.Visible = false;
                }
            }
        }

        private void DisplaySingleTshirt(tshirt t)
        {
            if (t == null)
            {
                //czyszczenie pól
                comboBoxCompany.SelectedItem = null;
                comboBoxColor.SelectedItem = null;
                comboBoxSize.SelectedItem = null;
                comboBoxCompany.SelectedItem = null;
                comboBoxModel.SelectedItem = null;
                comboBoxSex.SelectedItem = null;
                numericDefaultLoss.Value = 10;
                numInStock.Value = 0;
                numPrice.Value = 0;
                return;
            }

            foreach (var c in comboBoxCompany.Items)
                if ((c as company).id == t.company.id) comboBoxCompany.SelectedItem = c;

            foreach (var c in comboBoxModel.Items)
                if ((c as style).id == t.style.id) comboBoxModel.SelectedItem = c;

            foreach (var c in comboBoxSex.Items)
                if (c.ToString() == t.sex) comboBoxSex.SelectedItem = c;

            foreach (var c in comboBoxSize.Items)
                if (c.ToString() == t.size) comboBoxSize.SelectedItem = c;


            foreach (var c in comboBoxColor.Items)
                if ((c as color).id == t.color.id) comboBoxColor.SelectedItem = c;


            tbId.Text = t.id.ToString();
            numericDefaultLoss.Value = t.default_loss_percentage;
            numInStock.Value = t.in_stock;
            numPrice.Value = t.price;
            try
            {
                tbAvailable.Text = t.getNotOrdered().ToString();
                tbReserved.Text = t.getOrdered().ToString();
            }
            catch
            {
                tbAvailable.Text = "";
                tbReserved.Text = "";
            }

        }


        private void FillCompanyControl()
        {
            getAllCompanies(this, this);

        }

        private void FillStyleControl()
        {
            getAllStyles(this, this);

        }

        private void FillColorControl()
        {
            getAllColors(this, this);

        }
        private void FillAllControls()
        {
            FillCompanyControl();
            FillColorControl();
            FillStyleControl();
        }

        private void TryToSelectNode(int index)
        {
            try
            {
                foreach (TreeNode n in treeViewProductBrowser.Nodes)
                {
                    if (n.Tag is tshirt && (n.Tag as tshirt).id == index)
                        treeViewProductBrowser.SelectedNode = n;
                }
                //   treeViewProductBrowser.SelectedNode = treeViewProductBrowser.Nodes.Find(t.ToString(), true).First();
                treeViewProductBrowser.SelectedNode.EnsureVisible();
            }
            catch { }

        }
        private void DisplayTshirtList(List<tshirt> theList)
        {
            VisualHelper.RefreshTshirtList(treeViewProductBrowser, theList);
        }

        private void DisplayCompanyList(List<company> theList)
        {
            comboBoxCompany.Items.Clear();
            comboBoxCompany.Items.AddRange(theList.ToArray());
        }

        private void DisplayColorList(List<color> theList)
        {
            comboBoxColor.Items.Clear();
            comboBoxColor.Items.AddRange(theList.ToArray());
        }

        private void DisplayStyleList(List<style> theList)
        {
            comboBoxModel.Items.Clear();
            comboBoxModel.Items.AddRange(theList.ToArray());
        }


        #endregion


    }
}
