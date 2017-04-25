using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Lab1
{

    [Activity(Label = "Lab1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        Button button;
        TextView txtViewDev;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            button = FindViewById<Button>(Resource.Id.MyButton);
            txtViewDev = FindViewById<TextView>(Resource.Id.textViewDev);

            button.Click += button_click_eventHandler;
        }

        private async void button_click_eventHandler(object sender, EventArgs e)
        {
            txtViewDev.Text = "Inserta tu nombre";
            string myDevice = Android.Provider.Settings.Secure.GetString(ContentResolver, Android.Provider.Settings.Secure.AndroidId);
            XamarinDiplomado.ServiceHelper helper = new XamarinDiplomado.ServiceHelper();
            await helper.InsertarEntidad("armando_ct83@hotmail.com", "lab1", myDevice);
            button.Text = "Gracias por completar el Lab1";
        }
    }
}

