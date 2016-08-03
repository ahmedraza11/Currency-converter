using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class Modify : Page
    {
        public Modify()
        {
            this.InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = lst.SelectedIndex;

            switch (index)
            {
                case 0:
                    txtName.Text = "American Dollar";
                break;
                case 1:
                txtName.Text = "Pakistani Rupee";
                break;
                case 2:
                txtName.Text = "Indian Rupee";
                break;
                case 3:
                txtName.Text = "Soomalia";
                break;
                case 4:
                txtName.Text = "China Yen";
                break;
                case 5:
                txtName.Text = "Egypt";
                break;
                case 6:
                txtName.Text = "Euro";
                break;
                case 7:
                txtName.Text = "Indonesia";
                break;
                case 8:
                txtName.Text = "Saudi Riyal";
                break;
                case 9:
                txtName.Text = "Dubai Darham";
                break;
            
            
            }
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float val = 254;
            float rel = val / 100;
              
            MessageDialog da = new MessageDialog("result",Math.Round(rel,2).ToString());
            da.ShowAsync();
        }
    }
}
