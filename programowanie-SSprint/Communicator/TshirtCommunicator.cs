using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint.Communicator
{
    class TshirtCommunicator : BaseCommunicator<tshirt>
    {
        public override List<tshirt> getEntireTable()
        {
            try
            {
                return dataBase.tshirts.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Insert(tshirt newElement)
        {
            try
            {
                dataBase.tshirts.Add(newElement);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Remove(tshirt elementToRemove)
        {
            try
            {
                dataBase.tshirts.Remove(elementToRemove);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(ref tshirt sourceElement, tshirt newElement)
        {
            try
            {
                sourceElement.style = newElement.style;
                sourceElement.style_id = newElement.style_id;
                sourceElement.singleItemOrders = newElement.singleItemOrders;
                sourceElement.sex = newElement.sex;
                sourceElement.in_stock = newElement.in_stock;
                sourceElement.color = newElement.color;
                sourceElement.color_id = newElement.color_id;
                sourceElement.company = newElement.company;
                sourceElement.company_id = newElement.company_id;
                sourceElement.default_loss_percentage = newElement.default_loss_percentage;
                sourceElement.size = newElement.size;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override tshirt Find(tshirt element)
        {
            try
            {
                List<tshirt> listOfColors = this.getEntireTable();
                tshirt foundedColor = listOfColors.FirstOrDefault(e => e.id == element.id);
                return foundedColor;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
