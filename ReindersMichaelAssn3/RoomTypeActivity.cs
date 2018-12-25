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
    [Activity(Label = "RoomTypeActivity")]
    public class RoomTypeActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "RoomType" layout resource
            SetContentView(Resource.Layout.RoomType);

            // Setup Radio Buttons, Button and TextView
            RadioButton rbStandard = (RadioButton)FindViewById(Resource.Id.rbStandard);
            rbStandard.Click += rbStandard_Click;
            RadioButton rbView = (RadioButton)FindViewById(Resource.Id.rbView);
            rbView.Click += rbView_Click;
            RadioButton rbExecutive = (RadioButton)FindViewById(Resource.Id.rbExecutive);
            rbExecutive.Click += rbExecutive_Click;
            Button btnRoomTypeConfirm = (Button)FindViewById(Resource.Id.btnRoomTypeConfirm);
            btnRoomTypeConfirm.Click += btnRoomTypeConfirm_Click;
            TextView tvRoomTypeSelected = (TextView)FindViewById(Resource.Id.tvRoomTypeSelected);
            CheckBox cbWknd = (CheckBox)FindViewById(Resource.Id.cbWknd);
            cbWknd.Click += cbWknd_Click;

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

            

            // Set Prices in Text of Radio Buttons
            if (GetHotel == "Main Lodge")
            {
                rbStandard.Text = " Standard Room: $285.00/night";
                rbView.Text = " Room w/ View: $305.00/night";
                rbExecutive.Text = " Executive Suite: $400.00/night";
            }
            if (GetHotel == "Juniper Springs")
            {
                rbStandard.Text = " Standard Room: $245.00/night";
                rbView.Text = " Room w/ View: $265.00/night";
                rbExecutive.Text = " Executive Suite: $360.00/night";
            }
            if (GetHotel == "Summit")
            {
                rbStandard.Text = " Standard Room: $390.00/night";
                rbView.Text = " Room w/ View: $475.00/night";
                rbExecutive.Text = " Executive Suite: $700.00/night";
            }
            if (GetHotel == "Adventure Cabins")
            {
                rbStandard.Text = " Standard Room: $22.00/night";
                rbView.Text = " Room w/ View: $22.00/night";
                rbExecutive.Text = " Executive Suite: $23.00/night";
            }
            


        }

        private void cbWknd_Click(object sender, EventArgs e)
        {
            // Setup Radio Buttons, Button and TextView
            RadioButton rbStandard = (RadioButton)FindViewById(Resource.Id.rbStandard);
            rbStandard.Click += rbStandard_Click;
            RadioButton rbView = (RadioButton)FindViewById(Resource.Id.rbView);
            rbView.Click += rbView_Click;
            RadioButton rbExecutive = (RadioButton)FindViewById(Resource.Id.rbExecutive);
            rbExecutive.Click += rbExecutive_Click;
            Button btnRoomTypeConfirm = (Button)FindViewById(Resource.Id.btnRoomTypeConfirm);
            btnRoomTypeConfirm.Click += btnRoomTypeConfirm_Click;
            TextView tvRoomTypeSelected = (TextView)FindViewById(Resource.Id.tvRoomTypeSelected);
            CheckBox cbWknd = (CheckBox)FindViewById(Resource.Id.cbWknd);
            cbWknd.Click += cbWknd_Click;

            // Get established extras
            String GetHotel = Intent.GetStringExtra("Hotel");

            // Set Prices in Text of Radio Buttons
            if (GetHotel == "Main Lodge")
            {
                rbStandard.Text = " Standard Room: $342.00/night";
                rbView.Text = " Room w/ View: $366.00/night";
                rbExecutive.Text = " Executive Suite: $480.00/night";
            }
            if (GetHotel == "Juniper Springs")
            {
                rbStandard.Text = " Standard Room: $281.75/night";
                rbView.Text = " Room w/ View: $304.75/night";
                rbExecutive.Text = " Executive Suite: $414.00/night";
            }
            if (GetHotel == "Summit")
            {
                rbStandard.Text = " Standard Room: $487.50/night";
                rbView.Text = " Room w/ View: $593.75/night";
                rbExecutive.Text = " Executive Suite: $875.00/night";
            }
            if (GetHotel == "Adventure Cabins")
            {
                rbStandard.Text = " Standard Room: $26.40/night";
                rbView.Text = " Room w/ View: $26.40/night";
                rbExecutive.Text = " Executive Suite: $27.60/night";
            }
        }

        private void rbStandard_Click(object sender, EventArgs e)
        {
            TextView tvRoomTypeSelected = (TextView)FindViewById(Resource.Id.tvRoomTypeSelected);
            RadioButton rbStandard = (RadioButton)FindViewById(Resource.Id.rbStandard);
            string room = "Standard";
            tvRoomTypeSelected.Text = room;
            
        }
        private void rbView_Click(object sender, EventArgs e)
        {
            TextView tvRoomTypeSelected = (TextView)FindViewById(Resource.Id.tvRoomTypeSelected);
            RadioButton rbView = (RadioButton)FindViewById(Resource.Id.rbView);
            string room = "View";
            tvRoomTypeSelected.Text = room;
            
            
        }

        private void rbExecutive_Click(object sender, EventArgs e)
        {
            TextView tvRoomTypeSelected = (TextView)FindViewById(Resource.Id.tvRoomTypeSelected);
            RadioButton rbExecutive = (RadioButton)FindViewById(Resource.Id.rbExecutive);
            string room = "Executive";
            tvRoomTypeSelected.Text = room;
            
        }

        private void btnRoomTypeConfirm_Click(object sender, EventArgs e)
        {
            TextView tvRoomTypeSelected = (TextView)FindViewById(Resource.Id.tvRoomTypeSelected);
            CheckBox cbWknd = (CheckBox)FindViewById(Resource.Id.cbWknd);
            string Weekend = "No";
            
            if (cbWknd.Checked == true)
            {
                Weekend = "Yes";
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

            //Setup our new extra to send 
            String RoomType = tvRoomTypeSelected.Text;

            if (tvRoomTypeSelected.Text != "")
            {
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
                activityIntent.PutExtra("RoomTypeComplete", "Yes");

                //Open ResourceNavigation Activity
                StartActivity(activityIntent);
            }
            else
            {
                Context context = ApplicationContext;
                string text = "Please select a Room Type.";
                Toast toast = Toast.MakeText(context, text,
                    Android.Widget.ToastLength.Long);
                toast.Show();
            }
            
        }
    }
}