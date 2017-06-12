using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace mcforms.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MainViewModel()
        {
        }
        
        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }
        
        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "XAML Forms & MvvmCross 5";
        }

        private string _text = "XAML Forms & MvvmCross 5";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}