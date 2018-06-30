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

        public void InsertElement<argType>(Communicator.BaseCommunicator<argType> baseCommunicator, argType objToInsert)
        {
            lock (mainThreadLock)
            {
                try
                {
                    this.InsertListOfElements<argType>(baseCommunicator, new List<argType>() { objToInsert });
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            } 
        }

        public void InsertListOfElements<argType>(Communicator.BaseCommunicator<argType> baseCommunicator, List<argType> listToInsert)
        {
            lock (mainThreadLock)
            {
                try
                {
                    baseCommunicator.NewConnection();
                    
                    foreach(argType objToInsert in listToInsert)
                    {
                        argType foundedElem = baseCommunicator.Find(objToInsert);
                        if (foundedElem != null)
                            baseCommunicator.Update(ref foundedElem, objToInsert);
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

        public List<argType> GetAllElements<argType>(Communicator.BaseCommunicator<argType> baseCommunicator)
        {
            lock (mainThreadLock)
            {
                try
                {
                    baseCommunicator.NewConnection();
                    List<argType> toReturn = baseCommunicator.getEntireTable();
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

        public void RemoveElement<argType>(Communicator.BaseCommunicator<argType> baseCommunicator, argType objToRemove)
        {
            lock (mainThreadLock)
            {
                try
                {
                    baseCommunicator.NewConnection();
                    argType ble = baseCommunicator.Find(objToRemove);
                    baseCommunicator.Remove(ble);
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
    }
}
