using WpfApp1.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class MainPageViewModel
    {
        public User user { get; set; }
        public User2 user2 { get; set; }

        public MainPageViewModel()
        {
            user = new User
            {
                FirstName = "Frosty",
                LastName = "The Snowman"
            };

            user2 = new User2
            {
                FirstName = "John",
                LastName = "Dow"
            };
        }
    }
}