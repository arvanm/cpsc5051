using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voluncheer.Models;

namespace Voluncheer.Backend
{
    interface IEventRepository
    {
        EventModel Create(EventModel data);
        EventModel Read(String id);
        EventModel Update(EventModel data);
        Boolean Delete(String id);
        List<EventModel> Index();
    }
}
