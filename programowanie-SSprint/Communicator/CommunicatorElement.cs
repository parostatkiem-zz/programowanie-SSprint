using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace programowanie_SSprint.Communicator
{
    public abstract class CommunicatorElement<elementType> where elementType : class
    {
        public abstract void CopyFrom(elementType otherELement);
        public abstract int GetId();
        public abstract elementType GetCopyOfThis { get; }
    }
}
