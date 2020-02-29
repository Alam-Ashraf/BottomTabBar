using BottomTabBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BottomTabBarDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       
        private void OnFixedTabClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FixedTabPage());
        }

        private void OnScrollableTabClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScrollableTabPage());
        }
    }
}
