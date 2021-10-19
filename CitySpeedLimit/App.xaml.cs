using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CitySpeedLimit
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // here you take control
            var oledb12Installed = new System.Data.OleDb.OleDbEnumerator()
                .GetElements().AsEnumerable()
                .Any(x => x.Field<string>("SOURCES_NAME") ==
                    "Microsoft.ACE.OLEDB.12.0");
            if (!oledb12Installed)
                MessageBox.Show("Please install Microsoft.ACE.OLEDB.12.0. [64-Bit]");
        }
    }
}
