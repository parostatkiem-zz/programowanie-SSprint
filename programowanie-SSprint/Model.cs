using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace programowanie_SSprint
{
    partial class Model
    {
        private object mainThreadLock = new object();
        public void InsertElement<elementType>(elementType objToInsert) 
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            lock (mainThreadLock)
            {
                try
                {
                    this.InsertListOfElements<elementType>(new List<elementType>() { objToInsert });
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            } 
        }

        public void InsertListOfElements<elementType>(List<elementType> listToInsert) 
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            lock (mainThreadLock)
            {
                Communicator.Communicator<elementType> baseCommunicator = new Communicator.Communicator<elementType>();
                try
                {
                    baseCommunicator.Connect();
                    
                    foreach(elementType objToInsert in listToInsert)
                    {
                        elementType foundedElem = baseCommunicator.Find(objToInsert.getId());
                        if (foundedElem != null)
                        {
                            baseCommunicator.Update(ref foundedElem, objToInsert);
                        }
                        else
                            baseCommunicator.Insert(objToInsert);
                    }
                    
                    baseCommunicator.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    baseCommunicator.FinalizeBase();
                }
            }
        }

        public List<elementType> GetAllElements<elementType>() 
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            lock (mainThreadLock)
            {
                Communicator.Communicator<elementType> baseCommunicator = new Communicator.Communicator<elementType>();
                try
                {
                    baseCommunicator.Connect();

                    List<elementType> toReturn = baseCommunicator.getEntireTable();
                    baseCommunicator.FinalizeBase();
                    return toReturn;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    baseCommunicator.FinalizeBase();
                }
            }
        }

        public void RemoveElement<elementType>(elementType objToRemove) 
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            lock (mainThreadLock)
            {
                try
                {
                    this.RemoveListOfElements<elementType>(new List<elementType>() { objToRemove });
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void RemoveListOfElements<elementType>(List<elementType> elementsToRemove)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            lock (mainThreadLock)
            {
                Communicator.Communicator<elementType> baseCommunicator = new Communicator.Communicator<elementType>();
                try
                {
                    baseCommunicator.Connect();

                    foreach(elementType element in elementsToRemove)
                    {
                        baseCommunicator.Remove(baseCommunicator.Find(element.getId()));
                    }
                    baseCommunicator.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    baseCommunicator.FinalizeBase();
                }
            }
        }

        public elementType Find<elementType>(int elementID)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            lock (mainThreadLock)
            {
                Communicator.Communicator<elementType> baseCommunicator = new Communicator.Communicator<elementType>();
                try
                {
                    baseCommunicator.Connect();

                    elementType toReturn = baseCommunicator.Find(elementID);

                    baseCommunicator.FinalizeBase();
                    return toReturn;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    baseCommunicator.FinalizeBase();
                }
            }
        }
    }
}
