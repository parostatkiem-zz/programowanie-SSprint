using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint
{
    partial class Model
    {
        //todo : dodać metody dodawania obiektów do bazy
        public void AddCompany(SSprintEntities data, company newCompany)
        {
            try
            {
                data.companies.Add(newCompany);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void AddColor(SSprintEntities data, color newColor)
        {
            try
            {
                data.colors.Add(newColor);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void AddStyle(SSprintEntities data, style newStyle)
        {
            try
            {
                data.styles.Add(newStyle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddTshirt(SSprintEntities data, tshirt newTshirt)
        {
            try
            {
                data.tshirts.Add(newTshirt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddPicture(SSprintEntities data, picture picture)
        {
            try
            {
                data.pictures.Add(picture);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void AddOrder(SSprintEntities data, order order)
        {
            try
            {
                data.orders.Add(order);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void AddSingleItemOrder(SSprintEntities data, singleItemOrder order)
        {
            try
            {
                data.singleItemOrders.Add(order);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
