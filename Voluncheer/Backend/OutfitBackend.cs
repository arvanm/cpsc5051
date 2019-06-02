using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Voluncheer.Models;

namespace Voluncheer.Backend
{
        public class OutfitBackend
        {

            #region SingletonPattern
            private static volatile OutfitBackend instance;
            private static object syncRoot = new object();

            private OutfitBackend() { }

            public static OutfitBackend Instance
            {
                get
                {
                    if (instance == null)
                    {
                        lock (syncRoot)
                        {
                            if (instance == null)
                                instance = new OutfitBackend();
                        }
                    }

                    return instance;
                }
            }
            #endregion SingletonPattern

            // Hook up the Repositry
            private IOutfitRepository repository = new OutfitRepositoryMock();

            /// <summary>
            /// Create
            /// </summary>
            /// <param name="data"></param>
            /// <returns></returns>
            public OutfitModel Create(OutfitModel data)
            {
                var myData = repository.Create(data);
                return myData;
            }

            /// <summary>
            /// Read
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public OutfitModel Read(string outfitName)
            {
                var myData = repository.Read(outfitName);
                return myData;
            }

            /// <summary>
            /// Update
            /// </summary>
            /// <param name="data"></param>
            /// <returns></returns>
            public OutfitModel Update(OutfitModel data)
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
            public OutfitViewModel Index()
            {
                var myData = new OutfitViewModel();
                myData.OutfitList = repository.Index();

                return myData;
            }
        }
}