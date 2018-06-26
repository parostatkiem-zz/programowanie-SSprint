using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint
{
    partial class Model
    {
        public List<company> GetAllCompanies()
        {
            return SSprintDataBase.companies.ToList();
        }
        public List<tshirt> GetAllTshirts()
        {
            return SSprintDataBase.tshirts.ToList();
        }

        public List<color> GetAllColors()
        {
            return SSprintDataBase.colors.ToList();
        }

        //todo : uzupełnić o więcej metod pobierania danych
    }
}
