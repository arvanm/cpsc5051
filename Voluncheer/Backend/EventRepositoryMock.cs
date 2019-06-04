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
                Location = "South Shore High School",
                DateInfo = DateTime.Parse("06/03/2019 4:00 PM"),
                BusInfo = BusAvailability.Not_Available,
                Outfits = {
                    { "Purple", "HotShot" },
                    { "Blue", "Superstar" }
                },
                FoodAssignments =
                {
                    new FoodAssignment("Michael Kane", "Snack", 15),
                    new FoodAssignment("Cherry Hollind", "Drinks", 15)
                },
                CleanupAssignments =
                {
                    new CleanupAssignment("Stacy Harrison"),
                    new CleanupAssignment("Kelly Clark"),
                    new CleanupAssignment("Lana Lang")

                },
                TransportationAssignments =
                {
                    new TransportationAssignment("Jamie Chase", 4),
                    new TransportationAssignment("Harry Wonka", 5),
                    new TransportationAssignment("Phillip Cane", 4),
                },
                OtherAssignments =
                {
                    new GenericAssignment("Howard Hugh", "Pass out team gear to parents"),
                    new GenericAssignment("Cane Lane", "Pass out food"),
                    new GenericAssignment("Candice Abberdeen", "Send reminder messages to parents"),
                }

            });

            dataset.Add(new EventModel
            {
                Type = EventType.Practice,
                Location = "Sonora High School",
                DateInfo = DateTime.Parse("06/05/2019 4:00 PM"),
                BusInfo = BusAvailability.Not_Available,
                Outfits = {
                    { "Blue", "GlitterGlam" },
                    { "Green", "Warrior" }
                },
                FoodAssignments =
                {
                    new FoodAssignment("Stacy Harrison", "Snack", 10),
                    new FoodAssignment("Tom Ford", "Drinks", 10)
                },
                CleanupAssignments =
                {
                    new CleanupAssignment("Jon Snow"),
                    new CleanupAssignment("Hannah Montana"),
                    new CleanupAssignment("Lana Lang")
                    
                },
                TransportationAssignments =
                {
                    new TransportationAssignment("James Jonah", 6),
                    new TransportationAssignment("Harry Willis", 5),
                    new TransportationAssignment("Phillip Carl", 4),
                },
                 OtherAssignments =
                {
                    new GenericAssignment("Jamie Curtis", "Pass out team gear to parents"),
                    new GenericAssignment("Joan Ucoll", "Gather parents to rally for athletes"),
                    new GenericAssignment("Shane Cahoun", "Take attendance of parents"),
                }

            });

            dataset.Add(new EventModel
            {
                Type = EventType.Competition,
                Location = "Hollywood High School",
                DateInfo = DateTime.Parse("06/18/2019 9:00 AM"),
                BusInfo = BusAvailability.Available,
                Outfits =
                {
                    {"Purple", "Diamond" },
                    {"Yellow", "Emerald" }
                },
                FoodAssignments =
                {
                    new FoodAssignment("Barry White", "Snack", 30),
                    new FoodAssignment("Manu Ginobli", "Drinks", 35)
                },
                CleanupAssignments =
                {
                    new CleanupAssignment("Michael Ma"),
                    new CleanupAssignment("Laura Hong"),
                    new CleanupAssignment("Mori Louis")

                },
                TransportationAssignments =
                {
                    new TransportationAssignment("James Chana", 3),
                    new TransportationAssignment("Connie Lovington", 5),
                    new TransportationAssignment("Sonny Joy", 4),
                },
                OtherAssignments =
                {
                    new GenericAssignment("Connie Rayson", "Pass out team gear to parents"),
                    new GenericAssignment("Laura Crawf", "Coordinate carpool time"),
                    new GenericAssignment("Kelly Osbourne", "Bring stereo and music playlist"),
                }


            });
        }
    }
}
