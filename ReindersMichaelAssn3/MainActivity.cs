using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace ReindersMichaelAssn3
{
    [Activity(Label = "ReindersMichaelAssn3", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Set the Buttons Up
            Button btnMainLodgeSelect = (Button)FindViewById(Resource.Id.btnMainLodgeSelect);
            btnMainLodgeSelect.Click += btnMainLodgeSelect_Click;

            Button btnJuniperSpringsSelect = (Button)FindViewById(Resource.Id.btnJuniperSpringsSelect);
            btnJuniperSpringsSelect.Click += btnJuniperSpringsSelect_Click; 

            Button btnSummitSelect = (Button)FindViewById(Resource.Id.btnSummitSelect);
            btnSummitSelect.Click += btnSummitSelect_Click;

            Button btnAdventureCabins = (Button)FindViewById(Resource.Id.btnAdventureCabinsSelect);
            btnAdventureCabins.Click += btnAdventureCabins_Click;
            
        }

        private void btnMainLodgeSelect_Click(object sender, EventArgs e)
        {
            String Hotel = "Main Lodge";

            Intent activityIntent = new Intent(this, typeof(ReindersMichaelAssn3.ReservationNavigationActivity));
            activityIntent.PutExtra("Hotel", Hotel);

            //Open ResourceNavigation Activity
            StartActivity(activityIntent);
        }
        private void btnJuniperSpringsSelect_Click(object sender, EventArgs e)
        {
            String Hotel = "Juniper Springs";

            Intent activityIntent = new Intent(this, typeof(ReindersMichaelAssn3.ReservationNavigationActivity));
            activityIntent.PutExtra("Hotel", Hotel);

            //Open ResourceNavigation Activity
            StartActivity(activityIntent);
        }
        private void btnSummitSelect_Click(object sender, EventArgs e)
        {
            String Hotel = "Summit";

            Intent activityIntent = new Intent(this, typeof(ReindersMichaelAssn3.ReservationNavigationActivity));
            activityIntent.PutExtra("Hotel", Hotel);

            //Open ResourceNavigation Activity
            StartActivity(activityIntent);
        }
        private void btnAdventureCabins_Click(object sender, EventArgs e)
        {
            String Hotel = "Adventure Cabins";

            Intent activityIntent = new Intent(this, typeof(ReindersMichaelAssn3.ReservationNavigationActivity));
            activityIntent.PutExtra("Hotel", Hotel);

            //Open ResourceNavigation Activity
            StartActivity(activityIntent);
        }
    }
}

