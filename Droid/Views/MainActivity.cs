using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Core.Views;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Views;
using MvvmCross.Forms.Core;
using MvvmCross.Forms.Droid.Presenters;
using MvvmCross.Platform;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using MvvmCross.Core;
using MvvmCross.Core.ViewModels;
using Android.Content;
using mcforms.ViewModels;
using mcforms.Views;

namespace mcforms.Droid.Views
{
    [Activity(Label = "MainActivity", Theme = "@style/splashscreen", Icon = "@drawable/icon", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : FormsApplicationActivity
    {
        private IMvxAndroidActivityLifetimeListener _lifetimeListener;

        protected override void OnCreate(Bundle bundle)
        {
			base.OnCreate(bundle);

			Forms.Init(this, bundle);
			var mvxFormsApp = new MvxFormsApplication();
			LoadApplication(mvxFormsApp);

			var presenter = (MvxFormsDroidPagePresenter)Mvx.Resolve<IMvxViewPresenter>();
			presenter.MvxFormsApp = mvxFormsApp;

            Mvx.Resolve<IMvxViewsContainer>()?.Add(typeof(MainViewModel), typeof(MainView));

			Mvx.Resolve<IMvxAppStart>().Start();
			_lifetimeListener = Mvx.Resolve<IMvxAndroidActivityLifetimeListener>();
			_lifetimeListener.OnCreate(this);

        }

		protected override void OnDestroy()
		{
			_lifetimeListener.OnDestroy(this);
			base.OnDestroy();
		}

		protected override void OnNewIntent(Intent intent)
		{
			base.OnNewIntent(intent);
			_lifetimeListener.OnViewNewIntent(this);
		}

		protected override void OnResume()
		{
			base.OnResume();
			_lifetimeListener.OnResume(this);
		}

		protected override void OnPause()
		{
			_lifetimeListener.OnPause(this);
			base.OnPause();
		}

		protected override void OnStart()
		{
			base.OnStart();
			_lifetimeListener.OnStart(this);
		}

		protected override void OnRestart()
		{
			base.OnRestart();
			_lifetimeListener.OnRestart(this);
		}

		protected override void OnStop()
		{
			_lifetimeListener.OnStop(this);
			base.OnStop();
		}
    }
}
