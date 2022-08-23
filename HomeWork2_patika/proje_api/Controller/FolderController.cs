using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using proje_data.Model;
using proje_dto.dto;
using proje_service.Abstract;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_api.Controller
{
    [Route("api/v1/protein/[controller]")]
    [ApiController]
    public class FolderController : BaseController<FolderDto, Folder>
    {
        public FolderController(IFolderService FolderService, IMapper mapper) : base(FolderService, mapper)
        {

        }

        [HttpGet("{id:int}")]
        public new async Task<IActionResult> GetByIdAsync(int id)
        {
            Log.Information($"{User.Identity?.Name}: get a Folder with Id is {id}.");

            return await base.GetByIdAsync(id);
        }

        [HttpPost]
        public new async Task<IActionResult> CreateAsync([FromBody] FolderDto resource)
        {
            Log.Information($"{User.Identity?.Name}: create a Folder.");

            return await base.CreateAsync(resource);
        }

        [HttpPut("{id:int}")]
        public new async Task<IActionResult> UpdateAsync(int id, [FromBody] FolderDto resource)
        {
            Log.Information($"{User.Identity?.Name}: update a Folder with Id is {id}.");

            return await base.UpdateAsync(id, resource);
        }


        [HttpDelete("{id:int}")]
        public new async Task<IActionResult> DeleteAsync(int id)
        {
            Log.Information($"{User.Identity?.Name}: delete a Folder with Id is {id}.");

            return await base.DeleteAsync(id);
        }

    }
}
