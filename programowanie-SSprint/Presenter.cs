using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint
{
    class Presenter
    {
        ImainView view;
        Model model;
        public Presenter(Model model, ImainView view)
        {
            this.view = view;
            this.model = model;
            view.getAllThsirts += View_getAllThsirts;
            view.getAllCompany += View_getAllCompany;
        }

        private List<company> View_getAllCompany(IErrorable senderWindow)
        {
            try
            {
                model.ConnectToBase();

                return model.getAllCompanies();
            }
            catch (Exception ex)
            {
                senderWindow.ShowError(ex.ToString());
                return null;
            }
        }

        private List<tshirt> View_getAllThsirts(IErrorable senderWindow)
        {
            try
            {
                model.ConnectToBase();

                return model.getAllTshirts();
            }
            catch(Exception ex)
            {
                senderWindow.ShowError(ex.ToString());
                return null;
            }
            
        }
    }
}
