using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Voluncheer.Models
{
    public enum EventType {
        Practice, Competition, TeamBuilding
    }

    public class FoodAssignment
    {
        public FoodAssignment(string VolunteerName, string Category)
        {
            this.VolunteerName = VolunteerName;
            this.Category = Category;
        }

        /// TODO make this a ref to a volunteer (populate from volunteer backend)
        public string VolunteerName { get; set; }
        /// TODO make a food category class with its own repository
        public string Category { get; set; }
    }

    public class TransportationAssignment
    {
        public TransportationAssignment(string VolunteerName, int Seats)
        {
            this.VolunteerName = VolunteerName;
            this.Seats = Seats;
        }

        /// TODO use Volunteer model
        public string VolunteerName { get; set; }
        public int Seats { get; set; }
    }

    public class GenericAssignment
    {
        public GenericAssignment(string Name, string Duty)
        {
            this.Name = Name;
            this.Duty = Duty;
        }
        public string Name { get; set; }
        public string Duty { get; set; }
    }

    public class EventModel
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public EventType Type { get; set; }
        public string Location { get; set; }
        public DateTime DateInfo { get; set; }
        public Dictionary<string, OutfitModel> Outfits { get; set; } = new Dictionary<string, OutfitModel>();
        public List<FoodAssignment> FoodAssignments { get; set; } = new List<FoodAssignment>();
        public List<string> CleanupAssignments { get; set; } = new List<string>();
        public List<GenericAssignment> OtherAssignments { get; set; } = new List<GenericAssignment>();
        public void Update(EventModel data)
        {
            Type = data.Type;
            Location = data.Location;
            DateInfo = data.DateInfo;
            Outfits = new Dictionary<string, OutfitModel>(data.Outfits);
            FoodAssignments = new List<FoodAssignment>(data.FoodAssignments);
            CleanupAssignments = new List<string>(data.CleanupAssignments);
            OtherAssignments = new List<GenericAssignment>(data.OtherAssignments);
        }
    }
}