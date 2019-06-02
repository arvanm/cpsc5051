using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voluncheer.Models;

namespace Voluncheer.Backend
{
    interface IOutfitRepository
    {
        OutfitModel Create(OutfitModel data);
        OutfitModel Read(String id);
        OutfitModel Update(OutfitModel data);
        Boolean Delete(String id);
        List<OutfitModel> Index();
    }
}
