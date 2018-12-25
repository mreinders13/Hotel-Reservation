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

namespace ReindersMichaelAssn3
{
    [Activity(Label = "SpecialNeedsActivity")]
    public class SpecialNeedsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "SpecialNees" layout resource
            SetContentView(Resource.Layout.SpecialNeeds);

            // Setup Checkbox, EditText, TextView and Button
            CheckBox cbADA = (CheckBox)FindViewById(Resource.Id.cbADA);
            cbADA.Click += cbADA_Click;
            CheckBox cbSurcharge = (CheckBox)FindViewById(Resource.Id.cbSurcharge);
            // cbSurcharge.Click += cbSurcharge_Click;
            EditText txtSpecialNeeds = (EditText)FindViewById(Resource.Id.txtSpecialRequests);
            TextView tvADA = (TextView)FindViewById(Resource.Id.tvADA);
            Button btnSpecialNeedsSubmit = (Button)FindViewById(Resource.Id.btnSpecialNeedsSubmit);
            btnSpecialNeedsSubmit.Click += btnSpecialNeedsSubmit_Click;

            // Get established extras
            String GetHotel = Intent.GetStringExtra("Hotel");
            String PersonalInfoName = Intent.GetStringExtra("Name");
            String PersonalInfoPhone = Intent.GetStringExtra("Phone");
            String PersonalInfoAddress = Intent.GetStringExtra("Address");
            String PersonalInfoCity = Intent.GetStringExtra("City");
            String PersonalInfoState = Intent.GetStringExtra("State");
            String PersonalInfoZip = Intent.GetStringExtra("Zip");
            String CheckInDate = Intent.GetStringExtra("CheckInDate");
            String CheckInTime = Intent.GetStringExtra("CheckInTime");
            String CheckOutDate = Intent.GetStringExtra("CheckOutDate");
            String CheckOutTime = Intent.GetStringExtra("CheckOutTime");
            String RoomType = Intent.GetStringExtra("RoomType");
            String Weekend = Intent.GetStringExtra("Weekend");
        }

        private void cbSurcharge_Click(object sender, EventArgs e)
        {
            //nothing
        }

        private void cbADA_Click(object sender, EventArgs e)
        {
            TextView tvADA = (TextView)FindViewById(Resource.Id.tvADA);
            tvADA.Text = "Yes";
        }

        private void btnSpecialNeedsSubmit_Click(object sender, EventArgs e)
        {
            EditText txtSpecialNeeds = (EditText)FindViewById(Resource.Id.txtSpecialRequests);
            TextView tvADA = (TextView)FindViewById(Resource.Id.tvADA);
            CheckBox cbSurcharge = (CheckBox)FindViewById(Resource.Id.cbSurcharge);
            // cbSurcharge.Click += cbSurcharge_Click;
            string surcharge = "No";

            if (cbSurcharge.Checked == true)
            {
                surcharge = "Yes";
            }

            // Get the Extras we have so far so we can pass them back again
            String GetHotel = Intent.GetStringExtra("Hotel");
            String PersonalInfoName = Intent.GetStringExtra("Name");
            String PersonalInfoPhone = Intent.GetStringExtra("Phone");
            String PersonalInfoAddress = Intent.GetStringExtra("Address");
            String PersonalInfoCity = Intent.GetStringExtra("City");
            String PersonalInfoState = Intent.GetStringExtra("State");
            String PersonalInfoZip = Intent.GetStringExtra("Zip");
            String CheckInDate = Intent.GetStringExtra("CheckInDate");
            String CheckInTime = Intent.GetStringExtra("CheckInTime");
            String CheckOutDate = Intent.GetStringExtra("CheckOutDate");
            String CheckOutTime = Intent.GetStringExtra("CheckOutTime");
            String RoomType = Intent.GetStringExtra("RoomType");
            String Weekend = Intent.GetStringExtra("Weekend");
            
            //Setup our new extra to send 
            String ADA = tvADA.Text.ToString();
            String SpecialNeeds = txtSpecialNeeds.Text.ToString();


            // Setup intent and send everything back
            Intent activityIntent = new Intent(this, typeof(ReindersMichaelAssn3.ReservationNavigationActivity));
            activityIntent.PutExtra("Hotel", GetHotel);
            activityIntent.PutExtra("Name", PersonalInfoName);
            activityIntent.PutExtra("Phone", PersonalInfoPhone);
            activityIntent.PutExtra("Address", PersonalInfoAddress);
            activityIntent.PutExtra("City", PersonalInfoCity);
            activityIntent.PutExtra("State", PersonalInfoState);
            activityIntent.PutExtra("Zip", PersonalInfoZip);
            activityIntent.PutExtra("CheckInDate", CheckInDate);
            activityIntent.PutExtra("CheckInTime", CheckInTime);
            activityIntent.PutExtra("CheckOutDate", CheckOutDate);
            activityIntent.PutExtra("CheckOutTime", CheckOutTime);
            activityIntent.PutExtra("RoomType", RoomType);
            activityIntent.PutExtra("Weekend", Weekend);
            activityIntent.PutExtra("ADA", ADA);
            activityIntent.PutExtra("SpecialNeeds", SpecialNeeds);
            activityIntent.PutExtra("Surcharge", surcharge);
            activityIntent.PutExtra("SpecialNeedsComplete", "Yes");

            //Open ResourceNavigation Activity
            StartActivity(activityIntent);
        }
    }
}