﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using proje_data.Model;
using proje_dto.dto;
using proje_service.Abstract;
using Serilog;
using System.Threading.Tasks;

namespace proje_api.Controller
{
    [Route("api/v1/protein/[controller]")]
    [ApiController]
    public class CountryController : BaseController<CountryDto, Country>
    {
        
        public CountryController(IBaseService<CountryDto, Country> baseService, IMapper mapper) : base(baseService, mapper)
        {
        }

        [HttpGet("{id:int}")]
        public new async Task<IActionResult> GetByIdAsync(int id)
        {
            Log.Information($"{User.Identity?.Name}: get a Country with Id is {id}.");

            return await base.GetByIdAsync(id);
        }

        [HttpPost]
        public new async Task<IActionResult> CreateAsync([FromBody] CountryDto resource)
        {
            Log.Information($"{User.Identity?.Name}: create a Country.");

            return await base.CreateAsync(resource);
        }

        [HttpPut("{id:int}")]
        public new async Task<IActionResult> UpdateAsync(int id, [FromBody] CountryDto resource)
        {
            Log.Information($"{User.Identity?.Name}: update a Country with Id is {id}.");

            return await base.UpdateAsync(id, resource);
        }


        [HttpDelete("{id:int}")]
        public new async Task<IActionResult> DeleteAsync(int id)
        {
            Log.Information($"{User.Identity?.Name}: delete a Country with Id is {id}.");

            return await base.DeleteAsync(id);
        }

    }
}
