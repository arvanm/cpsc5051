using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Voluncheer.Models;

/// <summary>
/// In Memory Implementation of a Volunteer data store
/// </summary>
namespace Voluncheer.Backend
{
    public class VolunteerRepositoryMock : IVolunteerRepository
    {
        public List<VolunteerModel> dataset = new List<VolunteerModel>();

        /// <summary>
        /// Constructor for Event Repository
        /// </summary>
        public VolunteerRepositoryMock()
        {
            Initialize();
        }

        /// <summary>
        /// Add the Volunteer item to the data store
        /// </summary>
        /// <param name="data">
        /// The new Volunteer item to add to the data store
        /// </param>
        /// <returns>return the passed in Volunteer item</returns>
        public VolunteerModel Create(VolunteerModel data)
        {
            dataset.Add(data);
            return data;
        }

        /// <summary>
        /// Remove the item from the data store
        /// Look it up by ID, if found, remove it, and return true
        /// else return false
        /// </summary>
        /// <param name="id">the item to remove by ID</param>
        /// <returns>true if removed</returns>
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

        /// <summary>
        /// Return all items in the data store
        /// </summary>
        /// <returns>a list of all the items in the data store</returns>
        public List<VolunteerModel> Index()
        {
            return dataset;
        }

        /// <summary>
        /// Return the requested Volunteer item from the data store
        /// if not found, return null
        /// </summary>
        /// <param name="id">the item to find</param>
        /// <returns>the item from the datastore, or null</returns>
        public VolunteerModel Read(string id)
        {
            var myData = dataset.First(m => m.ID == id);
            return myData;
        }

        /// <summary>
        /// Update the item in the data store
        /// use the ID from the item passed in to find the item and then update it
        /// </summary>
        /// <param name="data">the item to update</param>
        /// <returns>the updated item</returns>
        public VolunteerModel Update(VolunteerModel data)
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
            // TODO: Populated some Volunteer Data here...
        }
    }
}
