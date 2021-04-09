using System;
using System.IO;

namespace Astrogator
{
    public class Configuration
    {
        public static string DataDirectory
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Astrogator");
            }
        }
    }
}
