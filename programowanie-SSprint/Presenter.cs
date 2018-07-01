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

            //view.insertTshirt += View_insertTshirt;
            //view.getAllThsirts += View_getAllThsirts;

            //poj. zamówienia
            view.getSingleOrder += View_find<order>;
            view.insertSingleOrder += View_insertElement<order>;
            view.insertListOfItems += View_insertListOfElements<singleItemOrder>;

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

        private bool View_removeElement<elementType>(IErrorable windowInterface, elementType itemToRemove)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            try
            {
                model.RemoveElement<elementType>(itemToRemove);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.Message);
                return false;
            }
        }
        private List<elementType> View_getAllElements<elementType>(IErrorable windowInterface)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            try
            {
                return model.GetAllElements<elementType>();
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return null;
            }
        }
        private bool View_insertElement<elementType>(IErrorable windowInterface, elementType newItem)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            try
            {
                model.InsertElement<elementType>(newItem);
                return true;
            }
            catch (Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }
        private bool View_insertListOfElements<elementType>(IErrorable windowInterface, List<elementType> newItems)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            try
            {
                model.InsertListOfElements<elementType>(newItems);
                return true;
            }
            catch(Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return false;
            }
        }
        private elementType View_find<elementType>(IErrorable windowInterface, int elementID)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            try
            {
                return model.Find<elementType>(elementID);
            }
            catch(Exception ex)
            {
                windowInterface.ShowError(ex.ToString());
                return null;
            }
        }
    }
}
