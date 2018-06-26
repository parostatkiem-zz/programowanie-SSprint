using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint
{
    partial class Model
    {
        //todo : dodać więcej urposzczonych metod wyszukiwania z LINQ
       public color FindColor(color color)
        {
            return this.SSprintDataBase.colors.FirstOrDefault(c => c.id == color.id);
        }

    }
}
