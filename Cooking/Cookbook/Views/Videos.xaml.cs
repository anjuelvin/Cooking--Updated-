using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Cookbook.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Videos : Page
    {
        public Videos()
        {
            this.InitializeComponent();
            Uri u = new Uri("https://www.youtube.com/watch?v=PmqdA05OXuI");
            VideoView.Navigate(u);

            Uri a = new Uri("https://www.youtube.com/watch?v=ouQGGCIGBSQ");
            VideoView1.Navigate(u);

            Uri b = new Uri("https://www.youtube.com/watch?v=iIVJN0Yz1Y0");
            VideoView2.Navigate(b);

            Uri c = new Uri("https://www.youtube.com/watch?v=kKvMUNndimA");
            VideoView3.Navigate(c);
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
    }
}
