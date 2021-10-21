using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace KLimits
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("th-TH");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("th-TH");
            //var currentCulture = Thread.CurrentThread.CurrentCulture.Name;
            //var ci = new CultureInfo(currentCulture)
            //{
            //    NumberFormat = { NumberDecimalSeparator = "," },
            //    DateTimeFormat = { DateSeparator = "." }
            //};
            //Thread.CurrentThread.CurrentCulture = ci;
            //Thread.CurrentThread.CurrentUICulture = ci;

            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));

            base.OnStartup(e);
        }
    }
}
