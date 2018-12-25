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
    [Activity(Label = "SummaryActivity")]
    public class SummaryActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "Summary" layout resource
            SetContentView(Resource.Layout.Summary);

            //Get the Extras from ReservationNavigation to define values
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
            String Surcharge = Intent.GetStringExtra("Surcharge");
            String RoomPrice = "";
            String ADA = Intent.GetStringExtra("ADA");
            String SpecialNeeds = Intent.GetStringExtra("SpecialNeeds");

            //Declare text views
            TextView tvSummaryName = (TextView)FindViewById(Resource.Id.tvSummaryName);
            TextView tvSummaryPhone = (TextView)FindViewById(Resource.Id.tvSummaryPhone);
            TextView tvSummaryAddress = (TextView)FindViewById(Resource.Id.tvSummaryAddress);
            TextView tvSummaryHotel = (TextView)FindViewById(Resource.Id.tvSummaryHotel);
            TextView tvCheckIn = (TextView)FindViewById(Resource.Id.tvCheckInSummary);
            TextView tvCheckOut = (TextView)FindViewById(Resource.Id.tvCheckOutSummary);
            TextView tvRoomType = (TextView)FindViewById(Resource.Id.tvRoomTypeSummary);
            TextView tvADA = (TextView)FindViewById(Resource.Id.tvADASummary);
            TextView tvSpecialNeeds = (TextView)FindViewById(Resource.Id.tvSpecialNeedsSummary);
            TextView tvRoomPrice = (TextView)FindViewById(Resource.Id.tvRoomPriceSummary);
            TextView tvWeekendRate = (TextView)FindViewById(Resource.Id.tvWeekendRate);
            TextView tvSurcharge = (TextView)FindViewById(Resource.Id.tvSurcharge);
            Button btnFinished = (Button)FindViewById(Resource.Id.btnFinished);
            btnFinished.Click += btnFinished_Click;

            if (Surcharge == "Yes")
            {
                tvSurcharge.Visibility = ViewStates.Visible;
            }


            if (Weekend == "Yes")
            {
                tvWeekendRate.Visibility = ViewStates.Visible;
            }

            tvSummaryName.Text = "Name: " + PersonalInfoName.ToString();
            tvSummaryPhone.Text = "Phone: " + PersonalInfoPhone.ToString();
            tvSummaryAddress.Text = "Address: " + PersonalInfoAddress.ToString() + ", " + PersonalInfoCity.ToString() + ", " + PersonalInfoState.ToString() + " " + PersonalInfoZip.ToString();
            tvSummaryHotel.Text = "Hotel: " + GetHotel.ToString();
            tvCheckIn.Text = "Check-In: " + CheckInDate.ToString() + " @ " + CheckInTime.ToString();
            tvCheckOut.Text = "Check-Out: " + CheckOutDate.ToString() + " @ " + CheckOutTime.ToString();
            tvRoomType.Text =  RoomType.ToString();
            tvADA.Text = "ADA Accessible: " + ADA.ToString();
            tvSpecialNeeds.Text = SpecialNeeds.ToString();
            
            // Code to get the total price
            if (Intent.GetStringExtra("Hotel") == "Main Lodge")
            {
                if (Intent.GetStringExtra("RoomType") == "Standard")
                {
                    tvRoomType.Text = "Room Type: Standard Room";
                    tvRoomPrice.Text = "Price: $285.00 per night";
                    tvWeekendRate.Text = "***Weekend Rate: $342.00 per night";
                    tvSurcharge.Text = " + $25.00 (extra person surcharge)";
                }
                if (Intent.GetStringExtra("RoomType") == "View")
                {
                    tvRoomType.Text = "Room Type: Room w/ View";
                    tvRoomPrice.Text = "Price: $285.00 per night";
                    tvWeekendRate.Text = "***Weekend Rate: $366.00 per night";
                    tvSurcharge.Text = " + $25.00 (extra person surcharge)";
                }
                if (Intent.GetStringExtra("RoomType") == "Executive")
                {
                    tvRoomType.Text = "Room Type: Executive Suite";
                    tvRoomPrice.Text = "Price: $285.00 per night";
                    tvWeekendRate.Text = "***Weekend Rate: $480.00 per night";
                    tvSurcharge.Text = " + $25.00 (extra person surcharge)";
                }
                else
                {
                    Context context = ApplicationContext;
                    string text = "An error has occured. Please start over. (ML)";
                    Toast toast = Toast.MakeText(context, text,
                        Android.Widget.ToastLength.Long);
                    toast.Show();
                }

            }
            if (Intent.GetStringExtra("Hotel") == "Juniper Springs")
            {
                if (Intent.GetStringExtra("RoomType") == "Standard")
                {
                    tvRoomType.Text = "Room Type: Standard Room";
                    tvRoomPrice.Text = "Price: $245.00 per night";
                    tvWeekendRate.Text = "***Weekend Rate: $281.75 per night";
                    tvSurcharge.Text = " + $30.00 (extra person surcharge)";
                }
                if (Intent.GetStringExtra("RoomType") == "View")
                {
                    tvRoomType.Text = "Room Type: Room w/ View";
                    tvRoomPrice.Text = "Price: $265.00 per night";
                    tvWeekendRate.Text = "***Weekend Rate: $304.75 per night";
                    tvSurcharge.Text = " + $30.00 (extra person surcharge)";
                }
                if (Intent.GetStringExtra("RoomType") == "Executive")
                {
                    tvRoomType.Text = "Room Type: Executive Suite";
                    tvRoomPrice.Text = "Price: $360.00 per night";
                    tvWeekendRate.Text = "***Weekend Rate: $414.00 per night";
                    tvSurcharge.Text = " + $30.00 (extra person surcharge)";
                }
                else
                {
                    Context context = ApplicationContext;
                    string text = "An error has occured. Please start over.";
                    Toast toast = Toast.MakeText(context, text,
                        Android.Widget.ToastLength.Long);
                    toast.Show();
                }
            }
            if (Intent.GetStringExtra("Hotel") == "Summit")
            {
                if (Intent.GetStringExtra("RoomType") == "Standard")
                {
                    tvRoomType.Text = "Room Type: Standard Room";
                    tvRoomPrice.Text = "Price: $390.00 per night";
                    tvWeekendRate.Text = "***Weekend Rate: $487.50 per night";
                    tvSurcharge.Text = " + $75.00 (extra person surcharge)";
                }
                if (Intent.GetStringExtra("RoomType") == "View")
                {
                    tvRoomType.Text = "Room Type: Room w/ View";
                    tvRoomPrice.Text = "Price: $475.00 per night";
                    tvWeekendRate.Text = "***Weekend Rate: $593.75 per night";
                    tvSurcharge.Text = " + $75.00 (extra person surcharge)";
                }
                if (Intent.GetStringExtra("RoomType") == "Executive")
                {
                    tvRoomType.Text = "Room Type: Executive Suite";
                    tvRoomPrice.Text = "Price: $700.00 per night";
                    tvWeekendRate.Text = "***Weekend Rate: $875.00 per night";
                    tvSurcharge.Text = " + $75.00 (extra person surcharge)";
                }
                else
                {
                    Context context = ApplicationContext;
                    string text = "An error has occured. Please start over.";
                    Toast toast = Toast.MakeText(context, text,
                        Android.Widget.ToastLength.Long);
                    toast.Show();
                }
            }
            if (Intent.GetStringExtra("Hotel") == "Adventure Cabins")
            {
                if (Intent.GetStringExtra("RoomType") == "Standard")
                {
                    tvRoomType.Text = "Room Type: Standard Room";
                    tvRoomPrice.Text = "Price: $22.00 per night";
                    tvWeekendRate.Text = "***Weekend Rate: $26.40 per night";
                    tvSurcharge.Text = " + $5.00 (extra person surcharge)";
                }
                if (Intent.GetStringExtra("RoomType") == "View")
                {
                    tvRoomType.Text = "Room Type: Room w/ View";
                    tvRoomPrice.Text = "Price: $22.00 per night";
                    tvWeekendRate.Text = "***Weekend Rate: $26.40 per night";
                    tvSurcharge.Text = " + $5.00 (extra person surcharge)";
                }
                if (Intent.GetStringExtra("RoomType") == "Executive")
                {
                    tvRoomType.Text = "Room Type: Executive Suite";
                    tvRoomPrice.Text = "Price: $23.00 per night";
                    tvWeekendRate.Text = "***Weekend Rate: $27.60 per night";
                    tvSurcharge.Text = " + $5.00 (extra person surcharge)";
                }
                else
                {
                    Context context = ApplicationContext;
                    string text = "An error has occured. Please start over.";
                    Toast toast = Toast.MakeText(context, text,
                        Android.Widget.ToastLength.Long);
                    toast.Show();
                }
            }
            else
            {
                Context context = ApplicationContext;
                string text = "An error has occured. Please start over.";
                Toast toast = Toast.MakeText(context, text,
                    Android.Widget.ToastLength.Long);
                toast.Show();
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.FinishAffinity();
        }
    }
}