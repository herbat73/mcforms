using System;
using System.Collections.Generic;
using Android.App;
using MvvmCross.Droid.Views;
using MvvmCross.Forms.Droid.Presenters;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;
using mcforms.ViewModels;
using MvvmCross.Core.ViewModels;
using mcforms.Droid.Views;

namespace mcforms.Droid
{
    class HybridDroidViewPresenter : MvxFormsDroidPagePresenter
	{
		private readonly MvxAndroidViewPresenter _androidPesenter;
		private readonly List<Type> _androidViews;
		protected Activity Activity => Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;

		public HybridDroidViewPresenter()
		{
			_androidPesenter = new MvxAndroidViewPresenter();
			_androidViews = new List<Type>
            {
			    typeof (MainViewModel)
		    };
		}

		
		public override void ChangePresentation(MvxPresentationHint hint)
		{
			//if (Activity.GetType() != typeof(MainActivity))
			//{
				// if we are not on the Forms Activity, we assume, we are on an Android Activity
				_androidPesenter.ChangePresentation(hint);
			//	return;
			//}

			//base.ChangePresentation(hint);
		} 

		public override void Show(MvxViewModelRequest request)
		{
			if (_androidViews.Contains(request.ViewModelType))
			{
				_androidPesenter.Show(request);
				return;
			}

			base.Show(request);
		}
	}
}
