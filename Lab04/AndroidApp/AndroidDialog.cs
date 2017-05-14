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

namespace AndroidApp
{
    class AndroidDialog : PCLProject.IDialog
    {
        Context AppContext;
        public AndroidDialog(Context context)
        {
            AppContext = context;
        }

        public void Show(string message)
        {
            Android.App.AlertDialog.Builder Builder =
                new AlertDialog.Builder(AppContext);
            AlertDialog Alert = Builder.Create();
            Alert.SetTitle("Resultado de la verificacion");
            Alert.SetIcon(Resource.Drawable.Icon);
            Alert.SetMessage(message);
            Alert.SetButton("ok", (s, ev) => { });
            Alert.Show();
        }
    }
}