using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{
    public interface IEventRepository
    {
        IEnumerable<Event> GetEvents { get; }

        bool CreateEvent(Event myevent);
        bool UpdateEvent(int eventId);
        bool DeleteEvent(int eventId);
    }
}
