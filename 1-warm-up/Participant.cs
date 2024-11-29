using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_warm_up
{
    internal class Participant (string name, string hometown)
    {
        public string Name { get; set; } = name;
        public string Hometown { get; set; } = hometown;
    

           
        public (string, string , int) getScore()
        {
            int rand = new Random().Next(0, 100);
            return (Name, Hometown, rand);
        }
    }
}
