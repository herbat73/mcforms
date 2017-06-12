using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Platform;
using mcforms;
using MvvmCross.Core.Views;

namespace mcforms.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

		protected override IMvxAndroidViewPresenter CreateViewPresenter()
		{
			var presenter = new HybridDroidViewPresenter();
			Mvx.RegisterSingleton<IMvxViewPresenter>(presenter);
			return presenter;
		}
    }
}
