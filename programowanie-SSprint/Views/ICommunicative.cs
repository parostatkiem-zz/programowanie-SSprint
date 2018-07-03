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

       // void PushNotification(string message, NotificationTypes type = NotificationTypes.Information, string duration="medium");
    }
}
