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
    public partial class CompanyEditor : Form,IErrorable, ICommunicative
    {
        public event Func<IErrorable, ICommunicative, company, bool> insertCompany; //jesli company.id==null, to dodaje nowy company, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, ICommunicative, List<company>> getAllCompanies; //zwraca listę wszystkich kolorów
        public event Func<IErrorable, ICommunicative, company, bool> removeCompany; //usuwa kolor. Istotne jest tylko company.id. Zwraca bool czy się udało



        #region PUBLIC
        public void ShowError(string message, string longMessage = null, string title = null)
        {
            var ErrorWindow = new Views.HelperViews.Error(message, longMessage, title);
            ErrorWindow.ShowDialog();
        }


        public CompanyEditor()
        {
            InitializeComponent();
            currentlySelectedCompany = null;
            currentlyEditedCompany = new company();
        }
        #endregion
        private company currentlyEditedCompany;
        private company currentlySelectedCompany;
        private EditMode editMode;
        private company CurrentlySelectedCompany
        {
            get { return currentlySelectedCompany; }
            set
            {
                currentlySelectedCompany = value;
                displaySingleCompany(currentlySelectedCompany);
            }
        }

        private void CompanyEditor_Load(object sender, EventArgs e)
        {
            RefreshCompanyList();
        }

        private void RefreshCompanyList()
        {
            lvCompanies.Items.Clear();

            List<company> recievedCompanies = getAllCompanies(this, this);

            ListViewItem item;
            foreach (var c in recievedCompanies)
            {
                item = new ListViewItem(c.id.ToString());
                item.Tag = c;
                item.SubItems.Add(c.name);
                lvCompanies.Items.Add(item);
            }
        }

        private void lvCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCompanies.SelectedItems.Count <= 0 || lvCompanies.SelectedItems[0].Tag == null) return; //nic nie jest zaznaczone
            editMode = EditMode.Edit;
            CurrentlySelectedCompany = lvCompanies.SelectedItems[0].Tag as company;
        }

        private void displaySingleCompany(company c)
        {
            if (editMode != EditMode.AddNew)
                currentlyEditedCompany = c;
            if (c != null)
            {
                tbName.Text = c.name;
                tbEmail.Text = c.email;
                tbPhone.Text = c.phone;
                tbID.Text = c.id.ToString();
            }
            else
            {
                //wyswietlanie pustego koloru
                tbName.Text = "";
                tbEmail.Text = "";
                tbPhone.Text = "";

                tbID.Text = "";
            }
            return;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text.Length <= 0) { return; }//error

            currentlyEditedCompany.name = tbName.Text;
        }
        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
           // if (tbEmail.Text.Length <= 0) { return; }//error

            currentlyEditedCompany.email = tbEmail.Text;
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            currentlyEditedCompany.phone = tbPhone.Text;
        }


        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            //sprawdzanie poprawnosci
            if (currentlyEditedCompany == null) return;
            insertCompany(this, this, currentlyEditedCompany);
            groupBoxCompanyList.Visible = true;
            RefreshCompanyList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //wypada dać potwierdzenie
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz odrzucić wprowadzone zmiany?", "Potwierdzenie odrzucenia zmian", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            groupBoxCompanyList.Visible = true;
            currentlyEditedCompany = null;
            CurrentlySelectedCompany = CurrentlySelectedCompany; //odswiezenie

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            editMode = EditMode.AddNew;
            CurrentlySelectedCompany = null;
            currentlyEditedCompany = new company();
            groupBoxCompanyList.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CurrentlySelectedCompany == null)
            {
                ShowError("Wygląda na to, że żadna firma nie jest zaznaczona");
                return;
            }

            removeCompany(this, this, CurrentlySelectedCompany);
        }

      
    }
}
