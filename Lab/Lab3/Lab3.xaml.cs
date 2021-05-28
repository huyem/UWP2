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

namespace UWP2.Lab.Lab3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Lab3 : Page
    {
        public Lab3()
        {
            this.InitializeComponent();
        }

        private void home_Loaded(object sender, RoutedEventArgs e)
        {
            hm.Items.Add(new Class2 { Menutrangchu = "Home", Trangchu = "Home" });
            hm.Items.Add(new Class2 { Menutrangchu = "Contact", Trangchu = "Contact" });
            hm.Items.Add(new Class2 { Menutrangchu = "Customer", Trangchu = "Customer" });
            hm.Items.Add(new Class2 { Menutrangchu = "Email", Trangchu = "Email" });
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Class2 class2 = hm.SelectedItem as Class2;
            switch (class2.Trangchu)
            {
                case "Home":
                    MainContent.Navigate(typeof(Lab.Lab3.Home));
                    break;
                case "Contact":
                    MainContent.Navigate(typeof(Lab.Lab3.Contact));

                    break;
                case "Customer":
                    MainContent.Navigate(typeof(Lab.Lab3.Customer));

                    break;
                case "Email":
                    MainContent.Navigate(typeof(Lab.Lab3.Email));

                    break;
            }
        }
    }
}
