﻿using System.Collections.Generic;
using System.Web.Http.Cors;
using ecommerce.Models;
using ecommerce.Repositories;
using ecommerce.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ecommerce.Controllers
{
    [EnableCors(origins: "http://localhost:3000/", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly string connectionString;
        private readonly ProductServices productsService;


        public ProductController(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("ConnectionString");
            this.productsService = new ProductServices(new ProductsRepository(connectionString));
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Products>), StatusCodes.Status200OK)]
        public IActionResult Get()

        {
            return Ok(this.productsService.Get());
        }

        [HttpGet("{key}")]
        [ProducesResponseType(typeof(Products), StatusCodes.Status200OK)]
        [ProducesResponseTypeAttribute(StatusCodes.Status404NotFound)]
        public IActionResult Get(string key)
        {
            var resault = this.productsService.Get(key);
            return Ok(resault);
        }
    }
}
