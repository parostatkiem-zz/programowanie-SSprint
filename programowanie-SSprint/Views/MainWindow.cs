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
    public partial class MainWindow : Form, ImainView, IErrorable
    {

        #region EVENTS
        public event Action saveDatabaseToRemote; //zapisuje dane do bazy zdalnej

       // public event Func<IErrorable, List<company>> getAllCompany;

        //public event Func<IErrorable, List<tshirt>> getAllThsirts; //pobiera wszystkie dane z tabeli Tshirts
        public event Func<IErrorable, int, order> getSingleOrder; //pobiera jeden order o danym ID

        public event Func<IErrorable, order, bool> insertSingleOrder;//jesli order.id==null, to dodaje nowy order, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<singleItemOrder>,bool> insertListOfItems;//wstawia listę zamówionych koszulek. MAją one ustawione order_id. Zwraca bool czy się udało

        public event Func<IErrorable, color, bool> insertColor; //jesli color.id==null, to dodaje nowy color, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<color>> getAllColors; //zwraca listę wszystkich kolorów
        public event Func<IErrorable, color, bool> removeColor; //usuwa kolor. Istotne jest tylko color.id. Zwraca bool czy się udało

        public event Func<IErrorable, picture, bool> insertPicture; //jesli color.id==null, to dodaje nowy obraz, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<picture>> getAllPictures; //zwraca listę wszystkich obrazow
        public event Func<IErrorable, picture, bool> removePicture; //usuwa obraz. Istotne jest tylko picture.id. Zwraca bool czy się udało


        public event Func<IErrorable, style, bool> insertStyle; //jesli color.id==null, to dodaje nowy obraz, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<style>> getAllStyles; //zwraca listę wszystkich obrazow
        public event Func<IErrorable, style, bool> removeStyle; //usuwa obraz. Istotne jest tylko picture.id. Zwraca bool czy się udało


        public event Func<IErrorable, company, bool> insertCompany; //jesli company.id==null, to dodaje nowy company, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<company>> getAllCompanies; //zwraca listę wszystkich kolorów
        public event Func<IErrorable, company, bool> removeCompany; //usuwa kolor. Istotne jest tylko company.id. Zwraca bool czy się udało


        public event Func<IErrorable, tshirt, bool> insertTshirt; //jesli tshirt.id==null, to dodaje nowy tshirt, jeśli !=null to aktualizuje istniejący. Zwraca bool czy się udało
        public event Func<IErrorable, List<tshirt>> getAllTshirts; //zwraca listę wszystkich tshirt
        public event Func<IErrorable, tshirt, bool> removeTshirt; //usuwa tshirt. Istotne jest tylko tshirt.id. Zwraca bool czy się udało


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


        }

        private bool TshirtEditorWindow_removeTshirt(IErrorable arg1, tshirt arg2)
        {
            return removeTshirt(arg1, arg2);
        }

        private bool TshirtEditorWindow_insertSingleTshirt(IErrorable arg1, tshirt arg2)
        {
            return insertTshirt(arg1, arg2);
        }

        private List<tshirt> TshirtEditorWindow_getAllThsirts(IErrorable arg)
        {
            return getAllTshirts(arg);
        }

        private bool CompanyEditorWindow_removeCompany(IErrorable arg1, company arg2)
        {
            return removeCompany(arg1, arg2);
        }

        private List<company> _getAllCompanies(IErrorable arg)
        {
            return getAllCompanies(arg);
        }

        private bool CompanyEditorWindow_insertCompany(IErrorable arg1, company arg2)
        {
            return insertCompany(arg1, arg2);
        }

        public void ShowError(string message, string longMessage = null, string title = null)
        {
            var ErrorWindow = new Views.HelperViews.Error(message, longMessage, title);
            ErrorWindow.ShowDialog();
        }

        #endregion

        #region CHILD_EVENT_METHODS
        private void FireSaveDatabaseToRemoteEvent()
        {
            //saveDatabaseToRemote();
        }
        private bool ColorEditorWindow_removeColor(IErrorable arg1, color arg2)
        {
            return removeColor(arg1, arg2);
        }

        private bool ColorEditorWindow_insertColor(IErrorable arg1, color arg2)
        {
            return insertColor(arg1, arg2);
        }

        private List<color> _getAllColors(IErrorable arg)
        {
            return getAllColors(arg);
        }

        private bool PictureEditorWindow_insertPicture(IErrorable arg1, picture arg2)
        {
            return insertPicture(arg1, arg2);
        }
        private List<picture> PictureEditorWindow_getAllPictures(IErrorable arg)
        {
            return getAllPictures(arg);
        }
        private bool PictureEditorWindow_removePicture(IErrorable arg1, picture arg2)
        {
            return removePicture(arg1, arg2);
        }

        private bool StyleEditorWindow_removeStyle(IErrorable arg1, style arg2)
        {
            return removeStyle(arg1, arg2);
        }

        private List<style> _getAllStyles(IErrorable arg)
        {
            return getAllStyles(arg);
        }

        private bool StyleEditorWindow_insertStyle(IErrorable arg1, style arg2)
        {
            return insertStyle(arg1, arg2);
        }
        #endregion
        #region GENERATED_EVENTS
        private void MainWindow_Load(object sender, EventArgs e)
        {
     
           // colorEditorWindow.ShowDialog();
        }
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
   
    #endregion
    #region PRIVATE_VARIABLES_PROPERTIES
    private ColorEditor colorEditorWindow;
        private PictureEditor pictureEditorWindow;
        private StyleEditor styleEditorWindow;
        private CompanyEditor companyEditorWindow;

        private TshirtEditor tshirtEditorWindow;
        // private 
        #endregion

        #region PRIVATE_METHODS
        #endregion

    }
}
