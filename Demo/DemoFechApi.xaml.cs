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
using UWP2.Models;
using UWP2.Services;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json; 


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP2.Demo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DemoFechApi : Page
    {
        public DemoFechApi()
        {
            this.InitializeComponent();
            //co 1 danhsach cac icon truyeen vao
            // ta lay date tu api

            //hom trk lam 

            //List<Item> list = new List<Item>();
            //list.Add(new Item { id = 1, icon = "", name = "burger" });
            //list.Add(new Item { id = 2, icon = "", name = "burger1" });
            // list.Add(new Item { id = 3, icon = "", name = "burger3" });
            //MNItems.Items.Add(list);

            /// dung ham getmenu de lay menu o api ve
            GetMenu();
        }
        public async void GetMenu()
        {
            //lay api va nap vao MNItems
            //HttpClient httpClient = new HttpClient(); // ddaay laf hanh dong lAY DU LIEU DE GUI DI
            //var response =await httpClient.GetAsync("https://foodgroup.herokuapp.com/api/menu");

            /* if(response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync(); //day la string json den day la ta da lay dk chuoidu lieu
                // convert cai string thanh 1 object 
                Menu menu = JsonConvert.DeserializeObject<Menu>(stringContent);
                MNItems.ItemsSource = menu.data;
            }
            */
            // dung menuservice

            MenuService service = new MenuService();
            Menu menu = await service.GetMenu();
            if(menu != null)
            {
                MNItems.ItemsSource = menu.data;
            }
         
        }

    }
}
