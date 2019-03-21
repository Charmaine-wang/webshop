using System;
using System.Collections.Generic;
using ecomerce.Models;
using ecomerce.Repositories;
using ecomerce.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ecomerce.Controllers
{

    [Route("api/[controller]")]
    public class CartItemsController : Controller
    {
        private readonly string connectionString;
        private readonly CartItemsServices cartItemsService;

        public CartItemsController(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("ConnectionString");
            this.cartItemsService = new CartItemsServices(new CartItemsRepository(connectionString));
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<CartItems>), StatusCodes.Status200OK)]
        public IActionResult Get()

        {
            return Ok(this.cartItemsService.Get());
        }

    }
}
