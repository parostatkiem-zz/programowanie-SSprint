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
            try
            {
                this.InsertListOfElements<elementType>(new List<elementType>() { objToInsert });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void InsertListOfElements<elementType>(List<elementType> listToInsert, bool reUpload = false) 
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            lock (mainThreadLock)
            {
                Communicator.Communicator<elementType> baseCommunicator = new Communicator.Communicator<elementType>();
                List<elementType> bufferAdded = new List<elementType>();
                List<elementType> bufferModified = new List<elementType>();
                try
                {
                    baseCommunicator.NewConnection();
                    
                    foreach(elementType objToInsert in listToInsert)
                    {
                        elementType foundedElem = baseCommunicator.Find(objToInsert.GetId());
                        if (foundedElem != null)
                        {
                            elementType tmp = foundedElem.GetCopyOfThis;

                            baseCommunicator.Update(ref foundedElem, objToInsert);
                            baseCommunicator.SaveChanges();

                            bufferModified.Add(tmp);
                        }
                        else
                        {
                            baseCommunicator.Insert(objToInsert);
                            baseCommunicator.SaveChanges();

                            bufferAdded.Add(objToInsert.GetCopyOfThis);
                        } 
                    }
                    
                    
                }
                catch (Exception ex)
                {
                    if(!reUpload)
                    {
                        baseCommunicator.FinalizeBase();
                        this.RemoveListOfElements<elementType>(bufferAdded, reUpload = true);
                        this.InsertListOfElements<elementType>(bufferModified, reUpload = true);
                        throw ex;
                    }
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
                    baseCommunicator.NewConnection();

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
            try
            {
                this.RemoveListOfElements<elementType>(new List<elementType>() { objToRemove });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoveListOfElements<elementType>(List<elementType> elementsToRemove, bool reUpload = false)
            where elementType : Communicator.CommunicatorElement<elementType>
        {
            lock (mainThreadLock)
            {
                Communicator.Communicator<elementType> baseCommunicator = new Communicator.Communicator<elementType>();
                List<elementType> bufferRemoved = new List<elementType>();
                try
                {
                    baseCommunicator.NewConnection();

                    foreach(elementType element in elementsToRemove)
                    {
                        baseCommunicator.Remove(baseCommunicator.Find(element.GetId()));
                        baseCommunicator.SaveChanges();

                        bufferRemoved.Add(element.GetCopyOfThis);
                    }
                    
                }
                catch(Exception ex)
                {
                    if (!reUpload)
                    {
                        baseCommunicator.FinalizeBase();
                        this.InsertListOfElements<elementType>(bufferRemoved, reUpload = true);
                        throw ex;
                    }  
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
                    baseCommunicator.NewConnection();

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
