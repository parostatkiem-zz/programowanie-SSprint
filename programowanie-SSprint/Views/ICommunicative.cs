using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_SSprint
{
    public enum NotificationTypes { Information, Warning, Error};
    public interface ICommunicative
    {

        ///<summary>
        ///This method lets you to push some notifications here.
        ///You can push as many of them as you want.
        ///type={0: info, 1: warning, 2: error}, default=0 (info)
        ///</summary>
        void PushNotification(string text, int type = 0);

        event Action<List<object>> ReturnListOfObjects;

    }
}
