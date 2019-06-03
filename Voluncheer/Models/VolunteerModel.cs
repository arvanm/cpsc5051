using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Voluncheer.Models
{
    public class VolunteerModel
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ChatConversationModel DirectMessageHistory { get; set; } = new ChatConversationModel();
        public string FullName() { return FirstName + " " + LastName; }

        public void Update(VolunteerModel data)
        {
            FirstName = data.FirstName;
            LastName = data.LastName;
            DirectMessageHistory = data.DirectMessageHistory;
        }
    }
}
