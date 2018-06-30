using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint.Communicator
{
    class StyleCommunicator : BaseCommunicator<style>
    {
        public override List<style> getEntireTable()
        {
            try
            {
                return dataBase.styles.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Insert(style newElement)
        {
            try
            {
                dataBase.styles.Add(newElement);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Remove(style elementToRemove)
        {
            try
            {
                dataBase.styles.Remove(elementToRemove);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(ref style sourceElement, style newElement)
        {
            try
            {
                sourceElement.name = newElement.name;
                sourceElement.tshirts = newElement.tshirts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override style Find(style element)
        {
            try
            {
                List<style> listOfColors = this.getEntireTable();
                style foundedColor = listOfColors.FirstOrDefault(e => e.id == element.id);
                return foundedColor;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
