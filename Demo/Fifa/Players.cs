using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Players
    {
        public string Name { get; set; }
        public string TeamName { get; set; }

        // Call Back Function
        public void Run(Ball ball)
        {
            Console.WriteLine($"Player {Name} is running.....at  {ball}");
        }
        public override string ToString()
        {
            return $"Player Name : {Name} , Team Name : {TeamName}";
        }

    }
}
