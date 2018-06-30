using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint.Communicator
{
    class PictureCommunicator : BaseCommunicator<picture>
    {
        public override void Insert(picture newElement)
        {
            try
            {
                dataBase.pictures.Add(newElement);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Remove(picture pictureToRemove)
        {
            try
            {
                dataBase.pictures.Remove(pictureToRemove);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(ref picture sourceElement, picture newElement)
        {
            try
            {
                sourceElement.name = newElement.name;
                sourceElement.picture_data = newElement.picture_data;
                sourceElement.orders = newElement.orders;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public override List<picture> getEntireTable()
        {
            try
            {
                return dataBase.pictures.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override picture Find(picture element)
        {
            try
            {
                List<picture> listOfColors = this.getEntireTable();
                picture foundedColor = listOfColors.FirstOrDefault(e => e.id == element.id);
                return foundedColor;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
