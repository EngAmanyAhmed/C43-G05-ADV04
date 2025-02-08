using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43-G05-ADV04.Fifa
{
    internal class Location
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Z { get; set; }

        public override string ToString()
        {
            return $"({X} , {Y} , {Z} ) ";
        }


    }
}
