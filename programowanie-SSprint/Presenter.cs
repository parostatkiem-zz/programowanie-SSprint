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
            view.getAllThsirts += View_getAllThsirts;
        }

        private List<DB_classes.Tshirt> View_getAllThsirts(IErrorable senderWindow)
        {
            throw new NotImplementedException();

            /*
             try{ return model.GetAllTshirts();}
             catch(Exception ex)
             { 
                senderWindow.ShowError("Nie udało się pobrać listy koszulek",ex.ToString()); 
                return new List<DB_classes.Tshirt>();
             }
             */
        }
    }
}
