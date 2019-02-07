using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace BMI
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView tHeight, tWeight, tBmi, tStatus;
        EditText eHeight, eWeight, eBmi, eStatus;
        Button bCal, bClr;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            tHeight = (TextView)FindViewById(Resource.Id.heightTV);
            tWeight = (TextView)FindViewById(Resource.Id.weightTV);
            tBmi = (TextView)FindViewById(Resource.Id.bmiTV);
            tStatus = (TextView)FindViewById(Resource.Id.statusTV);
            eHeight = (EditText)FindViewById(Resource.Id.heightET);
            eWeight = (EditText)FindViewById(Resource.Id.weightET);
            eBmi = (EditText)FindViewById(Resource.Id.bmiET);
            eStatus = (EditText)FindViewById(Resource.Id.statusET);
            bCal = (Button)FindViewById(Resource.Id.statusBtn);
            bClr = (Button)FindViewById(Resource.Id.clrBtn);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

