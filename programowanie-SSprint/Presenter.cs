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
            //view.getAllThsirts += View_getAllThsirts;
            
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

            // koszulki
            view.insertTshirt += View_insertTshirt;
            view.getAllTshirts += View_getAllTshirts;
            view.removeTshirt += View_removeTshirt;
        }

        private bool View_removeTshirt(IErrorable windowInterface, tshirt itemToRemove)
        {
            try
            {
                model.RemoveElement<tshirt>(new Communicator.TshirtCommunicator(), itemToRemove);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.Message);
                return false;
            }
        }
        private List<tshirt> View_getAllTshirts(IErrorable windowInterface)
        {
            try
            {
                return model.GetAllElements<tshirt>(new Communicator.TshirtCommunicator());
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return null;
            }
        }
        private bool View_insertTshirt(IErrorable windowInterface, tshirt newItem)
        {
            try
            {
                model.InsertElement<tshirt>(new Communicator.TshirtCommunicator(), newItem);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }

        private bool View_removeCompany(IErrorable windowInterface, company itemToRemove)
        {
            try
            {
                model.RemoveElement<company>(new Communicator.CompanyCommunicator(), itemToRemove);
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
        private bool View_insertCompany(IErrorable windowInterface, company newItem)
        {
            try
            {
                model.InsertElement<company>(new Communicator.CompanyCommunicator(), newItem);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }

        private bool View_removeStyle(IErrorable windowInterface, style itemToRemove)
        {
            try
            {
                model.RemoveElement<style>(new Communicator.StyleCommunicator(), itemToRemove);
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
        private bool View_insertStyle(IErrorable windowInterface, style newItem)
        {
            try
            {
                model.InsertElement<style>(new Communicator.StyleCommunicator(), newItem);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }

        private bool View_removePicture(IErrorable windowInterface, picture itemToRemove)
        {
            try
            {
                model.RemoveElement<picture>(new Communicator.PictureCommunicator(), itemToRemove);
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
        private bool View_insertPicture(IErrorable windowInterface, picture newItem)
        {
            try
            {
                model.InsertElement<picture>(new Communicator.PictureCommunicator(), newItem);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }

        private bool View_removeColor(IErrorable windowInterface, color itemToRemove)
        {
            try
            {
                model.RemoveElement<color>(new Communicator.ColorCommunicator(), itemToRemove);
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
        private bool View_insertColor(IErrorable windowInterface, color newItem)
        {
            try
            {
                model.InsertElement<color>(new Communicator.ColorCommunicator(), newItem);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }

        private bool View_insertListOfItems(IErrorable windowInterface, List<singleItemOrder> itemToRemove)
        {
            try
            {
                model.InsertListOfElements<singleItemOrder>(new Communicator.singleOrderCommunicator(), itemToRemove);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }
        private bool View_insertSingleOrder(IErrorable windowInterface, order newItem)
        {
            try
            {
                model.InsertElement<order>(new Communicator.OrderCommunicator(), newItem);
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
    }
}
