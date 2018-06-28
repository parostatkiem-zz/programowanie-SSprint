using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint
{
    partial class Model
    {
        //todo : dodać metody usuwające zawartość bazy
        public void RemoveColor(SSprintEntities data, color color)
        {
            try
            {
                data.colors.Remove(color);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void RemovePicture(SSprintEntities data, picture picture)
        {
            try
            {
                data.pictures.Remove(picture);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
