namespace mLearning.ViewModels
{
    public class FirstViewModel 
		: BaseViewModel
    {
		private string _hello = "Hello MvvmCross from Xamarin Forms";
        public string Hello
		{ 
			get { return _hello; }
			set { SetProperty(ref _hello, value, () => Hello); }
		}
    }
}
