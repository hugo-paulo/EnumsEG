using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEnuma
{
    internal class MusicAlbum
    {
        public MusicAlbum(string name, string year)
        {
            Name = name;
            Year = year;
        }
        public string Name { get; set; }
        public string Year { get; set; }
    }
}
