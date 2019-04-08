using System.Collections.Generic;
using System.Web.Http.Cors;
using ecommerce.Models;
using ecommerce.Repositories;
using ecommerce.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ecommerce.Controllers
{
    [Route("api/[controller]")]
        public class OrderItemsController : Controller
        {
            private readonly string connectionString;
            private readonly OrderItemsServices orderItemsService;


            public OrderItemsController(IConfiguration configuration)
            {
                this.connectionString = configuration.GetConnectionString("ConnectionString");
                this.orderItemsService = new OrderItemsServices(new OrderItemsRepository(connectionString));
            }

            [HttpGet]
            [ProducesResponseType(typeof(List<OrderItems>), StatusCodes.Status200OK)]
            public IActionResult Get()

            {
                return Ok(this.orderItemsService.Get());
            }

        [HttpGet("{guid}")]
            [ProducesResponseType(typeof(List<OrderItems>), StatusCodes.Status200OK)]
            public IActionResult Get(string guid)

            {
                return Ok(this.orderItemsService.Get(guid));
            }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody]OrderItems orderItems)
        {
            var result = this.orderItemsService.Add(orderItems);

            if (!result)
            {
                return BadRequest();
            }
            return Ok();
        }

    }
}

