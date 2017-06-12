using System;
using System.Collections.Generic;
using MvvmCross.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using mcforms.ViewModels;

namespace mcforms.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
		MainViewModel vm;
		MainViewModel ViewModel => vm ?? (vm = BindingContext as MainViewModel);

        public MainView()
        {
            InitializeComponent();
        }

    }
}
