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

                int page, int take ,int? category, int? type, int? location)

                               
            {
                var filterQs = string.Empty;
                if (category.HasValue || type.HasValue || location.HasValue)

                {

                    var categoryQs = (category.HasValue) ? category.Value.ToString() : "null";

                    var typeQs = (type.HasValue) ? type.Value.ToString() : "null";

                    var locationQs = (location.HasValue) ? location.Value.ToString() : "null";

                    filterQs = $"/category/{categoryQs}/type/{typeQs}/location/{locationQs}";

                }



                return $"{baseUri}items{filterQs}?pageIndex={page}&pageSize={take}";

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


