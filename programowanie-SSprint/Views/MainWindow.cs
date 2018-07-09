using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace programowanie_SSprint
{
    public partial class MainWindow : Form, ImainView, IErrorable, ICommunicative
    {

        #region EVENTS
        public event Action<IErrorable, ICommunicative> getAllOrders;
        public event Action<IErrorable, ICommunicative, order> insertOrder;//jesli order.id==null, to dodaje nowy order, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Action<IErrorable, ICommunicative, order> removeOrder;
        public event Action<IErrorable, ICommunicative, List<singleItemOrder>> insertListOfItems;//wstawia listę zamówionych koszulek. MAją one ustawione order_id. UWAGA: czesc z nich moze juz istnieć w bazie, wtedy robi się UPDATE. Zwraca bool czy się udało
        public event Action<IErrorable, ICommunicative, List<singleItemOrder>> deleteListOfItems; //usuwa liste zamówionych koszulek


        public event Action<IErrorable, ICommunicative, color> insertColor; //jesli color.id==null, to dodaje nowy color, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Action<IErrorable, ICommunicative > getAllColors; //zwraca listę wszystkich kolorów
        public event Action<IErrorable, ICommunicative, color> removeColor; //usuwa kolor. Istotne jest tylko color.id. Zwraca bool czy się udało

        public event Action<IErrorable, ICommunicative, picture> insertPicture; //jesli color.id==null, to dodaje nowy obraz, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Action<IErrorable, ICommunicative> getAllPictures; //zwraca listę wszystkich obrazow
        public event Action<IErrorable, ICommunicative, picture> removePicture; //usuwa obraz. Istotne jest tylko picture.id. Zwraca bool czy się udało


        public event Action<IErrorable, ICommunicative, style> insertStyle; //jesli color.id==null, to dodaje nowy obraz, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Action<IErrorable, ICommunicative> getAllStyles; //zwraca listę wszystkich obrazow
        public event Action<IErrorable, ICommunicative, style> removeStyle; //usuwa obraz. Istotne jest tylko picture.id. Zwraca bool czy się udało


        public event Action<IErrorable, ICommunicative, company> insertCompany; //jesli company.id==null, to dodaje nowy company, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Action<IErrorable, ICommunicative> getAllCompanies; //zwraca listę wszystkich kolorów
        public event Action<IErrorable, ICommunicative, company> removeCompany; //usuwa kolor. Istotne jest tylko company.id. Zwraca bool czy się udało


        public event Action<IErrorable, ICommunicative, tshirt> insertTshirt; //jesli tshirt.id==null, to dodaje nowy tshirt, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Action<IErrorable, ICommunicative> getAllTshirts; //zwraca listę wszystkich tshirt
        public event Action<IErrorable, ICommunicative, tshirt> removeTshirt; //usuwa tshirt. Istotne jest tylko tshirt.id. Zwraca bool czy się udało

        #endregion

        #region PUBLIC

        public MainWindow()
        {
            InitializeComponent();
            colorEditorWindow = new ColorEditor();
            colorEditorWindow.getAllColors += _getAllColors;
            colorEditorWindow.insertColor += ColorEditorWindow_insertColor;
            colorEditorWindow.removeColor += ColorEditorWindow_removeColor;

            pictureEditorWindow = new PictureEditor();
            pictureEditorWindow.insertPicture += PictureEditorWindow_insertPicture;
            pictureEditorWindow.getAllPictures += PictureEditorWindow_getAllPictures;
            pictureEditorWindow.removePicture += PictureEditorWindow_removePicture;

            styleEditorWindow = new StyleEditor();
            styleEditorWindow.insertStyle += StyleEditorWindow_insertStyle;
            styleEditorWindow.getAllStyles += _getAllStyles;
            styleEditorWindow.removeStyle += StyleEditorWindow_removeStyle;

            companyEditorWindow = new CompanyEditor();
            companyEditorWindow.insertCompany += CompanyEditorWindow_insertCompany;
            companyEditorWindow.getAllCompanies += _getAllCompanies;
            companyEditorWindow.removeCompany += CompanyEditorWindow_removeCompany;

            tshirtEditorWindow = new TshirtEditor();
            tshirtEditorWindow.getAllThsirts += TshirtEditorWindow_getAllThsirts;
            tshirtEditorWindow.getAllCompanies += _getAllCompanies;
            tshirtEditorWindow.getAllColors += _getAllColors;
            tshirtEditorWindow.getAllStyles += _getAllStyles;
            tshirtEditorWindow.insertSingleTshirt += TshirtEditorWindow_insertSingleTshirt;
            tshirtEditorWindow.removeTshirt += TshirtEditorWindow_removeTshirt;

            aboutWindow = new AboutWindow();


            currentListOfItems = new List<singleItemOrder>();

            treeViewProductBrowser.Nodes.Clear();

        }
        public void ReturnListOfObjects(List<object> obj)
        {
            BeginInvoke(new MethodInvoker(delegate { _ReturnListOfObjects(obj); }));
        }

        private void _ReturnListOfObjects(List<object> obj)
        {
            List<order> recievedOrders = obj.OfType<order>().ToList();
            if (recievedOrders != null && recievedOrders.Count>0)
            {
                DisplayOrderList(recievedOrders);
                return;
            }

            List<tshirt> recievedTshirts = obj.OfType<tshirt>().ToList();
            if (recievedTshirts != null && recievedTshirts.Count > 0)
            {
                localTshirtList = recievedTshirts;
                VisualHelper.RefreshTshirtList(treeViewProductBrowser, localTshirtList);
                return;
            }

        }
        public void PushNotification(string text, int type = 0)
        {
            BeginInvoke(new MethodInvoker(delegate { notificationPanel1.PushNotification(text, type); }));
            
        }

        public void ShowError(string message, string longMessage = null, string title = null)
        {
            var ErrorWindow = new Views.HelperViews.Error(message, longMessage, title);
            ErrorWindow.ShowDialog();
        }

        #endregion

        #region CHILD_EVENT_METHODS
        private void TshirtEditorWindow_removeTshirt(IErrorable arg1, ICommunicative arg3, tshirt arg2)
        {
             removeTshirt(arg1, arg3, arg2);
        }

        private void TshirtEditorWindow_insertSingleTshirt(IErrorable arg1, ICommunicative arg3, tshirt arg2)
        {
             insertTshirt(arg1, arg3, arg2);
        }

        private void TshirtEditorWindow_getAllThsirts(IErrorable arg, ICommunicative arg1)
        {
             getAllTshirts(arg, arg1);
        }

        private void CompanyEditorWindow_removeCompany(IErrorable arg1, ICommunicative arg3, company arg2)
        {
             removeCompany(arg1, arg3, arg2);
        }

        private void _getAllCompanies(IErrorable arg, ICommunicative arg1)
        {
             getAllCompanies(arg, arg1);
        }

        private void CompanyEditorWindow_insertCompany(IErrorable arg1, ICommunicative arg3, company arg2)
        {
             insertCompany(arg1, arg3, arg2);
        }

        private void ColorEditorWindow_removeColor(IErrorable arg1, ICommunicative arg3, color arg2)
        {
             removeColor(arg1, arg3, arg2);
        }

        private void ColorEditorWindow_insertColor(IErrorable arg1, ICommunicative arg3, color arg2)
        {
             insertColor(arg1, arg3, arg2);
        }

        private void _getAllColors(IErrorable arg, ICommunicative arg1)
        {
             getAllColors(arg, arg1);
        }

        private void PictureEditorWindow_insertPicture(IErrorable arg1, ICommunicative arg3, picture arg2)
        {
             insertPicture(arg1, arg3, arg2);
        }
        private void PictureEditorWindow_getAllPictures(IErrorable arg, ICommunicative arg1)
        {
             getAllPictures(arg, arg1);
        }
        private void PictureEditorWindow_removePicture(IErrorable arg1, ICommunicative arg3, picture arg2)
        {
             removePicture(arg1, arg3, arg2);
        }

        private void StyleEditorWindow_removeStyle(IErrorable arg1, ICommunicative arg3, style arg2)
        {
             removeStyle(arg1, arg3, arg2);
        }

        private void _getAllStyles(IErrorable arg, ICommunicative arg1)
        {
             getAllStyles(arg, arg1);
        }

        private void StyleEditorWindow_insertStyle(IErrorable arg1, ICommunicative arg3, style arg2)
        {
             insertStyle(arg1, arg3, arg2);
        }
        #endregion



        #region PRIVATE_VARIABLES_PROPERTIES
        private ColorEditor colorEditorWindow;
        private PictureEditor pictureEditorWindow;
        private StyleEditor styleEditorWindow;
        private CompanyEditor companyEditorWindow;

        private TshirtEditor tshirtEditorWindow;
        private AboutWindow aboutWindow;

        private order currentlySelectedOrder;
        private order currentlyEditedOrder;

        private Regex emailFieldRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        private Regex phoneFieldRegex = new Regex(@"^[0-9]*$");


        private List<tshirt> localTshirtList;
        private tshirt currentlySelectedTshirt;
        private tshirt CurrentlySelectedTshirt
        {
            get { return currentlySelectedTshirt; }
            set
            {
                currentlySelectedTshirt = value;
                if (value == null)
                {
                    lSelectedTshirtName.Text = "";
                    btnAddProductToOrder.Visible = false;
                    numericAddingProductAmount.Visible = false;
                }
                else
                {
                    lSelectedTshirtName.Text = value.ToString();
                    btnAddProductToOrder.Visible = true;
                    numericAddingProductAmount.Visible = true;
                    numericAddingProductAmount.Value = 1;
                    numericAddingProductAmount.Maximum = value.getNotOrdered();
                }

            }
        }

        private List<singleItemOrder> currentListOfItems;

        private order CurrentlySelectedOrder
        {
            get { return currentlySelectedOrder; }
            set
            {

                currentlySelectedOrder = value;
                if (value == null)
                {
                    splitContainerHorizLeft.Visible = false;
                    gbSelectedOrderParams.Visible = false;
                    return;
                }
                currentlyEditedOrder = value;

                splitContainerHorizLeft.Visible = true;
                gbSelectedOrderParams.Visible = true;

                currentListOfItems.Clear();
                currentListOfItems.AddRange(value.singleItemOrders.ToArray());

                DisplaySingleOrder(currentlyEditedOrder);
                RefreshOrderItemList(currentListOfItems);

            }
        }
        #endregion

        #region PRIVATE_METHODS
        private void ApplySelectedPicture(picture p)
        {
            if (currentlyEditedOrder == null) return;

          
            if (p == null)
            {
                btnSelectedOrderBrowseImage.Text = "Wybierz obrazek";
                btnSelectedOrderBrowseImage.Font = new System.Drawing.Font(DefaultFont, System.Drawing.FontStyle.Regular);
                currentlyEditedOrder.picture_id = null;
            }
               
            else
            {
                btnSelectedOrderBrowseImage.Text = p.name;
                currentlyEditedOrder.picture_id = p.id;
                btnSelectedOrderBrowseImage.Font = new System.Drawing.Font(DefaultFont, System.Drawing.FontStyle.Bold);
            }
           
        }
        private void DisplayOrderList(List<order> theList)
        {
            lvAllOrders.Items.Clear();
            ListViewItem item;

            foreach (order o in theList)
            {
                item = new ListViewItem(o.id.ToString());
                item.Tag = o;
                item.SubItems.AddRange(new string[] {
                    o.SingleItemOrderTypesCount.ToString(),
                    o.SingleItemOrderCount.ToString(),
                    o.end_date.ToString(),
                    o.client_name,
                    o.price_for_client.ToString(),
                    o.singleItemOrders.Sum(i=>i.TotalCost).ToString(),
                    o.Profit.ToString()
                });
                lvAllOrders.Items.Add(item);
            }
        }
      
        private void DisplaySingleOrder(order o)
        {
            if (o == null)
            {
                tbSelectedOrderName.Text = "";
                tbSelectedOrderEmail.Text = "";
                tbSelectedOrderPhone.Text = "";
                dateTimeBegin.Value = DateTime.Today;
                dateTimeEnd.Value = DateTime.Today;
                comboBoxSelectedOrderStatus.SelectedIndex = 0;
                numClientPrice.Value = 0;
                return;
            }
            tbSelectedOrderName.Text = o.client_name;
            tbSelectedOrderEmail.Text = o.client_email;
            tbSelectedOrderPhone.Text = o.client_phone;
            try { dateTimeBegin.Value = o.order_date; }
            catch { }
            comboBoxSelectedOrderStatus.SelectedIndex = o.status;
            numClientPrice.Value = o.price_for_client;
            ApplySelectedPicture(o.picture);

        }

        private void DeleteProperOrderItems(List<singleItemOrder> old, List<singleItemOrder> updated)
        {
            List<singleItemOrder> ordersToDelete = new List<singleItemOrder>();
            foreach (singleItemOrder i in old)
            {
                if (updated.Find(o => o.id == i.id) == null)
                    ordersToDelete.Add(i);
            }
            deleteListOfItems(this, this, ordersToDelete);
        }

        private void RefreshOrderItemList(List<singleItemOrder> theList)
        {
            try
            {
                if (localTshirtList == null) return;
                lvOrderedProducts.Items.Clear();
                if (theList == null) return;

                ListViewItem item;
                tshirt currentTshirt;
                int reserved_amount;
                foreach (singleItemOrder o_item in theList)
                {
                    currentTshirt = localTshirtList?.Find(t => t.id == o_item.tshirt_id);
                    if (currentTshirt == null) currentTshirt = new tshirt();
                    decimal a = ((decimal)currentTshirt.default_loss_percentage / 100);
                    reserved_amount = (int)Math.Ceiling((decimal)(a * o_item.amount) + o_item.amount);
                    item = new ListViewItem(currentTshirt.company.name);
                    item.Tag = o_item;
                    item.SubItems.AddRange(new string[] { currentTshirt.style.name, currentTshirt.sex, currentTshirt.color.name, o_item.amount.ToString(), reserved_amount.ToString() });
                    item.ToolTipText = "Kliknij mnie dwukrotnie, by usunąć z listy";
                    lvOrderedProducts.Items.Add(item);
                }
            }
            catch { lvOrderedProducts.Items.Clear(); this.PushNotification("Nie udało się wyświetlić listy produktów", 2); }
        }


        #endregion

        #region GENERATED_EVENTS
        #region TOP_MENU
        private void tshirtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
            // event odpowiadający za dodawanie/usuwanie/edytowanie stanu magazynowego koszulek
            tshirtEditorWindow.ShowDialog();

        }

        private void companiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
            // event odpowiadający za dodawanie/usuwanie/edytowanie firm
            //
            companyEditorWindow.ShowDialog();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
            // event odpowiadający za dodawanie/usuwanie/edytowanie kolorów
            //

            colorEditorWindow.ShowDialog();
        }

        private void stylesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
            // event odpowiadający za dodawanie/usuwanie/edytowanie styli
            //

            styleEditorWindow.ShowDialog();
        }

        private void getDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
            // event odpowiadający za odświeżanie danych bazowych
            //
        }
        private void btnCurrentOrderBrowseImage_Click(object sender, EventArgs e)
        {
            pictureEditorWindow.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutWindow.ShowDialog();
        }
        #endregion

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            PushNotification("Trwa pobieranie danych w tle",1);
            CurrentlySelectedOrder = null;
            getAllOrders(this, this);
            getAllTshirts(this, this);
          
            CurrentlySelectedTshirt = null;
        }
        private void btnSelectedOrderBrowseImage_Click(object sender, EventArgs e)
        {
            pictureEditorWindow.ShowDialog();
            ApplySelectedPicture(pictureEditorWindow.SelectedPicture);

        }


        private void lvAllOrders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvAllOrders.SelectedItems.Count <= 0 || (lvAllOrders.SelectedItems[0].Tag as order) == null) return;
            CurrentlySelectedOrder = lvAllOrders.SelectedItems[0].Tag as order;
        }

        private void btnSelectedOrderDelete_Click(object sender, EventArgs e)
        {
            if (CurrentlySelectedOrder == null) return;
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz nieodwracalnie usunąć wybrane zamówienie (" + CurrentlySelectedOrder.ToString() + ")?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            removeOrder(this, this, CurrentlySelectedOrder);
            getAllOrders(this, this);
        }

        private void btnCurrentOrderCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz odrzucić wprowadzone zmiany?", "Potwierdzenie odrzucenia zmian", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            DisplaySingleOrder(CurrentlySelectedOrder);
            btnAddNew.Visible = true;
            btnDelete.Visible = true;
            lvAllOrders.Visible = true;
            gbSelectedOrderParams.Visible = false;

            CurrentlySelectedOrder = null;
            //currentlyEditedOrder = null;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            lvAllOrders.Visible = false;
            CurrentlySelectedOrder = null;
            currentlyEditedOrder = new order();
            currentlyEditedOrder.singleItemOrders = new List<singleItemOrder>();
            currentlyEditedOrder.end_date = DateTime.Today;
            currentlyEditedOrder.order_date = DateTime.Today;
            DisplaySingleOrder(currentlyEditedOrder);


            gbSelectedOrderParams.Visible = true;
            btnAddNew.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnSelectedOrderSave_Click(object sender, EventArgs e)
        {
          
            if (currentlyEditedOrder == null)
            {
                ShowError("Wygląda na to, że nie edytujesz obiecnie żadnego zamówienia");
                return;
            }
            foreach (Control c in gbSelectedOrderData.Controls)
            {
                if (errorProvider1.GetError(c).Length > 0) return;
            }

            foreach (Control c in gbSelectedOrderParams.Controls)
            {
                if (errorProvider1.GetError(c).Length > 0) return;
            }

            insertOrder(this, this, currentlyEditedOrder);
            insertListOfItems(this, this, currentListOfItems);
            DeleteProperOrderItems(currentlyEditedOrder.singleItemOrders.ToList(), currentListOfItems);
            if (!lvAllOrders.Visible)
            {

                lvAllOrders.Visible = true;

            }
            btnAddNew.Visible = true;
            btnDelete.Visible = true;
            gbSelectedOrderParams.Visible = false;
            getAllOrders(this, this);
            getAllTshirts(this, this);

        }

        private void tbSelectedOrderName_TextChanged(object sender, EventArgs e)
        {
            if(tbSelectedOrderName.Text.Length<=0)
            {
                errorProvider1.SetError(tbSelectedOrderName, "Wartośc tego pola nie może być pusta");
                return;
            }
            errorProvider1.SetError(tbSelectedOrderName, "");
            currentlyEditedOrder.client_name = tbSelectedOrderName.Text;
        }

        private void tbSelectedOrderEmail_TextChanged(object sender, EventArgs e)
        {
            if(tbSelectedOrderEmail.Text.Length > 0 && !emailFieldRegex.IsMatch(tbSelectedOrderEmail.Text))
            {
                errorProvider1.SetError(tbSelectedOrderEmail, "To nie wygląda jak e-mail...");
                return;
            }
            errorProvider1.SetError(tbSelectedOrderEmail, "");

            currentlyEditedOrder.client_email = tbSelectedOrderEmail.Text;
        }

        private void tbSelectedOrderPhone_TextChanged(object sender, EventArgs e)
        {
            if (tbSelectedOrderPhone.Text.Length>0 && !phoneFieldRegex.IsMatch(tbSelectedOrderPhone.Text))
            {
                errorProvider1.SetError(tbSelectedOrderPhone, "Dozwolone tylko cyfry");
                return;
            }
            errorProvider1.SetError(tbSelectedOrderPhone, "");

            currentlyEditedOrder.client_phone = tbSelectedOrderPhone.Text;
        }

        private void dateTimeEnd_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimeEnd.Value<currentlyEditedOrder.order_date)
            {
                errorProvider1.SetError(dateTimeEnd, "Niby jak chcesz zakończyć zlecenie przed jego rozpoczęciem? :)");
                return;
            }
            errorProvider1.SetError(dateTimeEnd, "");
            currentlyEditedOrder.end_date = dateTimeEnd.Value;
        }

        private void comboBoxSelectedOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentlyEditedOrder.status = comboBoxSelectedOrderStatus.SelectedIndex;
        }

        private void numClientPrice_ValueChanged(object sender, EventArgs e)
        {
            currentlyEditedOrder.price_for_client = (int)numClientPrice.Value;
        }

        private void treeViewProductBrowser_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewProductBrowser.SelectedNode.Tag as tshirt == null) return;
            CurrentlySelectedTshirt = treeViewProductBrowser.SelectedNode.Tag as tshirt;
        }

        private void btnAddProductToOrder_Click(object sender, EventArgs e)
        {
            singleItemOrder item = new singleItemOrder();
            item.order_id = currentlyEditedOrder.id;
            item.tshirt_id = CurrentlySelectedTshirt.id;
            item.amount = (int)numericAddingProductAmount.Value;
            currentListOfItems.Add(item);
            RefreshOrderItemList(currentListOfItems);
        }

        private void lvOrderedProducts_DoubleClick(object sender, EventArgs e)
        {
            var clickedItem = lvOrderedProducts.SelectedItems[0].Tag as singleItemOrder;
            if (clickedItem == null) return;
            currentListOfItems.Remove(clickedItem);
            RefreshOrderItemList(currentListOfItems);

        }

        #endregion

        
    }
}
