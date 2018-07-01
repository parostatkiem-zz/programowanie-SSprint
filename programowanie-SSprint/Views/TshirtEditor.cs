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

        private tshirt currentlyEditedTshirt;
        private tshirt currentlySelectedTshirt;
        private tshirt CurrentlySelectedTshirt
        {
            get { return currentlySelectedTshirt; }
            set
            {
                currentlySelectedTshirt = value;
                DisplaySingleTshirt(currentlySelectedTshirt);
            }
        }

        private void DisplaySingleTshirt(tshirt t)
        {
            if(t==null)
            {
                //czyszczenie pól
                comboBoxCompany.SelectedItem = null;
                comboBoxColor.SelectedItem = null;
                comboBoxSize.SelectedItem = null;
                comboBoxCompany.SelectedItem = null;
                return;
            }

            foreach (var c in comboBoxCompany.Items)
                if ((c as company).id == t.company.id) comboBoxCompany.SelectedItem = c;

            foreach (var c in comboBoxModel.Items)
                if ((c as style).id == t.style.id) comboBoxModel.SelectedItem = c;

            foreach (var c in comboBoxSex.Items)
                if (c.ToString()==t.sex) comboBoxSex.SelectedItem = c;

            foreach (var c in comboBoxSize.Items)
                if (c.ToString() == t.size) comboBoxSize.SelectedItem = c;


            foreach (var c in comboBoxColor.Items)
                if ((c as color).id == t.color.id) comboBoxColor.SelectedItem = c;


            tbId.Text = t.id.ToString();
            numericDefaultLoss.Value = t.default_loss_percentage;
            numInStock.Value = t.in_stock;

        }

        private void RefreshTshirtList(List<tshirt> theList)
        {
            treeViewProductBrowser.Nodes.Clear();
            TreeNode tmp;
            TreeNode currentParentNode;

            
            foreach(tshirt t in theList)
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
                tmp= new TreeNode(t.color.name+" | "+t.size + " | "+t.in_stock.ToString());
                tmp.Tag = t;
                tmp.NodeFont = new Font(treeViewProductBrowser.Font, FontStyle.Bold);
                
                currentParentNode.Nodes.Add(tmp);
            }

           
        }

        private void TshirtEditor_Load(object sender, EventArgs e)
        {
            RefreshTshirtList(getAllThsirts(this));
            FillAllControls();
            CurrentlySelectedTshirt = null;
        }

        private void treeViewProductBrowser_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ((treeViewProductBrowser.SelectedNode.Tag as tshirt) == null) return;
            DisplaySingleTshirt(treeViewProductBrowser.SelectedNode.Tag as tshirt);
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
    }
}
