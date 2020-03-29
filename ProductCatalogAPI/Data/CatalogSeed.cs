using Microsoft.EntityFrameworkCore;

using ProductCatalogApi.Domain;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;



namespace ProductCatalogApi.Data

{



    public static class CatalogSeed

    {

        public static void Seed(CatalogContext context)

        {

            context.Database.Migrate();

            if (!context.CatalogEventCategories.Any())

            {

                context.CatalogEventCategories.AddRange(GetPreConfiguredCatalogEventCategories());

                context.SaveChanges();

            }

            if (!context.CatalogEventTypes.Any())

            {

                context.CatalogEventTypes.AddRange(GetPreConfiguredCatalogEventTypes());

                context.SaveChanges();

            }

            if (!context.CatalogEventLocations.Any())

            {

                context.CatalogEventLocations.AddRange(GetPreConfiguredCatalogEventLocations());

                context.SaveChanges();

            }

            if (!context.CatalogEventItems.Any())

            {

                context.CatalogEventItems.AddRange(GetPreConfiguredCatalogEventItems());

                context.SaveChanges();

            }

        }

        private static IEnumerable<CatalogEventCategory> GetPreConfiguredCatalogEventCategories()

        {

            return new List<CatalogEventCategory>()

            {

                new CatalogEventCategory { Category="Arts"},

                new CatalogEventCategory { Category="Buisiness & Career"},

                new CatalogEventCategory { Category="Community"},

                new CatalogEventCategory { Category="Entertainment"},

                new CatalogEventCategory { Category="Food & Drink"},

                new CatalogEventCategory { Category="Kids"},

                new CatalogEventCategory { Category="Sports & Fitness"},

                new CatalogEventCategory { Category="Outdoor"},

                new CatalogEventCategory { Category="OtherCategories"},

            };



        }

        private static IEnumerable<CatalogEventType> GetPreConfiguredCatalogEventTypes()

        {

            return new List<CatalogEventType>()

            {

                new CatalogEventType { Type="Attraction"},

                new CatalogEventType { Type="Class"},

                new CatalogEventType { Type="Concert"},

                new CatalogEventType { Type="CareerFair"},

                new CatalogEventType { Type="Competetion"},

                new CatalogEventType { Type="Conference"},

                new CatalogEventType { Type="Festivals"},

                new CatalogEventType { Type="Game"},

                new CatalogEventType { Type="OtherTypes"},

                new CatalogEventType { Type="Party"},

                new CatalogEventType { Type="Screening"},

                new CatalogEventType { Type="Tournment"},



            };



        }

        private static IEnumerable<CatalogEventLocation> GetPreConfiguredCatalogEventLocations()

        {

            return new List<CatalogEventLocation>()

            {

                new CatalogEventLocation { Location="Bellevue"},

                new CatalogEventLocation { Location="Redmond"},

                new CatalogEventLocation { Location="Renton"},

                new CatalogEventLocation { Location="Seattle"},

                new CatalogEventLocation { Location="Sammamish"},

                new CatalogEventLocation { Location="Lynnwood"},

                new CatalogEventLocation { Location="Kirkland"},

                new CatalogEventLocation { Location="Issaquah"},

                new CatalogEventLocation { Location="Anacortes"},

                new CatalogEventLocation { Location="Everett"},



            };





        }



        private static IEnumerable<CatalogEventItem> GetPreConfiguredCatalogEventItems()

        {

            return new List<CatalogEventItem>()

            {



                new CatalogEventItem {CatalogCategoryId=1,CatalogTypeId=1,CatalogLocationId=2,Name="Paradise sunset Paint Nite at Soulfood Coffeehouse",Description="Join us to draw an amazing sunset at Soulfood Coffeehouse in Redmond. Our profetional team will teach you the how to be profitional artst. All requirements will be available for you such as papers,brushes,paint. Contemplate them up close and take home your favorite. snacks will be available for you.",Schedule=DateTime.Parse("04/02/2020 6:30:00 PM"),Price =35.00M,PictureUrl="http://externalcatalogbaseurltobereplaced/api/pic/1"},



                new CatalogEventItem {CatalogCategoryId=1,CatalogTypeId=2,CatalogLocationId=4,Name="Swing Beginner Lesson",Description="Join the Seattle Swing Dance Club for a free 30-minute West Coast Swing (WCS) lesson every 1st & 3rd Sunday at Alki Masonic Center in West Seattle! No partner required, all skill and phsyical levels welcome!",Schedule=DateTime.Parse("04/05/2020 6:30:00 pm"),Price=0.00m,PictureUrl="http://externalcatalogbaseurltobereplaced/api/pic/2"} ,



                new CatalogEventItem {CatalogCategoryId=1,CatalogTypeId=7,CatalogLocationId=4,Name="Seattle Cuban Dance Fest 4th Edition",Description="LEARN TO DANCE LIKE A CUBAN ------ The Seattle Cuban Dance Fest is the first and only festival dedicated to show",Schedule=DateTime.Parse("07/09/2020 08:00:00 PM"),Price=100.00m,PictureUrl="http://externalcatalogbaseurltobereplaced/api/pic/3"} ,



                new CatalogEventItem {CatalogCategoryId=2,CatalogTypeId=4,CatalogLocationId=1,Name="Annual Career Events",Description="For students, these events allow you to practice your networking skills, get your resume critiqued, and create opportunities in which you can meet employers who have open positions at their company.",Schedule=DateTime.Parse("08/01/2020 11:00:00 AM"),Price=40.00m,PictureUrl="http://externalcatalogbaseurltobereplaced/api/pic/4"} ,



                new CatalogEventItem{ CatalogCategoryId = 2, CatalogTypeId = 4, CatalogLocationId = 4, Name = "seattle career fair - october 20, 2020 - live recruiting/hiring event", Description = "live recruiting/hiring event! ready for a new career?  national career fairs is the industry leader and we are driving employers and future employees together faster then ever before.", Schedule =DateTime.Parse("10/20/2020 6:00:00 pm"), Price = 0.00m, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/5" },



                new CatalogEventItem { CatalogCategoryId = 3, CatalogTypeId = 7, CatalogLocationId = 6, Name = "Woodmark's Hip Hoppin' Easter Extravaganza",Description = "Hippity hoppity Easter's on its way! Gather your friends and family, and join us for a festive Easter celebration!",Schedule =DateTime.Parse("4/12/2020 10:30:00 am"),Price = 0.00m,PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/6" },



                new CatalogEventItem{ CatalogCategoryId = 3, CatalogTypeId = 10, CatalogLocationId = 5, Name = "East Sammamish Park Work Party", Description = "Join WNPS Master Native Plant Stewards to help restore urban forests in the City of Sammamish! Volunteers will help remove invasive blackberry and mulch at East Sammamish Park.", Schedule =DateTime.Parse("04/04/2020 6:00:00 pm"), Price = 15.00m, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/7" },



                new CatalogEventItem { CatalogCategoryId = 5, CatalogTypeId = 7, CatalogLocationId = 4, Name = "Seattle 'All You Can Eat' Ice Cream Festival", Description = "Featuring over 60 different flavors from the finest ice cream companies in Puget Sound, this two-day family-friendly event will have live entertainment, food trucks, a bar, an ice cream eating contest, games, and much more!",Schedule=DateTime.Parse("05/6/2020 2:30:00 pm"),Price=16.00m,PictureUrl="http://externalcatalogbaseurltobereplaced/api/pic/8"},



                new CatalogEventItem { CatalogCategoryId = 4, CatalogTypeId = 11, CatalogLocationId = 2, Name = "Movies at Marymoor Park", Description = "Live entertainment, food trucks, trivia and outdoor movies every Wednesday.", Schedule =DateTime.Parse("07/20/2020 3:30:00 pm"), Price = 5.00m, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/9" },

                new CatalogEventItem { CatalogCategoryId = 7, CatalogTypeId = 4, CatalogLocationId = 4, Name = "Spring Pup Squad", Description = "We are excited to announce the dates for our Spring Pup Squad! Your child can wear an authentic uniform with their very own pair of poms, attend cheer and dance practices, and perform alongside UW Cheer and Dance in Alaska Airlines Arena at the Seattle Storm vs.",Schedule=DateTime.Parse("05/27/2020 6:30:00 pm"),Price=100,PictureUrl="http://externalcatalogbaseurltobereplaced/api/pic/10"},

                new CatalogEventItem { CatalogCategoryId = 6, CatalogTypeId = 2, CatalogLocationId = 7, Name = "Caring for Each Other With Sesame Workshop", Description = "Head to the Caring for Each Other website for content and resources you can use with your family to offer comfort and spark playful learning activities. Children thrive with structure in their lives and they learn best through play, even in everyday moments like mealtimes and morning and evening routines.", Schedule =DateTime.Parse("03/28/2020 6:30:00 pm"), Price = 20.00m, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/11" },

                new CatalogEventItem { CatalogCategoryId = 7, CatalogTypeId = 2, CatalogLocationId = 5, Name = "growing yoga teachers: yama sequence fall 2020 / winter 2021", Description = "growing yoga teachers is a program designed especially to help find answers to these questions and more. designed around the needs of recent yoga teacher training program graduates who are finding their voice and want more connection and feedback. the yama sequence is a series of 5 monthly 4 hour workshops covering issues that come up in class, enhancing your teaching, and business issues that come up as a yoga teacher. each month these small group workshops will provide community and support to yoga teachers. material covered will be a honing and deepening of the subjects you were introduced to during your 200hr yoga teacher training in order to help you discover what kind of a teacher you want to be.", Schedule =DateTime.Parse("01/1/2021 05:30:00 am"), Price = 25, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/12" },



                new CatalogEventItem { CatalogCategoryId = 6, CatalogTypeId = 2, CatalogLocationId = 1, Name = "FLEETv Virtual Science Activities",Description="Welcome to an exciting place where you can have fun with experiments, hands-on activities, engaging interviews and more, all from the comfort of your home.",Schedule=DateTime.Parse("03/28/2020 2:00:00 pm"),Price=0.00m,PictureUrl="http://externalcatalogbaseurltobereplaced/api/pic/13"},

                new CatalogEventItem { CatalogCategoryId = 8,CatalogTypeId = 1,CatalogLocationId = 3,Name = "fall fun activities at the farm at swan's trail",Description = "set along the beautiful snohomish river just outside of seattle, the farm at swan's trail is home to authentic fall fun for everyone. enjoy our enormous 50-acre pumpkin patch, the washington state corn maze, the petting farm, wagon rides, u-pick apple orchard, live duck races, and farmer ben's famous four little pigs show.",Schedule =DateTime.Parse("01/2/2021 6:30:00 pm"),Price = 10,PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/14"},

                new CatalogEventItem { CatalogCategoryId = 9,CatalogTypeId = 9,CatalogLocationId = 4,Name = "Seattle Super Weekend w/ Autumn Calabrese",Description = "Join us the evening of April 17th as we welcome Beachbody Super Trainer Autumn Calabrese to the PNW and celebrate an OPEN HOUSE STYLE event.",Schedule=DateTime.Parse("4/17/2020 6:30:00 pm"),Price=0.00m,PictureUrl="http://externalcatalogbaseurltobereplaced/api/pic/15"},

                new CatalogEventItem{ CatalogCategoryId = 4, CatalogTypeId = 3, CatalogLocationId = 4, Name = " Cameron Esposito: Save Yourself Tour", Description = "Cameron Esposito is a standup comic, actor and writer who has appeared across television and film and, most recently, in print in the New York Times.You may also know Cameron from her popular interview podcast, Queery. Her first book, Save Yourself, is forthcoming in March 2020 from Hachette/Grand Central Publishing.", Schedule =DateTime.Parse("04/01/2020 7:30:00 pm"), Price = 30.00m, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/16" },

                new CatalogEventItem { CatalogCategoryId = 2, CatalogTypeId = 2, CatalogLocationId = 2, Name = "Kal Academy Information Session", Description = "At Kal Academy, our next cohort of classes is starting soon. Come hear us talk about the program and get your questions answered!", Schedule =DateTime.Parse("05/3/2020 4:30:00 pm"), Price = 0.00m, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/17" }



            };

        }

    }

}

