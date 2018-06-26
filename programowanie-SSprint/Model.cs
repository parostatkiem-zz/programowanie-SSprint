using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace programowanie_SSprint
{
    class Model
    {
        private SSprintEntities SSprintDataBase;

        #region locks
        private object saveChangesLock = new object();
        private object getBaseLock = new object();
        private object connectToBaseLock = new object();
        private object reloadBaseLock = new object();
        #endregion

        #region creating, saving, updating base
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
        #endregion

        #region public database methods
            #region values returned from DataBase
        public List<company> getAllCompanies()
        {
            return SSprintDataBase.companies.ToList();
        }
        public List<tshirt> getAllTshirts()
        {
            return SSprintDataBase.tshirts.ToList();
        }
        public List<color> getAllColors()
        {
            return SSprintDataBase.colors.ToList();
        }
        public List<order> getAllOrders()
        {
            return SSprintDataBase.orders.ToList();
        }
        public List<picture> getAllPictures()
        {
            return SSprintDataBase.pictures.ToList();
        }
        public List<style> getAllStyles()
        {
            return SSprintDataBase.styles.ToList();
        }
        public List<singleItemOrder> getAllSingleItemOrders()
        {
            return SSprintDataBase.singleItemOrders.ToList();
        }
        #endregion
        #region values finded in DataBase
        public List<tshirt> findTshirtsByCompany(string name)
        {
            company companyName = SSprintDataBase.companies.FirstOrDefault(c => c.name == name);
            return companyName.tshirts.ToList();
        }
        public List<tshirt> findTshirtsByColor(string name)
        {
            color colorName = SSprintDataBase.colors.FirstOrDefault(c => c.name == name);
            return colorName.tshirts.ToList();
        }
        public List<tshirt> findTshirtsByStyle(string name)
        {
            style styleName = SSprintDataBase.styles.FirstOrDefault(c => c.name == name);
            return styleName.tshirts.ToList();
        }
            #endregion
        #endregion
    }
}
