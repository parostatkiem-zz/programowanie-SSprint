using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace programowanie_SSprint
{
    public partial class MainWindow : Form, ImainView, IErrorable
    {

        #region EVENTS
        public event Func<IErrorable, List<company>> getAllCompany;

        public event Func<IErrorable, List<tshirt>> getAllThsirts; //pobiera wszystkie dane z tabeli Tshirts
        public event Func<IErrorable, int, order> getSingleOrder; //pobiera jeden order o danym ID

        public event Func<IErrorable, order, bool> insertSingleOrder;//jesli order.id==null, to dodaje nowy order, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<singleItemOrder>,bool> insertListOfItems;//wstawia listę zamówionych koszulek. MAją one ustawione order_id. Zwraca bool czy się udało

        public event Func<IErrorable, color, bool> insertColor; //jesli color.id==null, to dodaje nowy color, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<color>> getAllColors; //zwraca listę wszystkich kolorów
        public event Func<IErrorable, color, bool> removeColor; //usuwa kolor. Istotne jest tylko color.id. Zwraca bool czy się udało


        #endregion

        #region PUBLIC

        public MainWindow()
        {
            InitializeComponent();
            colorEditorWindow = new ColorEditor();
            colorEditorWindow.getAllColors += ColorEditorWindow_getAllColors;
            colorEditorWindow.insertColor += ColorEditorWindow_insertColor;
        }

        private bool ColorEditorWindow_insertColor(IErrorable arg1, color arg2)
        {
            return insertColor(arg1, arg2);
        }

        private List<color> ColorEditorWindow_getAllColors(IErrorable arg)
        {
            return getAllColors(arg);
        }

        public void ShowError(string message, string longMessage = null, string title = null)
        {
            var ErrorWindow = new Views.HelperViews.Error(message, longMessage, title);
            ErrorWindow.ShowDialog();
        }

        #endregion
        #region GENERATED_EVENTS
        private void MainWindow_Load(object sender, EventArgs e)
        {
     
           // colorEditorWindow.ShowDialog();
        }
        #endregion
        #region PRIVATE_VARIABLES_PROPERTIES
        private ColorEditor colorEditorWindow;
        #endregion
        #region PRIVATE_METHODS
        #endregion


    }
}
