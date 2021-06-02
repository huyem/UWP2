using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP2.Models;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace UWP2.Services
{
    class MenuService
    {
        private Adapters.Adaper adaper = Adapters.Adaper.GetAdaper();
        public async Task<Models.Menu> GetMenu()
        {

            //lay api va nap vao MNItems
            HttpClient httpClient = new HttpClient(); // ddaay laf hanh dong lAY DU LIEU DE GUI DI
            var response = await httpClient.GetAsync(adaper.GetMenuApi);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync(); //day la string json den day la ta da lay dk chuoidu lieu
                // convert cai string thanh 1 object 
                Menu menu = JsonConvert.DeserializeObject<Menu>(stringContent);
                return menu;
            }
            return null;
        }
    }
}
