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

namespace Sample.AlarmManager.Resources
{
    [BroadcastReceiver(Enabled = true, Exported = true)]
    public class AlarmReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {

            //Yapmak istediğiniz işi burada yapıyoruz
            var message = intent.GetStringExtra("MessageKey");

            Toast _toast = Toast.MakeText(Application.Context, message, ToastLength.Short);
            _toast.Show();
        }
    }
}