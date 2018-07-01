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
        public event Func<IErrorable, List<color>> getAllColors; //zwraca listę wszystkich kolorów
        public event Func<IErrorable, List<company>> getAllCompanies; //zwraca listę wszystkich firm


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

        }

        private void RefreshTshirtList(List<tshirt> theList)
        {
            treeViewProductBrowser.Nodes.Clear();
            TreeNode tmp;
            TreeNode currentParentNode;
            foreach(tshirt t in theList)
            {
                tmp = new TreeNode(t.company.name);
                if(!treeViewProductBrowser.Nodes.Contains(tmp))
                {
                    //nie ma jeszcze takiej firmy
                    treeViewProductBrowser.Nodes.Add(tmp);
                }
               
                currentParentNode = treeViewProductBrowser.Nodes.Find(tmp.Name, false).First();
            }
        }

        private void TshirtEditor_Load(object sender, EventArgs e)
        {
            RefreshTshirtList(getAllThsirts(this));
        }
    }
}
