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
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly ICategoryRepository CategoryRepository;
        readonly IConfiguration configuration;
        public CategoryController(ICategoryRepository CategoryRepository, IConfiguration configuration)
        {
            this.CategoryRepository = CategoryRepository;
            this.configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            List<Category> Categories = await CategoryRepository.GetAll();
            return Ok(Categories);
        }
        [HttpGet("{id:int}", Name = "getCategory")]
        public async Task<IActionResult> GetByID(int id)
        {
            Category Category = await CategoryRepository.FindById(id);
            CategoryDataWithProductNameDTO CategoryDTO = new CategoryDataWithProductNameDTO();
            CategoryDTO.ID = id;
            foreach (var item in Category.Products)
            {
                CategoryDTO.ProductName.Add(item.Name);
            }
            CategoryDTO.CategoryName = Category.Name;
            CategoryDTO.Image = Category.Image;
            return Ok(CategoryDTO);
        }
        [HttpPost]
        public async Task<IActionResult> PostAllCategories(Category Category)
        {
            if (ModelState.IsValid == true)
            {
                await CategoryRepository.Post(Category);
                string url = Url.Link("getCategory", new { id = Category.ID });
                return Created(url, Category);
            }
            return BadRequest(ModelState);
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Category Category)
        {
            if (ModelState.IsValid == true)
            {
                await CategoryRepository.Put(id, Category);

                return StatusCode(204, Category);
            }
            return BadRequest("Id is not valid");

        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Remove(int id)
        {
            Category OldCategory = await CategoryRepository.FindById(id);
            if (OldCategory != null)
            {
                try
                {
                    await CategoryRepository.Delete(id);
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
