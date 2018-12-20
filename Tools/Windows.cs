using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Personnel.Tools
{
    internal static class Windows
    {
        static Windows()
        {
            
        }

        public static bool existPath()
        {
            bool find = false;
            if (File.Exists(Path.Combine(configDir,"config.json")))
            {
                find = true;
            }

            return find;
        }

        private  static string configDir = Path.Combine(Directory.GetCurrentDirectory(),"configs");
    }
}
