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
    [Activity(Label = "PersonalInformationActivity")]
    public class PersonalInformationActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.PersonalInformation);

            // Setup Button
            Button btnPersonalInfoSubmit = (Button)FindViewById(Resource.Id.btnPersonalInfoSubmit);
            btnPersonalInfoSubmit.Click += btnPersonalInfoSubmit_Click;
        }

        private void btnPersonalInfoSubmit_Click(object sender, EventArgs e)
        {
            String GetHotel = Intent.GetStringExtra("Hotel");

            EditText personalInfoName = (EditText)FindViewById(Resource.Id.txtPersonalInfoName);
            EditText personalInfoPhone = (EditText)FindViewById(Resource.Id.txtPersonalInfoPhone);
            EditText personalInfoAddress = (EditText)FindViewById(Resource.Id.txtPersonalInfoAddress);
            EditText personalInfoCity = (EditText)FindViewById(Resource.Id.txtPersonalInfoCity);
            EditText personalInfoState = (EditText)FindViewById(Resource.Id.txtPersonalInfoState);
            EditText personalInfoZip = (EditText)FindViewById(Resource.Id.txtPersonalInfoZip);

            if (personalInfoName.Text != "")
            {
                
                String PersonalInfoName = personalInfoName.Text;
                String PersonalInfoPhone = personalInfoPhone.Text;
                String PersonalInfoAddress = personalInfoAddress.Text;
                String PersonalInfoCity = personalInfoCity.Text;
                String PersonalInfoState = personalInfoState.Text;
                String PersonalInfoZip = personalInfoZip.Text;

                if (personalInfoPhone.Text == "")
                {
                    PersonalInfoPhone = "n/a";
                }
                if (personalInfoAddress.Text == "")
                {
                    PersonalInfoAddress = "n/a";
                }
                if (personalInfoCity.Text == "")
                {
                    PersonalInfoCity = "n/a";
                }
                if (personalInfoState.Text == "")
                {
                    PersonalInfoState = "n/a";
                }
                if (personalInfoZip.Text == "")
                {
                    PersonalInfoZip = "n/a";
                }

                Intent activityIntent = new Intent(this, typeof(ReindersMichaelAssn3.ReservationNavigationActivity));
                activityIntent.PutExtra("Hotel", GetHotel);
                activityIntent.PutExtra("Name", PersonalInfoName);
                activityIntent.PutExtra("Phone", PersonalInfoPhone);
                activityIntent.PutExtra("Address", PersonalInfoAddress);
                activityIntent.PutExtra("City", PersonalInfoCity);
                activityIntent.PutExtra("State", PersonalInfoState);
                activityIntent.PutExtra("Zip", PersonalInfoZip);
                activityIntent.PutExtra("InfoComplete", "Yes");

                //Open ResourceNavigation Activity
                StartActivity(activityIntent);
            }
            else
            {
                Context context = ApplicationContext;
                string text = "Your Name is required to continue";
                Toast toast = Toast.MakeText(context, text,
                    Android.Widget.ToastLength.Long);
                toast.Show();
            };

            
        }
    }
}