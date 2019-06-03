using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Voluncheer.Models;

namespace Voluncheer.Backend
{
    public class OutfitRepositoryMock : IOutfitRepository
    {
        public List<OutfitModel> dataset = new List<OutfitModel>();

        public OutfitRepositoryMock()
        {
            Initialize();
        }

        public OutfitModel Create(OutfitModel data)
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

        public List<OutfitModel> Index()
        {
            return dataset;
        }

        public OutfitModel Read(string id)
        {
            var myData = dataset.First(m => m.OutfitName == id);
            return myData;
        }

        public OutfitModel Update(OutfitModel data)
        {
            var myData = Read(data.OutfitName);
            if (myData == null)
            {
                return null;
            }

            myData.Update(data);
            return data;
        }

        public void Initialize()
        {
            dataset.Add(new OutfitModel { OutfitName = "GlitterGlam", ImagePath = "~/Content/Img/glitterglam.png" });
            dataset.Add(new OutfitModel {OutfitName = "Battle", ImagePath = "~/Content/Img/Battle.png" });
            dataset.Add(new OutfitModel { OutfitName = "Warrior", ImagePath = "~/Content/Img/Warrior.png" });
            dataset.Add(new OutfitModel { OutfitName = "Diamond", ImagePath = "~/Content/Img/Diamond.png" });
            dataset.Add(new OutfitModel { OutfitName = "Emerald", ImagePath = "~/Content/Img/Emerald.png" });
            dataset.Add(new OutfitModel { OutfitName = "HotShot", ImagePath = "~/Content/Img/Hotshot.jpg" });
            dataset.Add(new OutfitModel { OutfitName = "Superstar", ImagePath = "~/Content/Img/Superstar.jpg" });
            // TODO: Populated some Outfit Data here...
        }
    }
}
