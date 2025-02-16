using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Subscriber
    {
        public string Name { get; set; }
        public void Notify (Channel channel , Videos video)
        {
            Console.WriteLine($"{channel.Name} Channel added new video {video.Title}");
        }
    }
}
