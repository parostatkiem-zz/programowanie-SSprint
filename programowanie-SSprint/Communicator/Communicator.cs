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
                elementType foundedElement = dataBase.Set<elementType>().Find(elementID);
                if (dataBase == null)
                    this.NewConnection();
                return foundedElement;
            }
            catch
            {
                throw findingException;
            }
        }

        public override List<elementType> getEntireTable()
        {
            try
            {
                var data = dataBase.Set<elementType>().ToList(); 

                foreach(elementType element in data)
                    element.UpdateEntities(2);

                return data;
            }
            catch
            {
                throw badBaseConfigurationException;
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
                throw nullReferenceException;
            }
            catch
            {
                throw badDataTypeException;
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
                throw nullReferenceException;
            }
            catch
            {
                throw badDataTypeException;
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
                throw nullReferenceException;
            }
            catch (InvalidOperationException)
            {
                throw operationException;
            }
            catch
            {
                throw findingException;
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
                throw nullReferenceException;
            }
            catch
            {
                throw badDataTypeException;
            }
        }
    }
}
