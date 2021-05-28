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
using UWP2.Lab;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP2.Lab.Lab3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Contact : Page
    {
        public Contact()
        {
            this.InitializeComponent();
        }

 
        private void ListContact_Loaded(object sender, RoutedEventArgs e)
        {
            Lab3class lab3Class = new Lab3class(input1.Text, "", "" );
            ListContact.Items.Add(lab3Class);

        }

        
        private void Button_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            backpage.Navigate(typeof(Lab.Lab3.Home));
        }
    }
}
