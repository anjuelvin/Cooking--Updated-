using Cookbook.ObjectModels;
using Cookbook.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

//

namespace Cookbook
{

    public sealed partial class Recipes : Page
    {

        public event Action<Recipes> ImageSelected;
        public StorageFile ImageFile { get; set; }
        private RecipesViewModel recipesViewModel;

        public Recipes()
        {
            this.InitializeComponent();
            this.recipesViewModel = new RecipesViewModel();
        }


        public RecipesViewModel RecipesViewModel
        {
            get { return this.recipesViewModel; }
        }


        public object UniqueId { get; internal set; }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string categoryName = e.Parameter as string;

            if (categoryName != null)
            {
                await recipesViewModel.GetAllRecipesByCategoryAsync(categoryName);
                this.DataContext = recipesViewModel;
            }

            //Show UI Back button if necessary
            if (Frame.CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }
            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }

            //Memory Leak
            byte[] memoryLeak = new byte[10000000];
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

        async public Task LoadImageAsync(StorageFolder folder, string image_file_path)
        {
            var image_file = await folder.GetFileAsync(image_file_path);
            await InternalLoadImageAsync(image_file);
        }


        async private void BrowseImageClicked(object sender, RoutedEventArgs e)
        {
            FileOpenPicker opener = new FileOpenPicker();
            opener.ViewMode = PickerViewMode.Thumbnail;
            opener.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            opener.CommitButtonText = "Select Picture";
            opener.FileTypeFilter.Add(".png");
            opener.FileTypeFilter.Add(".jpg");
            var selected_file = await opener.PickSingleFileAsync();
            if (selected_file != null)
            {
                await InternalLoadImageAsync(selected_file);
                ImageSelected?.Invoke(this);
            }
        }
        private async Task InternalLoadImageAsync(StorageFile selected_file)
        {
            ImageFile = selected_file;
            //display the image
            BitmapImage image = new BitmapImage();
            img_control.Source = image;
            var stream = await selected_file.OpenReadAsync();
            await image.SetSourceAsync(stream);
        }

        
    }
}
