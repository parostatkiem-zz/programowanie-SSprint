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
    public partial class TshirtEditor : Form,IErrorable
    {
        #region EVENTS
        public event Func<IErrorable, List<tshirt>> getAllThsirts; //pobiera wszystkie dane z tabeli Tshirts
        public event Func<IErrorable, tshirt, bool> insertSingleTshirt;//jesli tshirt.id==null, to dodaje nowy tshirt, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, tshirt, bool> removeTshirt;
        public event Func<IErrorable, List<company>> getAllCompanies; //zwraca listę wszystkich firm
        public event Func<IErrorable, List<color>> getAllColors; //zwraca listę wszystkich kolorów
        public event Func<IErrorable, List<style>> getAllStyles; //zwraca listę wszystkich kolorów




        #endregion
        #region PUBLIC
        public TshirtEditor()
        {
            InitializeComponent();
            
        }
        public void ShowError(string message, string longMessage = null, string title = null)
        {
            var ErrorWindow = new Views.HelperViews.Error(message, longMessage, title);
            ErrorWindow.ShowDialog();
        }


        #endregion

        #region GENERATED_EVENTS

        private void TshirtEditor_Load(object sender, EventArgs e)
        {
            RefreshTshirtList(getAllThsirts(this));
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
            // int theNodeId = currentlyEditedTshirt.id;
            insertSingleTshirt(this, currentlyEditedTshirt);
            if (!treeViewProductBrowser.Visible)
            {

                treeViewProductBrowser.Visible = true;
                RefreshTshirtList(getAllThsirts(this));
            }
            btnAddNew.Visible = true;
            btnDelete.Visible = true;
            //  TryToSelectNode(theNodeId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CurrentlySelectedTshirt == null) return;
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz nieodwracalnie usunąć wybraną koszulkę (" + CurrentlySelectedTshirt.ToString() + ")?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            removeTshirt(this, CurrentlySelectedTshirt);
            RefreshTshirtList(getAllThsirts(this));
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
            //currentlyEditedTshirt.
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

        private void RefreshTshirtList(List<tshirt> theList)
        {
            treeViewProductBrowser.Nodes.Clear();
            TreeNode tmp;
            TreeNode currentParentNode;


            foreach (tshirt t in theList)
            {
                //firma
                tmp = new TreeNode(t.company.name);
                tmp.Name = t.company.name;
                if (!treeViewProductBrowser.Nodes.ContainsKey(tmp.Name))
                {
                    //nie ma jeszcze takiej firmy
                    treeViewProductBrowser.Nodes.Add(tmp);
                }
                currentParentNode = treeViewProductBrowser.Nodes.Find(tmp.Name, false).First();


                //plec
                tmp = new TreeNode(t.sex);
                tmp.Name = t.sex;
                if (!currentParentNode.Nodes.ContainsKey(tmp.Name))
                {
                    //nie ma jeszcze takiej firmy
                    currentParentNode.Nodes.Add(tmp);
                }
                currentParentNode = currentParentNode.Nodes.Find(tmp.Name, false).First();

                //styl
                tmp = new TreeNode(t.style.name);
                tmp.Name = t.style.name;
                if (!currentParentNode.Nodes.ContainsKey(tmp.Name))
                {
                    //nie ma jeszcze takiej firmy
                    currentParentNode.Nodes.Add(tmp);
                }
                currentParentNode = currentParentNode.Nodes.Find(tmp.Name, false).First();


                //konkretna koszulka
                tmp = new TreeNode(t.ToString());
                tmp.Tag = t;
                tmp.NodeFont = new Font(treeViewProductBrowser.Font, FontStyle.Bold);

                currentParentNode.Nodes.Add(tmp);
            }


        }
        private void FillCompanyControl()
        {
            comboBoxCompany.Items.Clear();
            comboBoxCompany.Items.AddRange(getAllCompanies(this).ToArray());
        }

        private void FillStyleControl()
        {
            comboBoxModel.Items.Clear();
            comboBoxModel.Items.AddRange(getAllStyles(this).ToArray());
        }

        private void FillColorControl()
        {
            comboBoxColor.Items.Clear();
            comboBoxColor.Items.AddRange(getAllColors(this).ToArray());
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



        #endregion

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
    }
}
