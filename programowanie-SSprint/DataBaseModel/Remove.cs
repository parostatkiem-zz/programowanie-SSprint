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
        public void RemoveColor(color color)
        {
            try
            {
                this.SSprintDataBase.colors.Remove(color);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
