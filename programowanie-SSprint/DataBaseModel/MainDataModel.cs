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
        private SSprintEntities SSprintDataBase;

        #region locks
        private object saveChangesLock = new object();
        private object getBaseLock = new object();
        private object connectToBaseLock = new object();
        private object reloadBaseLock = new object();
        #endregion

        public void ConnectToBase() // tworzy połączenie z bazą danych
        {
            lock (connectToBaseLock)
            {
                if (SSprintDataBase == null)
                    try
                    {
                        SSprintDataBase = new SSprintEntities();
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }     
            } 
        }
        public SSprintEntities GetBase() // pobiera referencję do bazy danych, na której możemy wykonywać zapytania
        {
            lock (getBaseLock)
            {
                try
                {
                    return SSprintDataBase;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }       
        }
        public void SaveChanges() // zapisuje zmiany do bazy danych
        {
            lock(saveChangesLock)
            {
                try
                {
                    SSprintDataBase.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }   
        //public void reloadbase()
        //{
        //    lock (reloadbaselock)
        //    {
        //        if (ssprintdatabase == null)
        //            this.connecttobase();
        //        try
        //        {
        //            ssprintdatabase.entry(ssprintdatabase).reload();
        //        }
        //        catch (exception ex)
        //        {
        //            throw ex;
        //        }
        //    }
        //}
        //todo : uzupełnić metodę reloadbase()
    }
}
