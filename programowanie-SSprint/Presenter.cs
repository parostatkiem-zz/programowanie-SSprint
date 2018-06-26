using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//todo : obgadać i dodać lepszą obsługę komunikatów przy zwracaniu wyjątku


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

            //kolory
            view.getAllColors += View_getAllColors; // 
            view.insertColor += View_insertColor; // zwrraca true jeśli uda się dodać/zmodyfikuje, false jeśli nie
            view.removeColor += View_removeColor; // zwraca true jeśli się usunie, false jeśli nie ma takiego koloru i wyjątek, jeśli wystąpi błąd

            
        }

        private bool View_removeColor(IErrorable senderWindow, color color)
        {
            color isInData = model.FindColor(color);
            if (isInData != null)
            {
                try
                {
                    model.RemoveColor(color);
                    return true;
                }
                catch(Exception ex)
                {
                    senderWindow.ShowError(ex.ToString());
                    return false;
                }
            }
            else
                return false;

        }
        private bool View_insertColor(IErrorable senderWindow, color color)
        {
            color isInData = model.FindColor(color);
            if (isInData != null)
                isInData = color;
            else
            {
                try
                {
                    model.AddColor(color);
                }
                catch(Exception ex)
                {
                    senderWindow.ShowError(ex.ToString());
                    return false;
                }
            }
            return true;
        }
        private List<color> View_getAllColors(IErrorable senderWindow)
        {
            try
            {
                model.ConnectToBase();

                return model.GetAllColors();
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

                return model.GetAllCompanies();
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

                return model.GetAllTshirts();
            }
            catch(Exception ex)
            {
                senderWindow.ShowError(ex.ToString());
                return null;
            }
            
        }


    }
}
