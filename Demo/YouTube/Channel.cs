using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43-G05-ADV04.YouTube
{
    internal class Channel
    {
        public string Title { get; set; }

        public List<Video> Videos { get; set; } = new List<Video>();

        public void AddVideo(Video video)
        {
            Videos.Add(video);
            // Notify all subscribers
            if (Uploaded is not null)
                Uploaded.Invoke(this, video);
        }

        public Action<Channel, Video> Uploaded;


    }
}
