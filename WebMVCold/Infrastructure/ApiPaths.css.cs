using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;



namespace WebMVC.Infrastructure

{

    public class ApiPaths

    {

        public static class Catalog

        {

            public static string GetAllCatalogItems(string baseUri,

                int page, int take)


            { 
               

                return $"{baseUri}items?pageIndex={page}&pageSize={take}";

            }

            internal static object GetAllCatalogItems(string baseUri, int page)
            {
                throw new NotImplementedException();
            }

            public static string GetCatalogItem(string baseUri, int id)

            {



                return $"{baseUri}/items/{id}";

            }

            public static string GetAllEventCategories(string baseUri)

            {

                return $"{baseUri}catalogEventCategories";

            }



            public static string GetAllEventTypes(string baseUri)

            {

                return $"{baseUri}catalogEventTypes";

            }

            public static string GetAllEventLocations(string baseUri)

            {

                return $"{baseUri}catalogEventLocations";

            }

        }
    }



        public static class Basket

        {



        }

    }


