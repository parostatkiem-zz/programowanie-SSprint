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
            catch
            {
                throw findingFailure;
            }
        }

        public override List<elementType> getEntireTable()
        {
            try
            {
                return dataBase.Set<elementType>().ToList();
            }
            catch
            {
                throw badBaseConfiguration;
            }
        }

        public override void Insert(elementType newElement)
        {
            try
            {
                dataBase.Set<elementType>().Add(newElement);
            }
            catch (NullReferenceException)
            {
                throw nullReference;
            }
            catch
            {
                throw badDataType;
            }
        }

        public override void InsertRange(List<elementType> newElements)
        {
            try
            {
                dataBase.Set<elementType>().AddRange(newElements);
            }
            catch (NullReferenceException)
            {
                throw nullReference;
            }
            catch
            {
                throw badDataType;
            }
        }

        public override void Remove(elementType elementToRemove)
        {
            try
            {
                dataBase.Set<elementType>().Remove(elementToRemove);
            }
            catch (NullReferenceException)
            {
                throw nullReference;
            }
            catch
            {
                throw findingFailure;
            }
        }

        public override void Update(ref elementType sourceElement, elementType newElement)
        {
            try
            {
                sourceElement.CopyFrom(newElement);
            }
            catch (NullReferenceException)
            {
                throw nullReference;
            }
            catch
            {
                throw badDataType;
            }
        }
    }
}
