using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC43-G05-ADV04.Fifa
{
    internal class Refree
    {
        public string Name { get; set; }

        public void Look(Ball ball)
        {
            Console.WriteLine($"Refree {Name} is Looking at Ball {ball}");
        }
        public override string ToString()
        {
            return $"Refree Name : {Name} ";
        }

    }
}
