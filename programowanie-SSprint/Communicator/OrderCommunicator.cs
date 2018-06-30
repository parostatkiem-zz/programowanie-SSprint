using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint.Communicator
{
    class OrderCommunicator : BaseCommunicator<order>
    {
        public override List<order> getEntireTable()
        {
            try
            {
                return dataBase.orders.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Insert(order newElement)
        {
            try
            {
                dataBase.orders.Add(newElement);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Remove(order elementToRemove)
        {
            try
            {
                dataBase.orders.Remove(elementToRemove);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(ref order sourceElement, order newElement)
        {
            try
            {
                sourceElement.order_date = newElement.order_date;
                sourceElement.picture = newElement.picture;
                sourceElement.picture_id = newElement.picture_id;
                sourceElement.singleItemOrders = newElement.singleItemOrders;
                sourceElement.status = newElement.status;
                sourceElement.client_email = newElement.client_email;
                sourceElement.client_name = newElement.client_name;
                sourceElement.client_phone = newElement.client_phone;
                sourceElement.end_date = newElement.end_date;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override order Find(order element)
        {
            try
            {
                List<order> listOfColors = this.getEntireTable();
                order foundedColor = listOfColors.FirstOrDefault(e => e.id == element.id);
                return foundedColor;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
