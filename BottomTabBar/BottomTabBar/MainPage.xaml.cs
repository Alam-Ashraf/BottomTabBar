using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BottomTabBar
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private StackLayout LastSelectedItem;

        private uint _timeOut = 500;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnHomeClick(object sender, EventArgs e)
        {
            AnimateSelectedImage(sender as StackLayout);
        }

        private void OnEmailClick(object sender, EventArgs e)
        {
            AnimateSelectedImage(sender as StackLayout);
        }

        private void OnSleepClick(object sender, EventArgs e)
        {
            AnimateSelectedImage(sender as StackLayout);
        }

        private void OnMusicClick(object sender, EventArgs e)
        {
            AnimateSelectedImage(sender as StackLayout);
        }

        private void OnUserClick(object sender, EventArgs e)
        {
            AnimateSelectedImage(sender as StackLayout);
        }


        private void AnimateSelectedImage(StackLayout stackLayout)
        {
            AnimateLastSelectedImage();

            if (stackLayout != null)
            {
                FrameSelected.IsVisible = true;
                LastSelectedItem = stackLayout;

                Image image = (Image)stackLayout.Children.ElementAt(0);
                Label label = (Label)stackLayout.Children.ElementAt(1);

                if (image != null && label != null)
                {
                    label.IsVisible = true;

                    image.TranslateTo(0, image.Y - 20, _timeOut);
                    image.FadeTo(0, _timeOut);

                    label.TranslateTo(0, 0, _timeOut);
                    label.FadeTo(1, _timeOut);
                    label.FontAttributes = FontAttributes.Bold;

                    SetSelectedImage(label.Text);
                }

                FrameSelected.TranslateTo(stackLayout.X, 0, _timeOut);
            }
        }

        private void SetSelectedImage(string title)
        {
            if (!string.IsNullOrEmpty(title))
            {
                switch (title)
                {
                    case "Home":
                        SelectedImge.Source = ImageSource.FromFile("home_white");
                        break;

                    case "Email":
                        SelectedImge.Source = ImageSource.FromFile("email_white");
                        break;

                    case "Sleep":
                        SelectedImge.Source = ImageSource.FromFile("moon_white");
                        break;

                    case "Music":
                        SelectedImge.Source = ImageSource.FromFile("headphones_white");
                        break;

                    case "User":
                        SelectedImge.Source = ImageSource.FromFile("man_white");
                        break;
                }
            }
        }

        private void AnimateLastSelectedImage()
        {
            if (LastSelectedItem != null)
            {
                Image image = (Image)LastSelectedItem.Children.ElementAt(0);
                Label label = (Label)LastSelectedItem.Children.ElementAt(1);

                if (image != null && label != null)
                {
                    label.IsVisible = true;

                    image.TranslateTo(0, 0, _timeOut);
                    image.FadeTo(1, _timeOut);

                    label.TranslateTo(0, 20, _timeOut);
                    label.FadeTo(0, _timeOut);
                    label.FontAttributes = FontAttributes.None;
                    label.IsVisible = false;
                }
            }
        }
    }
}
