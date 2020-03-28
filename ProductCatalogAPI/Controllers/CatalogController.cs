using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductCatalogApi.Data;
using ProductCatalogApi.Domain;
using ProductCatalogApi.ViewModels;

namespace ProductCatalogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly CatalogContext _context;

        private readonly IConfiguration _config;

        public CatalogController(CatalogContext context, IConfiguration config)

        {

            _context = context;
            _config = config;


        }
        [HttpGet]

        [Route("[action]")]

        public async Task<IActionResult> Items(

           [FromQuery]int pageIndex = 0,

           [FromQuery]int pageSize = 6)

        {

            var itemsCount = await _context.CatalogEventItems.LongCountAsync();



            var items = await _context.CatalogEventItems

                                .Skip(pageIndex * pageSize)

                                .Take(pageSize)

                                .ToListAsync();

            items = ChangePictureUrl(items);

            var model = new PaginatedItemsViewModel<CatalogEventItem>

            {

                PageIndex = pageIndex,

                PageSize = pageSize,

                Count = itemsCount,

                Data = items

            };

            return Ok(model);
        }

            private List<CatalogEventItem> ChangePictureUrl(List<CatalogEventItem> items)
        {
            items.ForEach(

                c => c.PictureUrl =

                    c.PictureUrl.Replace("http://externalcatalogbaseurltobereplaced",

                        _config["ExternalCatalogBaseUrl"])

                );

            return items;
        }
    }
}