using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programowanie_SSprint.Communicator;

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
    }
    public partial class color : Communicator.CommunicatorElement<color>
    {
        public override color GetCopyOfThis
        {
            get
            {
                color tmpItem = new color();
                tmpItem.CopyFrom(this);
                return tmpItem;
            }
        }

        public override void CopyFrom(color otherElement)
        {
            this.id = otherElement.id;
            this.name = otherElement.name;
            this.hex_value = otherElement.hex_value;
        }

        public override int GetId()
        {
            return this.id;
        }

        public override string ToString()
        {
            return this.name;
        }
    }

    public partial class company : Communicator.CommunicatorElement<company>
    {
        public override company GetCopyOfThis
        {
            get
            {
                company tmpItem = new company();
                tmpItem.CopyFrom(this);
                return tmpItem;
            }
        }
        public override void CopyFrom(company otherCompany)
        {
            this.id = otherCompany.id;
            this.name = otherCompany.name;
            this.phone = otherCompany.phone;
            this.email = otherCompany.email;
            this.tshirts = otherCompany.tshirts;
        }

        public override int GetId()
        {
            return this.id;
        }

        public override string ToString()
        {
            return this.name;
        }
    }

    public partial class order : Communicator.CommunicatorElement<order>
    {
        public override order GetCopyOfThis
        {
            get
            {
                order tmpItem = new order();
                tmpItem.CopyFrom(this);
                return tmpItem;
            }
        }

        public override void CopyFrom(order otherOrder)
        {
            this.id = otherOrder.id;
            this.client_email = otherOrder.client_email;
            this.client_name = otherOrder.client_name;
            this.client_phone = otherOrder.client_phone;
            this.order_date = otherOrder.order_date;
            this.end_date = otherOrder.end_date;
            this.picture_id = otherOrder.picture_id;
            this.status = otherOrder.status;
            //this.singleItemOrders = otherOrder.singleItemOrders;
            this.price_for_client = otherOrder.price_for_client;
        }

        public override int GetId()
        {
            return this.id;
        }

        public virtual int SingleItemOrderTypesCount
        {
            get
            {
                return (this.singleItemOrders != null) ? this.singleItemOrders.GroupBy(f => f.GetId()).Count() : 0;
            }
        }

        public virtual int SingleItemOrderCount
        {
            get
            {
                return (this.singleItemOrders != null) ? this.singleItemOrders.Count : 0;
            }
        }

        public virtual int Cost
        {
            get
            {
                return (this.singleItemOrders != null) ? this.singleItemOrders.Sum(x => x.TotalCost) : 0;
            }
        }

        public virtual int Profit
        {
            get
            {
                return this.price_for_client - this.Cost;
            }
        }
    }

    public partial class picture : Communicator.CommunicatorElement<picture>
    {
        public override picture GetCopyOfThis
        {
            get
            {
                picture tmpItem = new picture();
                tmpItem.CopyFrom(this);
                return tmpItem;
            }
        }

        public override void CopyFrom(picture otherPicture)
        {
            this.id = otherPicture.id;
            this.name = otherPicture.name;
            this.orders = otherPicture.orders;
            this.picture_data = otherPicture.picture_data;
        }

        public override int GetId()
        {
            return this.id;
        }
    }

    public partial class singleItemOrder : Communicator.CommunicatorElement<singleItemOrder>
    {
        public override singleItemOrder GetCopyOfThis
        {
            get
            {
                singleItemOrder tmpItem = new singleItemOrder();
                tmpItem.CopyFrom(this);
                return tmpItem;
            }
        }

        public override void CopyFrom(singleItemOrder otherSingleItemOrder)
        {
            this.id = otherSingleItemOrder.id;
            this.tshirt_id = otherSingleItemOrder.tshirt_id;
            this.order_id = otherSingleItemOrder.order_id;
            this.amount = otherSingleItemOrder.amount;
        }

        public override int GetId()
        {
            return this.id;
        }

        public virtual int TotalReservedAmound
        {
            get
            {
                return (this.tshirt != null) ? this.amount * this.tshirt.default_loss_percentage + this.amount : 0;
            }
        }

        public virtual int TotalCost
        {
            get
            {
                return (this.tshirt != null) ? this.tshirt.price : 0;
            }
        }
    }

    public partial class style : Communicator.CommunicatorElement<style>
    {
        public override style GetCopyOfThis
        {
            get
            {
                style tmpItem = new style();
                tmpItem.CopyFrom(this);
                return tmpItem;
            }
        }

        public override void CopyFrom(style otherStyle)
        {
            this.id = otherStyle.id;
            this.name = otherStyle.name;
            this.tshirts = otherStyle.tshirts;
        }

        public override int GetId()
        {
            return this.id;
        }

        public override string ToString()
        {
            return this.name;
        }
    }

    public partial class tshirt : Communicator.CommunicatorElement<tshirt>
    {
        public override tshirt GetCopyOfThis
        {
            get
            {
                tshirt tmpItem = new tshirt();
                tmpItem.CopyFrom(this);
                return tmpItem;
            }
        }

        public override void CopyFrom(tshirt other)
        {
            this.id = other.id;
            this.color_id = other.color_id;
            this.company_id = other.company_id;
            this.default_loss_percentage = other.default_loss_percentage;
            this.in_stock = other.in_stock;
            this.sex = other.sex;
            this.singleItemOrders = other.singleItemOrders;
            this.size = other.size;
            this.style_id = other.style_id;
            this.price = other.price;
        }

        public override int GetId()
        {
            return this.id;
        }

        public override string ToString()
        {
            return this.color.name + " | " + this.size + " | ( dostępne: " + this.getNotOrdered() + " ) " + this.price + "zł";
        }
    }
    
}
