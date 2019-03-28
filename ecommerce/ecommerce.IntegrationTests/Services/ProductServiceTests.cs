using System;
using ecommerce.Repositories;
using ecommerce.Services;
using NUnit.Framework;

namespace ecommerce.IntegrationTests.Services
{
    public class ProductServiceTests
    {
        private ProductServices productsService;

        [SetUp]
        public void SetUp()
        {
            this.productsService = new ProductServices(new ProductsRepository(
                "Data Source=/Users/charmainewang/Documents/c#/webshop/ecommerce/ecom.db;Version=3;"));
        }


        [Test]
        public void Get_ReturnsResultsFromDatabase()
        {
            // Act

            var result = this.productsService.Get().Count;
            // Assert

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Get_GivenId_ReturnsResultFromDatabase()
        {
            // Act
            var result = this.productsService.Get();
            // Assert

            Assert.That(result, Is.EqualTo(5));
            // Assert
        }

    }
}

