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

namespace CurrencyConverter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            List<Data> da = new List<Data>()
            {
                new Data{Image="Assets/1.jpg"},
                new Data{Image="Assets/2.jpg"},
                new Data{Image="Assets/3.jpg"},
                new Data{Image="Assets/Pak Rupee.jpg"},
                new Data{Image="Assets/Indian Rupee.jpg"},
                new Data{Image="Assets/6.jpg"},
                new Data{Image="Assets/7.jpg"},
                new Data{Image="Assets/8.jpg"},
                new Data{Image="Assets/9.jpg"},
                new Data{Image="Assets/China Yen.jpg"},
                new Data{Image="Assets/22.jpg"},
                new Data{Image="Assets/Dubai Darham.jpg"},
                new Data{Image="Assets/Egypt.jpg"},
                new Data{Image="Assets/15.jpg"},
                new Data{Image="Assets/16.jpg"},
                new Data{Image="Assets/Euro.jpg"},
                new Data{Image="Assets/5.jpg"},
                new Data{Image="Assets/France.jpg"},
                new Data{Image="Assets/20.jpg"},
                new Data{Image="Assets/21.jpg"},
                new Data{Image="Assets/22.jpg"},
                new Data{Image="Assets/23.jpg"},
                new Data{Image="Assets/4.jpg"},
                new Data{Image="Assets/25.jpg"},
                new Data{Image="Assets/Indonesia.jpg"},
                new Data{Image="Assets/27.jpg"},
                new Data{Image="Assets/28.jpg"},
                new Data{Image="Assets/29.jpg"},
                new Data{Image="Assets/Soomalia.jpg"},
                new Data{Image="Assets/20.jpg"},
           

                

            };
            display.DataContext = da;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Convert_page));
        }
    }
}
