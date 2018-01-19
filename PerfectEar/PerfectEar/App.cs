using PerfectEar.Helpers;
using PerfectEar.Interfaces;
using PerfectEar.Services;
using PerfectEar.Model;

namespace PerfectEar
{
    public partial class App
    {
        public App()
        {
        }

        public static void Initialize()
        {
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
        }
    }
}