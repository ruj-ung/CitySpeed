using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMVVMDemo.Model;

namespace WpfMVVMDemo.ViewModel
{
    class MainViewModel
    {
        public List<Person> PersonsList { get; set; }

        public MainViewModel()
        {
            PersonsList = new List<Person>
            {
                new Person
                {
                    Name = "Rujchai",
                    Age = 60,
                },
                new Person
                {
                    Name = "Powwow",
                    Age = 19,
                },

                new Person
                {
                    Name = "Bo",
                    Age = 53,
                },
            };
        }
    }
}
