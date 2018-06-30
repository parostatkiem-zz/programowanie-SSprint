using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint.Communicator
{
    class singleOrderCommunicator : BaseCommunicator<singleItemOrder>
    {
        public override List<singleItemOrder> getEntireTable()
        {
            try
            {
                return dataBase.singleItemOrders.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Insert(singleItemOrder newElement)
        {
            try
            {
                dataBase.singleItemOrders.Add(newElement);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Remove(singleItemOrder elementToRemove)
        {
            try
            {
                dataBase.singleItemOrders.Remove(elementToRemove);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(ref singleItemOrder sourceElement, singleItemOrder newElement)
        {
            try
            {
                sourceElement.order = newElement.order;
                sourceElement.order_id = newElement.order_id;
                sourceElement.tshirt = newElement.tshirt;
                sourceElement.tshirt_id = newElement.tshirt_id;
                sourceElement.amount = sourceElement.amount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override singleItemOrder Find(singleItemOrder element)
        {
            try
            {
                List<singleItemOrder> listOfColors = this.getEntireTable();
                singleItemOrder foundedColor = listOfColors.FirstOrDefault(e => e.id == element.id);
                return foundedColor;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
