using System;
using System.Windows.Input;
using Plugin.Share;

namespace PerfectEar.ViewModel
{
    public class PhoneViewModel : BaseViewModel
    {
        public PhoneViewModel()
        {
            Title = "Phone";
            OpenWebCommand = new OpenWeb();
        }


        /// <summary>
        /// Command to open browser to xamarin.com
        /// </summary>
        public ICommand OpenWebCommand { get; }
    }

    
}