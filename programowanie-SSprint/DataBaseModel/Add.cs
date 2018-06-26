using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint
{
    partial class Model
    {
        //todo : dodać metody dodawania obiektów do bazy
        //firmy
        public void AddCompany(company newCompany)
        {
            try
            {
                SSprintDataBase.companies.Add(newCompany);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public company AddCompany(string name, string phone = "", string email = "")
        {
            try
            {
                company newCompany = new company
                {
                    name = name,
                    phone = phone,
                    email = email
                };
                SSprintDataBase.companies.Add(newCompany);
                return newCompany;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //kolory
        public void AddColor(color newColor)
        {
            try
            {
                SSprintDataBase.colors.Add(newColor);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public color AddColor(string name, string hex_value)
        {
            try
            {
                color newColor = new color
                {
                    name = name,
                    hex_value = hex_value
                };
                SSprintDataBase.colors.Add(newColor);
                return newColor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //style
        public void AddStyle(style newStyle)
        {
            try
            {
                SSprintDataBase.styles.Add(newStyle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public style AddStyle(string name)
        {
            try
            {
                style newStyle = new style
                {
                    name = name
                };
                SSprintDataBase.styles.Add(newStyle);
                return newStyle;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //koszulki
        public void AddTshirt(tshirt newTshirt)
        {
            try
            {
                SSprintDataBase.tshirts.Add(newTshirt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tshirt AddTshirt(company company, style style, color color, string sex, int in_stock, int default_loss_percentage)
        {
            try
            {
                tshirt newTshirt = new tshirt
                {
                    company_id = company.id,
                    style_id = style.id,
                    color_id = color.id,
                    sex = sex,
                    in_stock = in_stock,
                    default_loss_percentage = default_loss_percentage
                };
                SSprintDataBase.tshirts.Add(newTshirt);
                return newTshirt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
