using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint.Communicator
{
    class ColorCommunicator : BaseCommunicator<color>
    {
        public override void Insert(color newElement)
        {
            try
            {
                dataBase.colors.Add(newElement);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(ref color sourceElement, color newElement)
        {
            try
            {
                sourceElement.name = newElement.name;
                sourceElement.hex_value = newElement.hex_value;
                sourceElement.tshirts = newElement.tshirts;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public override void Remove(color elementToRemove)
        {
            try
            {
                dataBase.colors.Remove(elementToRemove);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public override List<color> getEntireTable()
        {
            try
            {
                return dataBase.colors.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public override color Find(color element)
        {
            try
            {
                List<color> listOfColors = this.getEntireTable();
                color foundedColor = listOfColors.FirstOrDefault(e => e.id == element.id);
                return foundedColor;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
