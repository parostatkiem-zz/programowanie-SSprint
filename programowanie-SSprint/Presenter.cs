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

            //zamówienia
            view.getAllOrders += View_getAllElements<order>;
            view.insertOrder += View_insertElement<order>;
            view.removeOrder += View_removeElement<order>;

            //poj. zamówienia
            view.insertListOfItems += View_insertListOfElements<singleItemOrder>;
            view.deleteListOfItems += View_removeListOfElements<singleItemOrder>;
            
            //kolory
            view.insertColor += View_insertElement<color>;
            view.getAllColors += View_getAllElements<color>;
            view.removeColor += View_removeElement<color>;

            //obrazki
            view.insertPicture += View_insertElement<picture>;
            view.getAllPictures += View_getAllElements<picture>;
            view.removePicture += View_removeElement<picture>;

            //style
            view.insertStyle += View_insertElement<style>;
            view.getAllStyles += View_getAllElements<style>;
            view.removeStyle += View_removeElement<style>;

            //firmy
            view.insertCompany += View_insertElement<company>;
            view.getAllCompanies += View_getAllElements<company>;
            view.removeCompany += View_removeElement<company>;

            //koszulki
            view.insertTshirt += View_insertElement<tshirt>;
            view.getAllTshirts += View_getAllElements<tshirt>;
            view.removeTshirt += View_removeElement<tshirt>;
        }

        

        private bool View_removeElement<elementType>
            (IErrorable windowInterface, ICommunicative windowCommunicator, elementType itemToRemove)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            try
            {
                model.RemoveElement<elementType>(itemToRemove);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.Message, ex.HelpLink, "Błąd");
                return false;
            }
        }
        private bool View_removeListOfElements<elementType>
            (IErrorable windowInterface, ICommunicative windowCommunicator, List<elementType> itemsToRemove)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            try
            {
                model.RemoveListOfElements<elementType>(itemsToRemove);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.Message, ex.HelpLink, "Błąd");
                return false;
            }
        }


        private List<elementType> View_getAllElements<elementType>
            (IErrorable windowInterface, ICommunicative windowCommunicator)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            try
            {
                return model.GetAllElements<elementType>();
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.Message, ex.HelpLink, "Błąd");
                return null;
            }
        }


        private bool View_insertElement<elementType>
            (IErrorable windowInterface, ICommunicative windowCommunicator, elementType newItem)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            try
            {
                model.InsertElement<elementType>(newItem);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.Message, ex.HelpLink, "Błąd");
                return false;
            }
        }
        private bool View_insertListOfElements<elementType>
            (IErrorable windowInterface, ICommunicative windowCommunicator, List<elementType> newItems)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            try
            {
                model.InsertListOfElements<elementType>(newItems);
                return true;
            }
            catch(Exception ex)
            {
                windowInterface.ShowError(ex.Message, ex.HelpLink, "Błąd");
                return false;
            }
        }


        private elementType View_find<elementType>
            (IErrorable windowInterface, ICommunicative windowCommunicator, int elementID)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            try
            {
                return model.Find<elementType>(elementID);
            }
            catch(Exception ex)
            {
                windowInterface.ShowError(ex.Message, ex.HelpLink, "Błąd");
                return null;
            }
        }
    }
}
