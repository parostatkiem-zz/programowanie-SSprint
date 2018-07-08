using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace programowanie_SSprint
{
    public partial class CompanyEditor : Form,IErrorable, ICommunicative
    {
        public event Action<IErrorable, ICommunicative, company> insertCompany; //jesli company.id==null, to dodaje nowy company, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Action<IErrorable, ICommunicative> getAllCompanies; //zwraca listę wszystkich kolorów
        public event Action<IErrorable, ICommunicative, company> removeCompany; //usuwa kolor. Istotne jest tylko company.id. Zwraca bool czy się udało

       
 

        #region PUBLIC
        public void ShowError(string message, string longMessage = null, string title = null)
        {
            var ErrorWindow = new Views.HelperViews.Error(message, longMessage, title);
            ErrorWindow.ShowDialog();
        }

        public void PushNotification(string text, int type = 0)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                notificationPanel1.PushNotification(text, type);
            }));
          
        }

        public CompanyEditor()
        {
            InitializeComponent();
            currentlySelectedCompany = null;
            currentlyEditedCompany = new company();
        
        }
        public void ReturnListOfObjects(List<object> obj)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                _ReturnListOfObjects(obj);
            }));

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

        private Regex emailFieldRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        private Regex phoneFieldRegex = new Regex(@"^[0-9]*$");
        private void RefreshCompanyList()
        {
           getAllCompanies(this, this);
        }
        private void _ReturnListOfObjects(List<object> obj)
        {
            List<company> recievedCompanies = obj.OfType<company>().ToList();
            if (recievedCompanies != null)
            {
                DisplayCompanyList(recievedCompanies);
                return;
            }
        }
        private void DisplayCompanyList(List<company> theList)
        {
            lvCompanies.Items.Clear();
            ListViewItem item;
            foreach (var c in theList)
            {
                item = new ListViewItem(c.id.ToString());
                item.Tag = c;
                item.SubItems.Add(c.name);
                lvCompanies.Items.Add(item);
            }
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

        #region GENERATED_EVENTS
        private void CompanyEditor_Load(object sender, EventArgs e)
        {
            RefreshCompanyList();
        }
        private void lvCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCompanies.SelectedItems.Count <= 0 || lvCompanies.SelectedItems[0].Tag == null) return; //nic nie jest zaznaczone
            editMode = EditMode.Edit;
            CurrentlySelectedCompany = lvCompanies.SelectedItems[0].Tag as company;
        }
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text.Length <= 0)
            {
                errorProvider1.SetError(tbName, "Wartośc nie może byc pusta");
                return; }//error
            errorProvider1.SetError(tbName, "");
            currentlyEditedCompany.name = tbName.Text;
        }
        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
             if (!emailFieldRegex.IsMatch(tbEmail.Text) ){
                errorProvider1.SetError(tbEmail, "Wprowadź poprawny adres e-mail");
                return;
            }//error
            errorProvider1.SetError(tbEmail, "");
            currentlyEditedCompany.email = tbEmail.Text;
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (!phoneFieldRegex.IsMatch(tbPhone.Text))
            {
                errorProvider1.SetError(tbPhone, "Dozwolone są tylko cyfry");
                return;
            }//error
            errorProvider1.SetError(tbPhone, "");
            currentlyEditedCompany.phone = tbPhone.Text;
        }


        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBoxEditArea.Controls)
            {
                if (errorProvider1.GetError(c).Length > 0) return;
            }

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
            RefreshCompanyList();

        }

        #endregion

    }
}
