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


    }
}