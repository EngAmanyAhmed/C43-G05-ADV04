using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43-G05-ADV04.YouTube
{
    internal class Subscriber
    {
        public string Name { get; set; }

        public void Notify(Channel channel, Video video)
        {
            Console.WriteLine($" Channel : {channel.Title} is add video : {video} ya {Name} ");
        }
        public override string ToString()
        {
            return $"subscriber Name {Name} ";
        }

    }
}
