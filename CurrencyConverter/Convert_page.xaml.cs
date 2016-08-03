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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using Windows.UI.Popups;
using SQLite;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CurrencyConverter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    class currency
    {
        public String C_Name { get; set; }
        public float value { get; set; }
    }
    public sealed partial class Convert_page : Page
    {
        SQLiteAsyncConnection con;
        int num;
        public  Convert_page()
        {
            this.InitializeComponent();
       //     CreateDatabase();
           
            table();
            ddata();
            //  CurrencyData();
          //  SQLiteCommand check = new SQLiteCommand("select * from ", con);
          
           
        }
        public async void table()
        {
            var path = ApplicationData.Current.LocalFolder.Path + @"\MyDb";
            con = new SQLiteAsyncConnection(path);
            await con.CreateTableAsync<currency>();
       
        }
        private async void ddata()
        {
            num = await con.ExecuteAsync("select * from currency where value >= 1;");
            MessageDialog msg = new MessageDialog("This is total number of data into currency table", num.ToString());
            await msg.ShowAsync();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void Combo_B_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String name = Combo_B.SelectedItem.ToString();
            StorageFile file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("Assets\\"+name+".jpg");
            var a = await file.OpenAsync(FileAccessMode.Read);
            BitmapImage img = new BitmapImage();

            img.SetSource(a);
           Img_B.Source = img;

           int val = Combo_B.SelectedIndex;
           switch (val)
           {
               case 0:
                   txt_B.Text = "104.45";
                   break;
               case 1:
                   txt_B.Text = "134.92";
                   break;
               case 2:
                   txt_B.Text = "154.87";
                   break;
                       

           }
             }

        private async void Combo_A_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                String name = Combo_A.SelectedItem.ToString();
                StorageFile file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("Assets\\" + name + ".jpg");
                var b = await file.OpenAsync(FileAccessMode.Read);
                BitmapImage img = new BitmapImage();

                img.SetSource(b);
                Img_A.Source = img;
            }
            catch (Exception edd)
            {
                MessageDialog da = new MessageDialog("There are some exceptions or not a valid currency","Invalid Currency");
                 da.ShowAsync();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Modify));
        }
        private async void CurrencyData()
        {
            
            await con.QueryAsync<currency>("Insert into currency (C_Name,value) values ('china',14.4) , ('Egypt',38.45) , ('France',92.87) , ('Euro',134.92) , ('Indonasia',7.65) , ('Soomalia',12.32) , ('Pak_Rupee',1.00) , ('Indain Rupee',1.45) , ('Saudi_Riyal',27.78) , ('Dubai_Darham',28.15);"); 
                //, (" + TEgypt.Text + ",00.0)  , (" + TFrance.Text + ",00.0)  , (" + TEuro.Text + ",00.0)  , (" + TIndonasia.Text + ",00.0)  , (" + TSoomalia.Text + ",00.0)  , (" + TPakRupee.Text + ",00.0)  , (" + TIndianRupee.Text + ",00.0)  , (" + TSaudiRiyal.Text + ",00.0)  , (" + TDubaiDarham.Text + ",00.0);  ");
        }
        private async void Convertion()
        {
            //int combo_a = Combo_A.SelectedIndex;
            //int combo_b = Combo_B.SelectedIndex;

            //await con.QueryAsync<currency>("Select * from currency where ");
            //if(Convert.ToInt32(txt_A.Text) >= Convert.ToInt32(txt_B.Text)){

 //           }

        }
    }
}
