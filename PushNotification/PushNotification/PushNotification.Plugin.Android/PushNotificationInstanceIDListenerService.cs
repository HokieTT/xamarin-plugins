using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Gms.Gcm.Iid;

namespace PushNotification.Plugin
{

    [Service(Exported = false)]
    [IntentFilter(new string[] { "com.google.android.gms.iid.InstanceID" })]
    public class PushNotificationInstanceIDListenerService : InstanceIDListenerService
    {
        const string Tag = "PushNotificationInstanceIDLS";
        /**
         * Called if InstanceID token is updated. This may occur if the security of
         * the previous token had been compromised. This call is initiated by the
         * InstanceID provider.
         */
        public override void OnTokenRefresh()
        {
 	       base.OnTokenRefresh();
           Intent intent = new Intent(Android.App.Application.Context, typeof(PushNotificationRegistrationIntentService));
           StartService(intent);
        }
    }
}