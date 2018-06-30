using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint.Communicator
{
    class CompanyCommunicator : BaseCommunicator<company>
    {
        public override List<company> getEntireTable()
        {
            try
            {
                return dataBase.companies.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Insert(company newElement)
        {
            try
            {
                dataBase.companies.Add(newElement);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Remove(company elementToRemove)
        {
            try
            {
                dataBase.companies.Remove(elementToRemove);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(ref company sourceElement, company newElement)
        {
            try
            {
                sourceElement.name = newElement.name;
                sourceElement.phone = newElement.phone;
                sourceElement.email = newElement.email;
                sourceElement.tshirts = newElement.tshirts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override company Find(company element)
        {
            try
            {
                List<company> listOfColors = this.getEntireTable();
                company foundedColor = listOfColors.FirstOrDefault(e => e.id == element.id);
                return foundedColor;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
