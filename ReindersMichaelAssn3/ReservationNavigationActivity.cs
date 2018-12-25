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
    [Activity(Label = "ResourceNavigationActivity")]
    public class ReservationNavigationActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "ReservationNavigation" layout resource
            SetContentView(Resource.Layout.ReservationNavigation);

            TextView tvReservationNavigation = (TextView)FindViewById(Resource.Id.tvReservationNavigation);

            //Get the Extra from MainActivity to define the Hotel
            String GetHotel = Intent.GetStringExtra("Hotel");
            tvReservationNavigation.Text = "Please fill out the forms below to complete your " + GetHotel.ToString() + " reservation";

            // Get Validation that Forms are completed
            String InfoComplete = Intent.GetStringExtra("InfoComplete");
            String CheckInOutComplete = Intent.GetStringExtra("CheckInOutComplete");
            String RoomTypeComplete = Intent.GetStringExtra("RoomTypeComplete");
            String SpecialNeedsComplete = Intent.GetStringExtra("SpecialNeedsComplete");

            

            //Set the Buttons up 
            Button btnPersonalInformationSelect = (Button)FindViewById(Resource.Id.btnPersonalInformationSelect);
            btnPersonalInformationSelect.Click += btnPersonalInformationSelect_Click;

            Button btnCheckInOutSelect = (Button)FindViewById(Resource.Id.btnCheckInOutSelect);
            btnCheckInOutSelect.Enabled = false;
            btnCheckInOutSelect.Click += btnCheckInOutSelect_Click;

            Button btnRoomTypeSelect = (Button)FindViewById(Resource.Id.btnRoomTypeSelect);
            btnRoomTypeSelect.Enabled = false;
            btnRoomTypeSelect.Click += btnRoomTypeSelect_Click;

            Button btnSpecialNeedsSelect = (Button)FindViewById(Resource.Id.btnSpecialNeedsSelect);
            btnSpecialNeedsSelect.Enabled = false;
            btnSpecialNeedsSelect.Click += btnSpecialNeedsSelect_Click;

            Button btnSummarySelect = (Button)FindViewById(Resource.Id.btnSummarySelect);
            btnSummarySelect.Enabled = false;
            btnSummarySelect.Click += btnSummarySelect_Click;


            // Enable Buttons when forms are completed
            if (InfoComplete == "Yes")
            {
                btnCheckInOutSelect.Enabled = true;
            }
            if (CheckInOutComplete == "Yes")
            {
                btnRoomTypeSelect.Enabled = true;
            }
            if (RoomTypeComplete == "Yes")
            {
                btnSpecialNeedsSelect.Enabled = true;
            }
            if (SpecialNeedsComplete == "Yes")
            {
                btnSummarySelect.Enabled = true;
            }

        }



        private void btnPersonalInformationSelect_Click(object sender, EventArgs e)
        {
            String GetHotel = Intent.GetStringExtra("Hotel");

            Intent activityIntent = new Intent(this, typeof(ReindersMichaelAssn3.PersonalInformationActivity));
            activityIntent.PutExtra("Hotel", GetHotel);
            //Open ResourceNavigation Activity
            StartActivity(activityIntent);
        }
        
        private void btnCheckInOutSelect_Click(object sender, EventArgs e)
        {
            String GetHotel = Intent.GetStringExtra("Hotel");
            String PersonalInfoName = Intent.GetStringExtra("Name");
            String PersonalInfoPhone = Intent.GetStringExtra("Phone");
            String PersonalInfoAddress = Intent.GetStringExtra("Address");
            String PersonalInfoCity = Intent.GetStringExtra("City");
            String PersonalInfoState = Intent.GetStringExtra("State");
            String PersonalInfoZip = Intent.GetStringExtra("Zip");

            Intent activityIntent = new Intent(this, typeof(ReindersMichaelAssn3.CheckInOutSetActivity));
            activityIntent.PutExtra("Hotel", GetHotel);
            activityIntent.PutExtra("Name", PersonalInfoName);
            activityIntent.PutExtra("Phone", PersonalInfoPhone);
            activityIntent.PutExtra("Address", PersonalInfoAddress);
            activityIntent.PutExtra("City", PersonalInfoCity);
            activityIntent.PutExtra("State", PersonalInfoState);
            activityIntent.PutExtra("Zip", PersonalInfoZip);

            //Open CheckInOutDateActivity
            StartActivity(activityIntent);
        }

        private void btnRoomTypeSelect_Click(object sender, EventArgs e)
        {
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

            Intent activityIntent = new Intent(this, typeof(ReindersMichaelAssn3.RoomTypeActivity));
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

            //Open CheckInOutDateActivity
            StartActivity(activityIntent);
        }

        private void btnSpecialNeedsSelect_Click(object sender, EventArgs e)
        {
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

            Intent activityIntent = new Intent(this, typeof(ReindersMichaelAssn3.SpecialNeedsActivity));
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

            //Open CheckInOutDateActivity
            StartActivity(activityIntent);
        }

        private void btnSummarySelect_Click(object sender, EventArgs e)
        {
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
            String ADA = Intent.GetStringExtra("ADA");
            String SpecialNeeds = Intent.GetStringExtra("SpecialNeeds");
            String Surcharge = Intent.GetStringExtra("Surcharge");

            Intent activityIntent = new Intent(this, typeof(ReindersMichaelAssn3.SummaryActivity));
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
            activityIntent.PutExtra("Surcharge", Surcharge);

            //Open Summary Screen
            StartActivity(activityIntent);
        }
    }
}