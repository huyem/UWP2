using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP2.Adapters
{
    class Adaper
    {
        private static string baseURL = "https://foodgroup.herokuapp.com";

        // search singleton pattern se co hafm

        private static Adaper instance;
        private  Adaper()
        { 
        }
        public static Adaper GetAdaper()
        {
            if(instance == null)
            {
                instance = new Adaper();
            }
            return instance;
        }

        public string GetMenuApi
        {
            get => String.Format(baseURL + "/api/menu");
        }

    }
}
