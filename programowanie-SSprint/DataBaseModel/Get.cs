using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint
{
    partial class Model
    {
        public List<company> GetAllCompanies(SSprintEntities data)
        {
            return data.companies.ToList();
        }
        public List<tshirt> GetAllTshirts(SSprintEntities data)
        {
            return data.tshirts.ToList();
        }

        public List<color> GetAllColors(SSprintEntities data)
        {
            return data.colors.ToList();
        }

        public List<picture> GetAllPictures(SSprintEntities data)
        {
            return data.pictures.ToList();
        }

        //todo : uzupełnić o więcej metod pobierania danych
    }
}
