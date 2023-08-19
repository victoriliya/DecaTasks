using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{
    public class Event
    {
        // Event details
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public string EventStartDate { get; set; }
        public string EventFinishDate { get; set; }
        public int ProfileId { get; set; }
    }
}
