using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP2.Models
{
    class Class1
    {
        private string email;
        private string titell;
        private string content;

        public Class1(string email, string titell, string content)
        {
            Email = email;
            Titell = titell;
            Content = content;
        }

        public string Email { get => email; set => email = value; }
        public string Titell { get => titell; set => titell = value; }
        public string Content { get => content; set => content = value; }
    }
}

