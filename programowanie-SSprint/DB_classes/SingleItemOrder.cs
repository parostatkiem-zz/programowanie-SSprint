using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint.DB_classes
{
    class SingleItemOrder
    {
        public uint Id { get; set; }
        public uint TshirtId { get; set; }

        public uint OrderId { get; set; }

        public uint Amount { get; set; }
    }
}
