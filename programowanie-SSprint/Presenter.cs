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

        //lock
        object mainThreadLock = new object();

        public Presenter(Model model, ImainView view)
        {
            this.view = view;
            this.model = model;

            //view.insertTshirt += View_insertTshirt;
            view.getAllThsirts += View_getAllThsirts;
            
            // poj. zamówienia
            view.getSingleOrder += View_getSingleOrder;

            view.insertSingleOrder += View_insertSingleOrder;
            view.insertListOfItems += View_insertListOfItems;

            // kolory
            view.insertColor += View_insertColor; 
            view.getAllColors += View_getAllColors;
            view.removeColor += View_removeColor;

            // obrazki
            view.insertPicture += View_insertPicture;
            view.getAllPictures += View_getAllPictures;
            view.removePicture += View_removePicture;

            //style
            view.insertStyle += View_insertStyle;
            view.getAllStyles += View_getAllStyles;
            view.removeStyle += View_removeStyle;

            // firmy
            view.insertCompany += View_insertCompany;
            view.getAllCompanies += View_getAllCompanies;
            view.removeCompany += View_removeCompany;
        }

        private bool View_insertTshirt(IErrorable windowInterface, tshirt newOrder)
        {
            try
            {
                model.InsertElement<tshirt>(new Communicator.TshirtCommunicator(), newOrder);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }

        private bool View_removeCompany(IErrorable windowInterface, company orderToRemove)
        {
            try
            {
                model.RemoveElement<company>(new Communicator.CompanyCommunicator(), orderToRemove);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }
        private List<company> View_getAllCompanies(IErrorable windowInterface)
        {
            try
            {
                return model.GetAllElements<company>(new Communicator.CompanyCommunicator());
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return null;
            }
        }
        private bool View_insertCompany(IErrorable windowInterface, company newOrder)
        {
            try
            {
                model.InsertElement<company>(new Communicator.CompanyCommunicator(), newOrder);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }

        private bool View_removeStyle(IErrorable windowInterface, style orderToRemove)
        {
            try
            {
                model.RemoveElement<style>(new Communicator.StyleCommunicator(), orderToRemove);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }
        private List<style> View_getAllStyles(IErrorable windowInterface)
        {
            try
            {
                return model.GetAllElements<style>(new Communicator.StyleCommunicator());
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return null;
            }
        }
        private bool View_insertStyle(IErrorable windowInterface, style newOrder)
        {
            try
            {
                model.InsertElement<style>(new Communicator.StyleCommunicator(), newOrder);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }

        private bool View_removePicture(IErrorable windowInterface, picture orderToRemove)
        {
            try
            {
                model.RemoveElement<picture>(new Communicator.PictureCommunicator(), orderToRemove);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }
        private List<picture> View_getAllPictures(IErrorable windowInterface)
        {
            try
            {
                return model.GetAllElements<picture>(new Communicator.PictureCommunicator());
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return null;
            }
        }
        private bool View_insertPicture(IErrorable windowInterface, picture newOrder)
        {
            try
            {
                model.InsertElement<picture>(new Communicator.PictureCommunicator(), newOrder);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }

        private bool View_removeColor(IErrorable windowInterface, color orderToRemove)
        {
            try
            {
                model.RemoveElement<color>(new Communicator.ColorCommunicator(), orderToRemove);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }
        private List<color> View_getAllColors(IErrorable windowInterface)
        {
            try
            {
                return model.GetAllElements<color>(new Communicator.ColorCommunicator());
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return null;
            }
        }
        private bool View_insertColor(IErrorable windowInterface, color newOrder)
        {
            try
            {
                model.InsertElement<color>(new Communicator.ColorCommunicator(), newOrder);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }

        private bool View_insertListOfItems(IErrorable windowInterface, List<singleItemOrder> newOrders)
        {
            try
            {
                model.InsertListOfElements<singleItemOrder>(new Communicator.singleOrderCommunicator(), newOrders);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }
        private bool View_insertSingleOrder(IErrorable windowInterface, order newOrder)
        {
            try
            {
                model.InsertElement<order>(new Communicator.OrderCommunicator(), newOrder);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }

        private order View_getSingleOrder(IErrorable windowInterface, int itemID)
        {
            try
            {
                List<order> toReturn = model.GetAllElements<order>(new Communicator.OrderCommunicator());
                return toReturn.FirstOrDefault(e => e.id == itemID);
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return null;
            }
        }
        private List<tshirt> View_getAllThsirts(IErrorable windowInterface)
        {
            try
            {
                return model.GetAllElements<tshirt>(new Communicator.TshirtCommunicator());
            }
            catch(Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return null;
            }
        }
    }
}
