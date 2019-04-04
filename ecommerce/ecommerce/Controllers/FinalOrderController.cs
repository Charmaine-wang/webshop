using System;
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
    public class FinalOrderController : Controller
    {

        //private readonly string connectionString;

        private readonly FinalOrderServices finalOrderServices;

        public FinalOrderController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ConnectionString");
            this.finalOrderServices = new FinalOrderServices(new CustomerRepository(connectionString), new OrderItemsRepository(connectionString));
        }

        [HttpGet("{guid}")]
        [ProducesResponseType(typeof(FinalOrder), StatusCodes.Status200OK)]
        [ProducesResponseTypeAttribute(StatusCodes.Status404NotFound)]
        public IActionResult Get(string guid)
        {
            var resault = this.finalOrderServices.Get(guid);
            return Ok(resault);
        }

    }
}
