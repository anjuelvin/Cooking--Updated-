using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;



namespace Cookbook.Views
{
  
    public sealed partial class InstructionPicture : Page
    {
        public InstructionPicture()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
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
        private void CategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Categories));
        }

        private void RecipesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Recipes));
        }
        private void VideosButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Videos));
        }

        private async void openButton_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".png");
            StorageFile file = await openPicker.PickSingleFileAsync();
            if (file != null)
            {
                var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                var image = new BitmapImage();
                image.SetSource(stream);
                imageView.Source = image;
            }
            else
            {
                //  
            }
        }

    }
}
