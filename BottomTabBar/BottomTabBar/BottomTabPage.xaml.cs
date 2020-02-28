using BottomTabBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BottomTabBarDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomTabPage : ContentPage
    {
        public BottomTabPage()
        {
            InitializeComponent();

            List<TabItem> tabs = new List<TabItem>();

            tabs.Add(new TabItem() { Id = 1, Icon = "home_red.png", SelectedIcon = "home_white.png", Name = "Home", });
            tabs.Add(new TabItem() { Id = 2, Icon = "email_red.png", SelectedIcon = "email_white.png", Name = "Email", });
            tabs.Add(new TabItem() { Id = 3, Icon = "moon_red.png", SelectedIcon = "moon_white.png", Name = "Sleep", });
            tabs.Add(new TabItem() { Id = 4, Icon = "headphones_red.png", SelectedIcon = "headphones_white.png", Name = "Music" });
            tabs.Add(new TabItem() { Id = 5, Icon = "man_red.png", SelectedIcon = "man_white.png", Name = "User" });

            BottomTabBarContainer.TabItemsSource = tabs;
        }

        private void BottomTabBarContainer_Tapped(object sender, TabItem e)
        {

        }
    }
}