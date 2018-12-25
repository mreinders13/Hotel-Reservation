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
    [Activity(Label = "CheckInOutSetActivity")]
    public class CheckInOutSetActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "CheckInOutDate" layout resource
            SetContentView(Resource.Layout.CheckInOutSet);

            // Setup Buttons and TextViews
            TextView tvCheckInDate = (TextView)FindViewById(Resource.Id.tvCheckInDate);
            TextView tvCheckInTime = (TextView)FindViewById(Resource.Id.tvCheckInTime);
            TextView tvCheckOutDate = (TextView)FindViewById(Resource.Id.tvCheckOutDate);
            TextView tvCheckOutTime = (TextView)FindViewById(Resource.Id.tvCheckOutTime);

            Button btnCheckInDate = (Button)FindViewById(Resource.Id.btnCheckInDate);
            btnCheckInDate.Click += btnCheckInDate_Click;
            Button btnCheckInTime = (Button)FindViewById(Resource.Id.btnCheckInTime);
            btnCheckInTime.Click += btnCheckInTime_Click;
            Button btnCheckOutDate = (Button)FindViewById(Resource.Id.btnCheckOutDate);
            btnCheckOutDate.Click += btnCheckOutDate_Click;
            Button btnCheckOutTime = (Button)FindViewById(Resource.Id.btnCheckOutTime);
            btnCheckOutTime.Click += btnCheckOutTime_Click;
            Button btnCheckInOutConfirm = (Button)FindViewById(Resource.Id.btnCheckInOutConfirm);
            btnCheckInOutConfirm.Click += btnCheckInOutConfirm_Click;
        }



        private void btnCheckInDate_Click(object sender, EventArgs e)
        {
            TextView tvCheckInDate = (TextView)FindViewById(Resource.Id.tvCheckInDate);
            DatePickerFragment frag = DatePickerFragment.NewInstance(ActionHandler);

            frag.Show(FragmentManager, DatePickerFragment.TAG);

            void ActionHandler(DateTime time)
            {
               tvCheckInDate.Text  = time.ToLongDateString();
            }
        }

        private void btnCheckInTime_Click(object sender, EventArgs e)
        {
            TextView tvCheckInTime = (TextView)FindViewById(Resource.Id.tvCheckInTime);
            TimePickerFragment frag = TimePickerFragment.NewInstance(ActionHandler);

            void ActionHandler(DateTime time)
            {
                tvCheckInTime.Text = time.ToLongTimeString();
            }

            frag.Show(FragmentManager, TimePickerFragment.TAG);

        }

        private void btnCheckOutDate_Click(object sender, EventArgs e)
        {
            TextView tvCheckOutDate = (TextView)FindViewById(Resource.Id.tvCheckOutDate);
            DatePickerFragment frag = DatePickerFragment.NewInstance(ActionHandler);

            frag.Show(FragmentManager, DatePickerFragment.TAG);

            void ActionHandler(DateTime time)
            {
                tvCheckOutDate.Text = time.ToLongDateString();
            }
        }

        private void btnCheckOutTime_Click(object sender, EventArgs e)
        {
            TextView tvCheckOutTime = (TextView)FindViewById(Resource.Id.tvCheckOutTime);
            TimePickerFragment frag = TimePickerFragment.NewInstance(ActionHandler);

            void ActionHandler(DateTime time)
            {
                tvCheckOutTime.Text = time.ToLongTimeString();
            }

            frag.Show(FragmentManager, TimePickerFragment.TAG);
            
        }
        private void btnCheckInOutConfirm_Click(object sender, EventArgs e)
        {
            // Setup the textViews for the dates and times we will send through intents 
            TextView tvCheckInDate = (TextView)FindViewById(Resource.Id.tvCheckInDate);
            TextView tvCheckInTime = (TextView)FindViewById(Resource.Id.tvCheckInTime);
            TextView tvCheckOutDate = (TextView)FindViewById(Resource.Id.tvCheckOutDate);
            TextView tvCheckOutTime = (TextView)FindViewById(Resource.Id.tvCheckOutTime);


            // Get the Extras we have so far so we can pass them back again
            String GetHotel = Intent.GetStringExtra("Hotel");
            String PersonalInfoName = Intent.GetStringExtra("Name");
            String PersonalInfoPhone = Intent.GetStringExtra("Phone");
            String PersonalInfoAddress = Intent.GetStringExtra("Address");
            String PersonalInfoCity = Intent.GetStringExtra("City");
            String PersonalInfoState = Intent.GetStringExtra("State");
            String PersonalInfoZip = Intent.GetStringExtra("Zip");

            if (tvCheckInDate.Text != "" && tvCheckInTime.Text != "" && tvCheckOutDate.Text != "" && tvCheckOutTime.Text != "")
            {
                //Setup our new extras to send 
                String CheckInDate = tvCheckInDate.Text.ToString();
                String CheckInTime = tvCheckInTime.Text.ToString();
                String CheckOutDate = tvCheckOutDate.Text.ToString();
                String CheckOutTime = tvCheckOutTime.Text.ToString();

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
                activityIntent.PutExtra("CheckInOutComplete", "Yes");

                //Open ResourceNavigation Activity
                StartActivity(activityIntent);
            }
            else
            {
                Context context = ApplicationContext;
                string text = "Please make sure all dates and times are selected.";
                Toast toast = Toast.MakeText(context, text,
                    Android.Widget.ToastLength.Long);
                toast.Show();
            }
            
        }
    }
    public class TimePickerFragment : DialogFragment,
                  TimePickerDialog.IOnTimeSetListener 
    {
        public static readonly string TAG = "MyTimePickerFragment" +
            typeof(TimePickerDialog).Name.ToUpper();

        Action<DateTime> timeSelectedHandler = delegate { };

        public static TimePickerFragment NewInstance(Action<DateTime> onTimeSelected)
        {
            TimePickerFragment TimeFrag = new TimePickerFragment();
            TimeFrag.timeSelectedHandler = onTimeSelected;
            return TimeFrag;
        }
        public override Dialog OnCreateDialog (Bundle savedInstanceState)
        {
            DateTime currentTime = DateTime.Now;
            TimePickerDialog dialog =
                new TimePickerDialog(Activity, this, currentTime.Hour, currentTime.Minute, false);
            return dialog;
        }
        public void OnTimeSet(TimePicker view, int hourOfDay, int minute)
        {
            DateTime currentTime = DateTime.Now;
            DateTime selectedTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, hourOfDay, minute, 0);
            timeSelectedHandler(selectedTime);
        }
    }
    public class DatePickerFragment : DialogFragment,
              DatePickerDialog.IOnDateSetListener
    {
        // TAG can be any string. It's purpose is to uniquely identify the 
        // fragment.
        public static readonly string TAG = "X:" +
            typeof(DatePickerFragment).Name.ToUpper();


        // Initialize this value to prevent NullReference exceptions.
        //
        // Refer to: https://developer.xamarin.com/api/type/System.Action%3CT%3E/
        //
        // The System.Action data type a delegate (function pointer). We are 
        // back to the different ways to register a function.
        //
        // System.Action (A generic), requires on argument - value type.
        // 
        Action<DateTime> dateSelectedHandler = delegate { };

        // The following is a factory method used to create an instance 
        // of the fragment. It would also be possible to implement this 
        // using a constructor. 
        // 
        public static DatePickerFragment NewInstance(
            Action<DateTime> onDateSelected)
        {
            DatePickerFragment frag = new DatePickerFragment();
            frag.dateSelectedHandler = onDateSelected;
            return frag;
        }

        // The event handler is part of the Activity lifecycle. 
        // While not fully explained yet. Fragments have a lifecycle, 
        // just as activities have a lifecycle. The two are designed to 
        // operate together.
        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            DateTime currently = DateTime.Now;
            DatePickerDialog dialog =
                new DatePickerDialog(Activity,
                this, currently.Year, (currently.Month -1), currently.Day);

            return dialog;
        }

        // The OnDateSet event fires when the user selects a date.
        public void OnDateSet(DatePicker view, int year, int monthOfYear,
            int dayOfMonth)
        {
            // Note: monthOfYear is a value between 0 and 11, not 1 and 12!
            // Create the date.
            DateTime selectedDate = new DateTime(year, monthOfYear + 1, dayOfMonth);

            // The following will raise the event in the parent activity.
            dateSelectedHandler(selectedDate);

        }
    }
}