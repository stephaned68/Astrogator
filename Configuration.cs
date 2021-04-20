using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Astrogator
{
    public class Configuration
    {
        private static Font baseFont;

        public static Font BaseFont
        {
            get
            {
                if (baseFont == null)
                    baseFont = new Font("Century Gothic", 10);
                return baseFont;
            }
        }

        public static string DataDirectory
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Astrogator");
            }
        }
    }
}
