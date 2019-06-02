using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Voluncheer.Models
{
    public class OutfitModel
    {
        public string OutfitName { get; set; }
        public string ImagePath { get; set; }

        public void Update (OutfitModel data)
        {
            ImagePath = data.ImagePath;
        }
    }
}