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

            view.getAllColors += View_getAllColors;
            view.insertColor += View_insertColor;
        }

        private bool View_insertColor(IErrorable arg1, color arg2)
        {
            throw new NotImplementedException();
            //TODO
        }

        private List<color> View_getAllColors(IErrorable senderWindow)
        {
            try
            {
                model.ConnectToBase();

                return model.getAllColors();
            }
            catch (Exception ex)
            {
                senderWindow.ShowError(ex.ToString());
                return null; //moze lepiej niech zwraca new List<color>()?
            }
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
