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
       public color FindColor(color color)
        {
            return this.SSprintDataBase.colors.FirstOrDefault(c => c.id == color.id);
        }

        public picture FindPicture(picture picture)
        {
            return this.SSprintDataBase.pictures.FirstOrDefault(p => p.id == picture.id);
        }

    }
}
