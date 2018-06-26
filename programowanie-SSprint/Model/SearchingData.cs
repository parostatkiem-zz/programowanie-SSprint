using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint
{
    partial class Model
    {
        public List<tshirt> findTshirtsByCompany(string name)
        {
            company companyName = SSprintDataBase.companies.FirstOrDefault(c => c.name == name);
            return companyName.tshirts.ToList();
        }
        public List<tshirt> findTshirtsByColor(string name)
        {
            color colorName = SSprintDataBase.colors.FirstOrDefault(c => c.name == name);
            return colorName.tshirts.ToList();
        }
        public List<tshirt> findTshirtsByStyle(string name)
        {
            style styleName = SSprintDataBase.styles.FirstOrDefault(c => c.name == name);
            return styleName.tshirts.ToList();
        }

    }
}
