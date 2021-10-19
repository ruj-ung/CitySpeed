using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMVVMDemo.Model;

namespace WpfMVVMDemo.ViewModel
{
    public class myviewmodel
    {
        public RoadInfomation roadinfo { get; set; }

        public myviewmodel()
        {
            roadinfo = new RoadInfomation
            {
                Userreference = "Rujchai",
            };
        }
    }
}
