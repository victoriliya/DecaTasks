using Microsoft.EntityFrameworkCore;
using MyProfile.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{
    public class EventRepository : IEventRepository
    {
        private readonly MyProfileDbContext _myProfileDbContext;

        public EventRepository(MyProfileDbContext myProfileDbContext)
        {
            _myProfileDbContext = myProfileDbContext;
        }
        public IEnumerable<Event> GetEvents
        {
            get
            {
                return _myProfileDbContext.Events.ToList();
            }
        }
 

    public bool CreateEvent(Event myevent)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEvent(int eventId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEvent(int eventId)
        {
            throw new NotImplementedException();
        }
    }
}
