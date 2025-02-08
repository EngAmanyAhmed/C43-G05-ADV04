using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Ball

    {
        public int Id { get; set; } // 1


        private Location location; //0

        public Location Location
        {
            get

            {
                return location;
            }

            set
            {
                if (!location.Equals(value))
                {
                    location = value;
                    if (BallLocationChange is not null)
                        BallLocationChange.Invoke(this);
                }

            }
        }

        public event Action<Ball> BallLocationChange; // null

        public override string ToString()
        {
            return $"Id : {Id} , Location : {Location}";
        }

    }
}
