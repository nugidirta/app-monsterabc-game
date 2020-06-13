using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace MonsterABC.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Versi";

            OpenFBCommand = new Command(() => Device.OpenUri(new Uri("https://www.facebook.com/Retro-Apps-614484672288060/")));
            OpenInstaCommand = new Command(() => Device.OpenUri(new Uri("https://www.instagram.com/retroapptech/")));
            OpenTwittCommand = new Command(() => Device.OpenUri(new Uri("https://twitter.com/nugidirta")));
            OpenPlayCommand = new Command(() => Device.OpenUri(new Uri("https://play.google.com/store/apps/dev?id=5510700109537455120")));

        }

        public ICommand OpenFBCommand { get; }
        public ICommand OpenInstaCommand { get; }
        public ICommand OpenTwittCommand { get; }
        public ICommand OpenPlayCommand { get; }
    }
}