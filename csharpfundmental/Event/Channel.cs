using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Channel
    {
        public string Name { get; set; }
        public List <Videos> Videos { get; set; } = new List<Videos>(); 


        public void AddVideo (Videos videos)
        {
            Videos.Add(videos);
            if (AdditionEvent is not null)
            {
                AdditionEvent.Invoke(this ,videos);
            }
        }
        public Action<Channel, Videos> AdditionEvent;
    }
}
