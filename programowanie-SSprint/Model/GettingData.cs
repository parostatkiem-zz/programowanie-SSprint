using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint
{
    partial class Model
    {
        public List<company> getAllCompanies()
        {
            return SSprintDataBase.companies.ToList();
        }
        public List<tshirt> getAllTshirts()
        {
            return SSprintDataBase.tshirts.ToList();
        }

        public List<color> getAllColors()
        {
            return SSprintDataBase.colors.ToList();
        }

        //todo : uzupełnić o więcej metod pobierania danych
    }
}
