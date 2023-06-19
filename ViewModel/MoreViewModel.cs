using System;
using System.Windows.Input;
using MetaBanking.ViewModel;

namespace MetaBanking.ViewModel
{
    public class MoreViewModel : BaseViewModel
    {
        public MoreViewModel()
        {
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
