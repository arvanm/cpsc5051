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
                Location = "Sonora High School"
            });
        }
    }
}
