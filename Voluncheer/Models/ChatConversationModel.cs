using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Voluncheer.Models
{
    public class ChatConversationModel
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public List<ChatPost> Thread { get; set; } = new List<ChatPost>();
    }

    public class ChatPost
    {
        public ChatPost(string UserName, string Message)
        {
            this.UserName = UserName;
            this.Message = Message;
        }
        public string UserName { get; set; }
        public string Message { get; set; }
    }
}