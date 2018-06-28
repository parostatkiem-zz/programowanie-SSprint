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
        //todo : dodać więcej urposzczonych metod wyszukiwania z LINQ
       public color FindColor(SSprintEntities data, color color)
        {
            try
            {
                color findedColor = data.colors.FirstOrDefault(p => p.id == color.id);

                return findedColor;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public picture FindPicture(SSprintEntities data, picture picture)
        {
            try
            {
                picture findedPicture = data.pictures.FirstOrDefault(p => p.id == picture.id);

                return findedPicture;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public order FindOrder(SSprintEntities data, order order)
        {
            try
            {
                order findedOrder = data.orders.FirstOrDefault(p => p.id == order.id);

                return findedOrder;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public singleItemOrder FindSingleItemOrder(SSprintEntities data, singleItemOrder singleItemOrder)
        {
            try
            {
                singleItemOrder singleItemOrderFinded = data.singleItemOrders.FirstOrDefault(s => s.id == singleItemOrder.id);

                return singleItemOrder;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
