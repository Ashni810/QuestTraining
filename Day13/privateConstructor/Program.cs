using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateConstructor
{
    class AppSettings
    {
        public static string Version => "1.0.0";
        public static string ProjectUrl => "https://github.com/";

        private AppSettings() { }
        internal class Program
        {
            static void Main(string[] args)
            {
                var s = new AppSettingsReader();
            }
        }
    }
}
