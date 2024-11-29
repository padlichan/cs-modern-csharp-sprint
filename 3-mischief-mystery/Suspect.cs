using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3_mischief_mystery
{
    internal class Suspect(int apartmentNumber, string name,int age, string height, bool stillASuspect)
    {
        public int ApartmentNumber { get; set; } = apartmentNumber;
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public string Height { get; set; } = height;

        public bool StillASuspect { get; set; } = stillASuspect;


    }
}
