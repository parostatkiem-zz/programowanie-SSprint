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


            view.getAllThsirts += View_getAllTshirts;
            view.getAllCompany += View_getAllCompany;

            // kolory
            view.getAllColors += View_getAllColors; 
            view.insertColor += View_insertColor; // zwrraca true jeśli uda się dodać/zmodyfikuje, false jeśli nie
            view.removeColor += View_removeColor; // zwraca true jeśli się usunie, false jeśli nie ma takiego koloru i wyjątek, jeśli wystąpi błąd

            // obrazki
            view.getAllPictures += View_getAllPictures;
            view.insertPicture += View_insertPicture; 
            view.removePicture += View_removePicture;

            // zamówienia
            view.insertListOfItems += View_insertListOfItems;
            view.insertSingleOrder += View_insertSingleOrder;
            view.getSingleOrder += View_getSingleOrder;


        }

        private order View_getSingleOrder(IErrorable senderWindow, int orderID)
        {
            //todo : przetestować | na dzień dzisijeszy baza jest źle stworzona pod tą metodę
            lock (mainThreadLock)
            {
                try
                {
                    SSprintEntities dataBase = model.GetBase();
                    return model.FindOrder(dataBase, new order { id = orderID });

                }
                catch (Exception ex)
                {
                    senderWindow.ShowError(ex.ToString());
                    return null;
                }
                finally
                {
                    model.FinalizeBase();
                }
            }
        }
        private bool View_insertSingleOrder(IErrorable senderWindow, order newOrder)
        {
            //todo : przetestować | na dzień dzisijeszy baza jest źle stworzona pod tą metodę
            lock (mainThreadLock)
            {
                try
                {
                    SSprintEntities dataBase = model.GetBase();

                    order isInData = model.FindOrder(dataBase, newOrder);
                    if (isInData != null)
                    {
                        isInData.client_name = newOrder.client_name;
                        isInData.client_email = newOrder.client_email;
                        isInData.client_phone = newOrder.client_phone;
                        isInData.end_date = newOrder.end_date;
                        isInData.status = newOrder.status;
                        isInData.singleItemOrders = newOrder.singleItemOrders;
                        isInData.picture_id = newOrder.picture_id;
                        isInData.picture = newOrder.picture;
                        isInData.order_date = newOrder.order_date;
                    }
                    else
                    {
                        model.AddOrder(dataBase, newOrder);
                    }

                    model.SaveChanges(dataBase);

                    return true;
                }
                catch (Exception ex)
                {
                    senderWindow.ShowError(ex.ToString());
                    return false;
                }
            }
        }
        private bool View_insertListOfItems(IErrorable senderWindow, List<singleItemOrder> singleItemOrdersList)
        {
            //todo : przetestować | na dzień dzisijeszy baza jest źle stworzona pod tą metodę
            lock (mainThreadLock)
            {
                try
                {
                    SSprintEntities dataBase = model.GetBase();
                    foreach (singleItemOrder order in singleItemOrdersList)
                    {
                        singleItemOrder isInData = model.FindSingleItemOrder(dataBase, order);
                        if (isInData != null)
                        {
                            isInData.order = order.order;
                            isInData.order_id = order.order_id;
                            isInData.tshirt = order.tshirt;
                            isInData.tshirt_id = order.tshirt_id;
                        }
                        else
                        {
                            model.AddSingleItemOrder(dataBase, order);
                        }
                    }

                    model.SaveChanges(dataBase);

                    return true;
                }
                catch (Exception ex)
                {
                    senderWindow.ShowError(ex.ToString());
                    return false;
                }
            }
        }

        private bool View_removePicture(IErrorable senderWindow, picture newPicture)
        {
            lock (mainThreadLock)
            {
                try
                {
                    SSprintEntities dataBase = model.GetBase();

                    picture isInData = model.FindPicture(dataBase, newPicture);
                    if (isInData != null)
                    {
                        model.RemovePicture(dataBase, newPicture);
                    }
                    else
                    {
                        return false;
                    }

                    model.SaveChanges(dataBase);

                    return true;
                }
                catch (Exception ex)
                {
                    senderWindow.ShowError(ex.ToString());
                    return false;
                }
                finally
                {
                    model.FinalizeBase();
                }
            }
        }
        private bool View_insertPicture(IErrorable senderWindow, picture newPicture)
        {
            lock (mainThreadLock)
            {
                try
                {
                    SSprintEntities dataBase = model.GetBase();

                    picture isInData = model.FindPicture(dataBase, newPicture);
                    if (isInData != null)
                    {
                        isInData.name = newPicture.name;
                        isInData.picture_data = newPicture.picture_data;
                        isInData.orders = newPicture.orders;
                    }
                    else
                    {
                        model.AddPicture(dataBase, newPicture);
                    }

                    model.SaveChanges(dataBase);

                    return true;
                }
                catch (Exception ex)
                {
                    senderWindow.ShowError(ex.ToString());
                    return false;
                }
            }
        }
        private List<picture> View_getAllPictures(IErrorable senderWindow)
        {
            lock (mainThreadLock)
            {
                try
                {
                    SSprintEntities dataBase = model.GetBase();

                    return model.GetAllPictures(dataBase);
                }
                catch (Exception ex)
                {
                    senderWindow.ShowError(ex.ToString());
                    return null;
                }
                finally
                {
                    model.FinalizeBase();
                }

            }
        }

        private bool View_removeColor(IErrorable senderWindow, color newColor)
        {
            lock (mainThreadLock)
            {
                try
                {
                    SSprintEntities dataBase = model.GetBase();

                    color isInData = model.FindColor(dataBase, newColor);
                    if (isInData != null)
                    {
                        model.RemoveColor(dataBase, isInData);
                    }
                    else
                    {
                        return false;
                    }

                    model.SaveChanges(dataBase);

                    return true;
                }
                catch (Exception ex)
                {
                    senderWindow.ShowError(ex.ToString());
                    return false;
                }
                finally
                {
                    model.FinalizeBase();
                }
            }
        }
        private bool View_insertColor(IErrorable senderWindow, color newColor)
        {
            lock (mainThreadLock)
            {
                try
                {
                    SSprintEntities dataBase = model.GetBase();

                    color isInData = model.FindColor(dataBase, newColor);
                    if(isInData != null)
                    {
                        isInData.name = newColor.name;
                        isInData.hex_value = newColor.hex_value;
                        isInData.tshirts = isInData.tshirts;
                    }
                    else
                    {
                        model.AddColor(dataBase, newColor);
                    }

                    model.SaveChanges(dataBase);

                    return true;

                }
                catch(Exception ex)
                {
                    senderWindow.ShowError(ex.ToString());
                    return false;
                }
            }
        }
        private List<color> View_getAllColors(IErrorable senderWindow)
        {
            lock (mainThreadLock)
            {
                try
                {
                    SSprintEntities dataBase = model.GetBase();

                    return model.GetAllColors(dataBase);
                }
                catch (Exception ex)
                {
                    senderWindow.ShowError(ex.ToString());
                    return null;
                }
                finally
                {
                    model.FinalizeBase();
                }

            }
        }
    

        private List<company> View_getAllCompany(IErrorable senderWindow)
        {
            lock (mainThreadLock)
            {
                try
                {
                    SSprintEntities dataBase = model.GetBase();

                    return model.GetAllCompanies(dataBase);
                }
                catch (Exception ex)
                {
                    senderWindow.ShowError(ex.ToString());
                    return null;
                }
                finally
                {
                    model.FinalizeBase();
                }

            }
        }

        private List<tshirt> View_getAllTshirts(IErrorable senderWindow)
        {
            lock (mainThreadLock)
            {
                try
                {
                    SSprintEntities dataBase = model.GetBase();

                    return model.GetAllTshirts(dataBase);
                }
                catch (Exception ex)
                {
                    senderWindow.ShowError(ex.ToString());
                    return null;
                }
                finally
                {
                    model.FinalizeBase();
                }

            }
        }


    }
}
