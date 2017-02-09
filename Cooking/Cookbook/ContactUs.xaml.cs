using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.ApplicationSettings;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Core;
using Windows.Devices.Geolocation;
using Windows.Services.Maps;
using Windows.UI.Xaml.Controls.Maps;


namespace Cookbook
{
   
    public sealed partial class ContactUs : Page
    {
        public ContactUs()
        {
            this.InitializeComponent();
            myMap.Loaded += MyMap_Loaded;

        }

        private async void MyMap_Loaded(object sender, RoutedEventArgs e)
        {
            // center on Notre Dame Cathedral       
            var center =
                new Geopoint(new BasicGeoposition()
                {
                    Latitude = 48.8530,
                    Longitude = 2.3498

                });

            // retrieve map
            await myMap.TrySetSceneAsync(MapScene.CreateFromLocationAndRadius(center, 3000));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //Show UI Back button if necessary
            if (Frame.CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }
            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }

            base.OnNavigatedTo(e);
            this.DataContext = e.Parameter;
        }
    }
}
