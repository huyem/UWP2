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
using UWP2.Models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP2.Demo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Layout : Page
    {
        public Layout()
        {
            this.InitializeComponent();
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
           

            MN.Items.Add(new MenuItem { Menu1 = "Home2", MenuPgae1 = "home2" });
            MN.Items.Add(new MenuItem { Menu1 = "Category", MenuPgae1 = "Category" });
           
          

        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem item = MN.SelectedItem as MenuItem; // ddaay lafobiect
            switch (item.MenuPgae1)
            {
                case "home2": MainFrame.Navigate(typeof(Demo.Home),"Day la trang chu");
                    break;
                case "Category": MainFrame.Navigate(typeof(Demo.Category),"Day la trangcategory");
                    break;

            }
          
        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
