using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Voluncheer.Models;

namespace Voluncheer.Backend
{
    public class EventRepositoryMock : IEventRepository
    {
        public List<EventModel> dataset = new List<EventModel>();

        public EventRepositoryMock()
        {
            Initialize();
        }
        public EventModel Create(EventModel data)
        {
            dataset.Add(data);
            return data;
        }

        public bool Delete(string id)
        {
            var myData = Read(id);
            if (myData == null)
            {
                return false;
            }

            var myResult = dataset.Remove(myData);
            return myResult;
        }

        public List<EventModel> Index()
        {
            return dataset;
        }

        public EventModel Read(string id)
        {
            var myData = dataset.First(m => m.ID == id);
            return myData;
        }

        public EventModel Update(EventModel data)
        {
            var myData = Read(data.ID);
            if (myData == null)
            {
                return null;
            }

            myData.Update(data);
            return data;
        }

        public void Initialize()
        {
            dataset.Add(new EventModel
            {
                Type = EventType.Practice,
                Location = "Sonora High School",
                DateInfo = DateTime.Parse("06/05/2019"),
                TimeInfo = DateTime.Parse("4:00 PM"),
                BusInfo = BusAvailability.Not_Available,
                Squad1 = Squad.Blue,
                Squad2 = Squad.Green,
                

            });

            dataset.Add(new EventModel
            {
                Type = EventType.Competition,
                Location = "Hollywood High School",
                DateInfo = DateTime.Parse("06/18/2019"),
                TimeInfo = DateTime.Parse("9:00 AM"),
                BusInfo = BusAvailability.Available,
                Squad1 = Squad.Purple,
                Squad2 = Squad.Yellow
             
            });
        }
    }
}
