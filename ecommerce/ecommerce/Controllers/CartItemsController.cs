﻿using System.Collections.Generic;
using System.Web.Http.Cors;
using ecommerce.Models;
using ecommerce.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ecommerce.Controllers
{
    [EnableCors(origins: "/http://localhost:3000/", headers: "*", methods: "*")]
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


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody]CartItems cartItems)
        {
            var result = this.cartItemsService.Add(cartItems);

            if (!result)
            {
                return BadRequest();
            }

            return Ok();
        }

    }
}