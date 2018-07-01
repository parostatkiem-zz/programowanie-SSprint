using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace programowanie_SSprint.Communicator
{
    class Communicator<elementType> : BaseCommunicator<elementType> where elementType : CommunicatorElement<elementType>
    {

        public override elementType Find(int elementID)
        {
            try
            {
                return dataBase.Set<elementType>().Find(elementID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<elementType> getEntireTable()
        {
            try
            {
                return dataBase.Set<elementType>().ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public override void Insert(elementType newElement)
        {
            try
            {
                dataBase.Set<elementType>().Add(newElement);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void InsertRange(List<elementType> newElements)
        {
            try
            {
                dataBase.Set<elementType>().AddRange(newElements);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public override void Remove(elementType elementToRemove)
        {
            try
            {
                dataBase.Set<elementType>().Remove(elementToRemove);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(ref elementType sourceElement, elementType newElement)
        {
            try
            {
                sourceElement.CopyFrom(newElement);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
