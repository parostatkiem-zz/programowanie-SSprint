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
            return this.SSprintDataBase.companies.ToList();
        }
        public List<tshirt> GetAllTshirts()
        {
            return this.SSprintDataBase.tshirts.ToList();
        }

        public List<color> GetAllColors()
        {
            return this.SSprintDataBase.colors.ToList();
        }

        public List<picture> GetAllPictures()
        {
            return this.SSprintDataBase.pictures.ToList();
        }

        //todo : uzupełnić o więcej metod pobierania danych
    }
}
