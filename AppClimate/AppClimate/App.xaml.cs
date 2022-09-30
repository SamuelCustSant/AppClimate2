using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("LexendDeca-Light.ttf", Alias = "Light")]
[assembly: ExportFont("LexendDeca-Regular.ttf", Alias = "Regular")]
[assembly: ExportFont("LexendDeca-SemiBold.ttf", Alias = "SemiBold")]
namespace AppClimate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
