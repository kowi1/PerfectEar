using Android.OS;
using Android.Views;
using Android.Widget;
using PerfectEar.ViewModel;

namespace PerfectEar.Droid
{
    public class PhoneFragment : Android.Support.V4.App.Fragment, IFragmentVisible
    {

        public static PhoneFragment NewInstance() =>
            new PhoneFragment { Arguments = new Bundle() };

        public PhoneViewModel ViewModel { get; set; }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        Button learnMoreButton;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.fragment_phone, container, false);
            ViewModel = new PhoneViewModel();
            learnMoreButton = view.FindViewById<Button>(Resource.Id.button_learn_more1);
            return view;
        }

        public override void OnStart()
        {
            base.OnStart();
            learnMoreButton.Click += LearnMoreButton_Click;
        }

        private void LearnMoreButton_Click(object sender, System.EventArgs e)
        {
            ViewModel.OpenWebCommand.Execute(null);
        }

        public override void OnStop()
        {
            base.OnStop();
            learnMoreButton.Click -= LearnMoreButton_Click;
        }

        public void BecameVisible()
        {
        }
    }
}

