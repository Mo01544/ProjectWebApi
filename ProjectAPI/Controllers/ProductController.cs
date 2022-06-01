using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project.Models;
using Project.Repositories;
using System;
using System.Collections.Generic;
using ProjectWebAPI.DTO;
using ProjectWebAPI.SharedClasses;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IProductRepository ProductRepository;
        readonly IConfiguration configuration;
        public ProductController(IProductRepository ProductRepository, IConfiguration configuration)
        {
            this.ProductRepository = ProductRepository;
            this.configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            List<Product> Products = await ProductRepository.GetAll();
            return Ok(Products);
        }
        [HttpGet("{id:int}", Name = "getProduct")]
        public async Task<IActionResult> GetByID(int id)
        {
            Product Product = await ProductRepository.FindById(id);
            ProductDataWithCategoryNameDTO ProductDTO = new ProductDataWithCategoryNameDTO();
            ProductDTO.CategoryName = Product.Category.Name;
            ProductDTO.Name = Product.Name;
            ProductDTO.Price = Product.Price;
            ProductDTO.Details = Product.Details;
            ProductDTO.Image = Product.Image;
            return Ok(ProductDTO);
        }
        [HttpPost]
        public async Task<IActionResult> PostAllProducts(Product Product)
        {
            if (ModelState.IsValid == true)
            {
                await ProductRepository.Post(Product);
                string url = Url.Link("getProduct", new { id = Product.ID });
                return Created(url, Product);
            }
            return BadRequest(ModelState);
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Product Product)
        {
            if (ModelState.IsValid == true)
            {
                await ProductRepository.Put(id, Product);

                return StatusCode(204, Product);
            }
            return BadRequest("Id is not valid");

        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Remove(int id)
        {
            Product OldProduct = await ProductRepository.FindById(id);
            if (OldProduct != null)
            {
                try
                {
                    await ProductRepository.Delete(id);
                    return StatusCode(204, "Record is remove successfully");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest("Id is not found");
        }
    }
}