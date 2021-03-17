using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Trabalho_App_Read_Sms_Code.Droid;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
[assembly: Xamarin.Forms.Dependency(typeof(MySmsReader))]

namespace Trabalho_App_Read_Sms_Code.Droid
{
    public class MySmsReader : ISmsReader
    {
        public void GetSmsInbox()
        {
            IntentFilter filter = new IntentFilter();
            filter.AddAction("android.provider.Telephony.SMS_RECEIVED");


            SmsBroadcastReceiver receiver = new SmsBroadcastReceiver();
            Application.Context.RegisterReceiver(receiver, filter);

        }
    }
}