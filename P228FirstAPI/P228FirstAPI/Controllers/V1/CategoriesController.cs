using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P228FirstAPI.DAL;
using P228FirstAPI.DTOs.CategoryDTOs;
using P228FirstAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228FirstAPI.Controllers.V1
{
    /// <summary>
    /// Categories Services
    /// </summary>
    [Authorize]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CategoriesController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Category List Service
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Category> categories = await _context.Categories
                .Where(c => c.IsDeleted == false)
                .ToListAsync();

            List<CategoryForListDto> categoryForListDtos = _mapper.Map<List<CategoryForListDto>>(categories);

            return Ok(categoryForListDtos);
        }

        /// <summary>
        /// Get Category By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="400">Id Null Oldugu Ucun</response>
        /// <response code="404">Gonderilen Id-li Object Tapilmadigina Gore</response> 
        /// <response code="200">Her Sey Normaldi</response> 
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Category category = await _context.Categories.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (category == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }

            //CategoryForDetailDto categoryForDetailDto = new CategoryForDetailDto
            //{
            //    CategoryKey = category.Id,
            //    Ad = category.Name,
            //    KimYarad = category.CreatedBy
            //};

            CategoryForDetailDto categoryForDetailDto = _mapper.Map<CategoryForDetailDto>(category);

            return Ok(categoryForDetailDto);
        }

        /// <summary>
        /// Creates an Employee.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/v1/categories
        ///     {           
        ///         "name":"Test"
        ///     }
        /// </remarks>
        /// <param name="categoryForCreateDto"></param>
        /// <returns>A newly created employee</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="409">Same Name Alreade Exists</response>          
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(409)]
        [Produces("application/json")]
        public async Task<IActionResult> Post(CategoryForCreateDto categoryForCreateDto)
        {
            if (await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == categoryForCreateDto.Name.Trim().ToLower()))
            {
                return Conflict($"Name: {categoryForCreateDto.Name} Alreade Exists");
            }

            //Category category = new Category
            //{
            //    CreatedAt = DateTime.UtcNow.AddHours(4),
            //    CreatedBy = "System",
            //    Name = categoryForCreateDto.Name.Trim()
            //};

            Category category = _mapper.Map<Category>(categoryForCreateDto);

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int? id, CategoryForUpdateDto categoryForUpdateDto)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Category existedCategory = await _context.Categories.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (existedCategory == null)
            {
                return NotFound();
            }

            if (await _context.Categories.AnyAsync(c=>c.IsDeleted == false && c.Name.ToLower() == categoryForUpdateDto.Name.Trim().ToLower() && c.Id != id))
            {
                return Conflict();
            }

            existedCategory.Name = categoryForUpdateDto.Name.Trim();
            existedCategory.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedCategory.UpdatedBy = "System";

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Category category = await _context.Categories.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            category.DeletdAt = DateTime.UtcNow.AddHours(4);
            category.DeletdBy = "System";
            category.IsDeleted = true;

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
