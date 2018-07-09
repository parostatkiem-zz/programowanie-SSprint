using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;


//todo : obgadać i dodać lepszą obsługę komunikatów przy zwracaniu wyjątku


namespace programowanie_SSprint
{
    class Presenter
    {
        ImainView view;
        Model model;

        private readonly string goodInsertingResult = "Zapisano dane w bazie";
        private readonly string badInsertingResult = "Nie zapisano danych w bazie";

        private readonly string goodRemovingResult = "Usunięto dane z bazy";
        private readonly string badRemovingResult = "Nie usunięto danych z bazy";

        private readonly string goodGettingResult = "Pobrano dane z bazy";
        private readonly string badGettingResult = "Nie pobrano danych z bazy";

        private readonly string errorableTitle = "Wystąpił Błąd";

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

        

        private void View_removeElement<elementType>
            (IErrorable windowInterface, ICommunicative windowCommunicator, elementType itemToRemove)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            new Task(() =>
            {
                try
                {                    
                    model.RemoveElement<elementType>(itemToRemove);
                    windowCommunicator.PushNotification(goodRemovingResult, 0);
                }
                catch (Exception ex)
                {
                    windowCommunicator.PushNotification(badRemovingResult, 2);
                    windowInterface.ShowError(ex.Message, ex.HelpLink, errorableTitle);
                }
            }).Start();
        }
        private void View_removeListOfElements<elementType>
            (IErrorable windowInterface, ICommunicative windowCommunicator, List<elementType> itemsToRemove)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            new Task(() => 
            {
                try
                {
                    model.RemoveListOfElements<elementType>(itemsToRemove);
                    windowCommunicator.PushNotification(goodRemovingResult, 0);
                }
                catch (Exception ex)
                {
                    windowCommunicator.PushNotification(badRemovingResult, 2);
                    windowInterface.ShowError(ex.Message, ex.HelpLink, errorableTitle);
                }
            }).Start();
        }

        private void View_getAllElements<elementType>
            (IErrorable windowInterface, ICommunicative windowCommunicator)
            where elementType : Communicator.CommunicatorElement<elementType>
        {            
            new Task(() => {
                
                try
                {
                    windowCommunicator.ReturnListOfObjects(model.GetAllElements<elementType>().OfType<object>().ToList());
                    windowCommunicator.PushNotification(goodGettingResult, 0);
                }
                catch (Exception ex)
                {
                    windowCommunicator.PushNotification(badGettingResult, 2);
                    windowInterface.ShowError(ex.Message, ex.HelpLink, errorableTitle);
                }
            }).Start();
        }


        private void View_insertElement<elementType>
            (IErrorable windowInterface, ICommunicative windowCommunicator, elementType newItem)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            new Task(() =>
            {
                try
                {
                    model.InsertElement<elementType>(newItem);
                    windowCommunicator.PushNotification(goodInsertingResult, 0);
                }
                catch (Exception ex)
                {
                    windowCommunicator.PushNotification(badInsertingResult, 2);
                    windowInterface.ShowError(ex.Message, ex.HelpLink, errorableTitle);
                }
            }).Start();
        }
        private void View_insertListOfElements<elementType>
            (IErrorable windowInterface, ICommunicative windowCommunicator, List<elementType> newItems)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            new Task(() =>
            {
                try
                {
                    model.InsertListOfElements<elementType>(newItems);
                    windowCommunicator.PushNotification(goodInsertingResult, 0);
                }
                catch (Exception ex)
                {
                    windowCommunicator.PushNotification(badInsertingResult, 2);
                    windowInterface.ShowError(ex.Message, ex.HelpLink, errorableTitle);
                }
            }).Start();
        }


        private void View_find<elementType>
            (IErrorable windowInterface, ICommunicative windowCommunicator, int elementID)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            new Task(() =>
            {
                try
                {
                    elementType tmp = model.Find<elementType>(elementID);
                    //windowCommunicator.ReturnObject((object)tmp);
                    windowCommunicator.PushNotification(goodGettingResult, 0);
                }
                catch (Exception ex)
                {
                    windowCommunicator.PushNotification(badGettingResult, 2);
                    windowInterface.ShowError(ex.Message, ex.HelpLink, errorableTitle);
                    
                }
            }).Start();
        }
    }
}
