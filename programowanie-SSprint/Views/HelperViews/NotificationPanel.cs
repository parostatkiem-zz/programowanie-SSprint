using programowanie_SSprint.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace programowanie_SSprint.Views.HelperViews
{
    public partial class NotificationPanel : UserControl
    {
        #region PUBLIC
        public NotificationPanel()
        {
            InitializeComponent();
            theBgWorker.DoWork += TheBgWorker_DoWork;
            theBgWorker.RunWorkerCompleted += TheBgWorker_RunWorkerCompleted;

            lText.Text = "";
            localNotifications = new List<Notification>();

            if (NotificationTime <= 0)
                NotificationTime = 6000;
            localNotificationTime = 0;
            colorsOfTypes = new Dictionary<int, Color>();
            colorsOfTypes.Add(0, Color.Green);
            colorsOfTypes.Add(1, Color.Gold);
            colorsOfTypes.Add(2, Color.Tomato);

            imagesOfTypes = new Dictionary<int, Image>();
            imagesOfTypes.Add(0, Resources.notification_icon_green);
            imagesOfTypes.Add(1, Resources.notification_icon_yellow);
            imagesOfTypes.Add(2, Resources.notification_icon_red);

            ShowNoNotification();

        }
        public int NotificationTime { get; set; }
        public void PushNotification(string text, int type = 0)
        {
            if (type > 2 || type < 0)
            { 
                type = 0;
                Console.WriteLine("NotificationPanel: given parameter type(int) was wrong therefore set to 0 ");
            }
            localNotifications.Add(new Notification(text, type));
            UpdateNotificationAmount();
            if (!theBgWorker.IsBusy)
                theBgWorker.RunWorkerAsync();
        }

        #endregion


        private List<Notification> localNotifications;
        private int localNotificationTime;
        private Dictionary<int, Color> colorsOfTypes;
        private Dictionary<int, Image> imagesOfTypes;
        private class Notification
        {
            public Notification(string text, int type = 0)
            {
                this.Type = type;
                this.Text = text;
            }
            public int Type { get; private set; }
            public string Text { get; private set; }
        }
        private void TheBgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (localNotificationTime == 0) localNotificationTime = NotificationTime;
            Console.WriteLine("Async count: " + localNotifications.Count);
       
            if (localNotifications.Count > 0)
            {
                ShowNextNotification();
                theBgWorker.RunWorkerAsync();
            }
            else
            {
                localNotificationTime = 0;
                ShowNoNotification();
            }
        }

        private void TheBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if(localNotificationTime>0)
              Thread.Sleep(localNotificationTime);
        }



        
        private void ShowNextNotification()
        {
            UpdateNotificationAmount();
            if (localNotifications.Count <= 0) return;
            var notificationToShow = localNotifications.First();
            pictureBoxIcon.Image = imagesOfTypes[notificationToShow.Type];
            lText.Text = notificationToShow.Text;
            lText.ForeColor = colorsOfTypes[notificationToShow.Type];
            RemoveNotification(notificationToShow);
        }

        private void RemoveNotification(Notification n)
        {
            try
            {
                localNotifications.Remove(n);
                
            }
            catch { }
            finally { UpdateNotificationAmount(); }
        }

        private void UpdateNotificationAmount(bool areThereAny=true)
        {
            if (!areThereAny||localNotifications.Count<=0)
                lAmount.Text = "";
            else
                 lAmount.Text = "(" + localNotifications.Count + ")";
        }

        private void ShowNoNotification()
        {
            lText.Text = "";
            lAmount.Text = "";
            pictureBoxIcon.Image = null;
            UpdateNotificationAmount(false);
        }

    }
}
