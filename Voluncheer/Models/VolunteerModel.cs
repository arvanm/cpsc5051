﻿using System;
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
    }
}