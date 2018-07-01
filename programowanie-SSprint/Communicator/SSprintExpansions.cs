using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint
{
    static class SSprintExpansions
    {
        public static int getOrdered(this tshirt shirt)
        {
            int sum = 0;
            foreach(singleItemOrder order in shirt.singleItemOrders.ToList())
            {
                if (order.order.status == 2)
                    continue;
                sum += order.amount;
            }
            return sum;
        }
        public static int getNotOrdered(this tshirt shirt)
        {
            return shirt.in_stock - getOrdered(shirt);
        }

        public static string NameString(this tshirt shirt)
        {
            return shirt.color.name + " | " + shirt.size + " | " + shirt.in_stock.ToString();
        }
        public static string NameString(this color color)
        {
            return color.name;
        }
        public static string NameString(this company company)
        {
            return company.name;
        }
    }
    public partial class color : Communicator.CommunicatorElement<color>
    {
        public override void CopyFrom(color otherElement)
        {
            this.name = otherElement.name;
            this.hex_value = otherElement.hex_value;
        }

        public override int getId()
        {
            return this.id;
        }
    }

    public partial class company : Communicator.CommunicatorElement<company>
    {
        public override void CopyFrom(company otherCompany)
        {
            this.name = otherCompany.name;
            this.phone = otherCompany.phone;
            this.email = otherCompany.email;
            this.tshirts = otherCompany.tshirts;
        }

        public override int getId()
        {
            return this.id;
        }
    }

    public partial class order : Communicator.CommunicatorElement<order>
    {
        public override void CopyFrom(order otherOrder)
        {
            this.client_email = otherOrder.client_email;
            this.client_name = otherOrder.client_name;
            this.client_phone = otherOrder.client_phone;
            this.order_date = otherOrder.order_date;
            this.end_date = otherOrder.end_date;
            this.picture_id = otherOrder.picture_id;
            this.status = otherOrder.status;
            this.singleItemOrders = otherOrder.singleItemOrders;
        }

        public override int getId()
        {
            return this.id;
        }
    }

    public partial class picture : Communicator.CommunicatorElement<picture>
    {
        public override void CopyFrom(picture otherPicture)
        {
            this.name = otherPicture.name;
            this.orders = otherPicture.orders;
            this.picture_data = otherPicture.picture_data;
        }

        public override int getId()
        {
            return this.id;
        }
    }

    public partial class singleItemOrder : Communicator.CommunicatorElement<singleItemOrder>
    {
        public override void CopyFrom(singleItemOrder otherSingleItemOrder)
        {
            this.tshirt_id = otherSingleItemOrder.tshirt_id;
            this.order_id = otherSingleItemOrder.order_id;
            this.amount = otherSingleItemOrder.amount;
        }

        public override int getId()
        {
            return this.id;
        }
    }

    public partial class style : Communicator.CommunicatorElement<style>
    {
        public override void CopyFrom(style otherStyle)
        {
            this.name = otherStyle.name;
            this.tshirts = otherStyle.tshirts;
        }

        public override int getId()
        {
            return this.id;
        }
    }

    public partial class tshirt : Communicator.CommunicatorElement<tshirt>
    {
        public override void CopyFrom(tshirt other)
        {
            this.color_id = other.color_id;
            this.company_id = other.company_id;
            this.default_loss_percentage = other.default_loss_percentage;
            this.in_stock = other.in_stock;
            this.sex = other.sex;
            this.singleItemOrders = other.singleItemOrders;
            this.size = other.size;
            this.style_id = other.style_id;
        }

        public override int getId()
        {
            return this.id;
        }
    }
    
}
