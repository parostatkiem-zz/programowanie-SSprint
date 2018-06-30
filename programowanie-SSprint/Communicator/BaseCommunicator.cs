using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace programowanie_SSprint.Communicator
{
    abstract class BaseCommunicator<elementType> where elementType : CommunicatorElement
    {
        protected static SSprintEntities dataBase;
        protected static readonly Exception threadConflict;

        static BaseCommunicator()
        {
            threadConflict = new Exception("Zbyt wiele operacji wykonywanych na jednej bazie!");
        }
        ~BaseCommunicator()
        {
            dataBase = null;
        }

        protected virtual SSprintEntities GetBase()
        {
            return dataBase;
        }

        public virtual void Connect()
        {
            if (dataBase == null)
                dataBase = new SSprintEntities();
            else
                throw threadConflict;
        }

        public virtual void SaveChanges()
        {
            try
            {
                dataBase.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.FinalizeBase();
            }
        }
        public virtual void FinalizeBase()
        {
            dataBase = null;
        }

        public abstract void Insert(elementType newElement);
        public abstract void InsertRange(List<elementType> newElements);
        public abstract void Remove(elementType elementToRemove);
        public abstract void Update(ref elementType sourceElement, elementType newElement);
        public abstract List<elementType> getEntireTable();
        public abstract elementType Find(int elementID);
    }
}
