using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint.DB_classes
{
    public enum OrderStatus { JustOrdered, InProgress, Done};
    public class Order
    {
        public uint Id { get; set; }
        public OrderStatus Status { get; set; }

        public uint PictureId { get; set; }

        public string ClientName { get; set; }

        public string ClientEmail { get; set; }

        public string ClientPhone { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime BeginDate { get; set; }

    }
}
