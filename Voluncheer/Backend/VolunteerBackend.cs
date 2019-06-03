using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Voluncheer.Models;

namespace Voluncheer.Backend
{
    public class VolunteerBackend
    {

        #region SingletonPattern
        private static volatile VolunteerBackend instance;
        private static object syncRoot = new object();

        private VolunteerBackend() { }

        public static VolunteerBackend Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new VolunteerBackend();
                    }
                }

                return instance;
            }
        }
        #endregion SingletonPattern

        // Hook up the Repositry
        private IVolunteerRepository repository = new VolunteerRepositoryMock();

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public VolunteerModel Create(VolunteerModel data)
        {
            var myData = repository.Create(data);
            return myData;
        }

        /// <summary>
        /// Read
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public VolunteerModel Read(string outfitName)
        {
            var myData = repository.Read(outfitName);
            return myData;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public VolunteerModel Update(VolunteerModel data)
        {
            var myData = repository.Update(data);
            return myData;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            var myData = repository.Delete(id);
            return myData;
        }

        /// <summary>
        ///  Returns the List of Volunteers
        /// </summary>
        /// <returns></returns>
        public VolunteerViewModel Index()
        {
            var myData = new VolunteerViewModel();
            myData.VolunteerList = repository.Index();

            return myData;
        }
    }
}
