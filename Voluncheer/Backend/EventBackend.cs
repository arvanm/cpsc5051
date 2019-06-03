using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Voluncheer.Models;

namespace Voluncheer.Backend
{
    public class EventBackend
    {

        #region SingletonPattern
        private static volatile EventBackend instance;
        private static object syncRoot = new object();

        private EventBackend() { }

        public static EventBackend Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new EventBackend();
                    }
                }

                return instance;
            }
        }
        #endregion SingletonPattern

        // Hook up the Repository
        private IEventRepository repository = new EventRepositoryMock();

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public EventModel Create(EventModel data)
        {
            var myData = repository.Create(data);
            return myData;
        }

        /// <summary>
        /// Read
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public EventModel Read(string id)
        {
            var myData = repository.Read(id);
            return myData;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public EventModel Update(EventModel data)
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
        ///  Returns the List of Outfits
        /// </summary>
        /// <returns></returns>
        public EventViewModel Index()
        {
            var myData = new EventViewModel();
            myData.EventList = repository.Index();

            return myData;
        }
    }
}
