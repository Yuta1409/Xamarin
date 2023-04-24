using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForm_SQLite.Repositories;

namespace XamarinForm_SQLite
{
    public partial class App : Application
    {
        protected string dbPath = Path.Combine(FileSystem.AppDataDirectory, "database.db3");
        public static HumeurRepository HumeurRepository { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPage1();

            HumeurRepository = new HumeurRepository(dbPath);
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
