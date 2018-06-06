using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint.DB_classes
{
    public enum SexEnum { Man, Woman, Unisex };
    public class Tshirt
    {
        public uint Id { get; set; }
        public uint CompanyId { get; set; }
        public uint StyleId { get; set; }
        public uint ColorId { get; set; }
        public uint Available { get; set; }
        public uint Reserved { get; set; }
        public SexEnum Sex { get; set; }

    }
}
