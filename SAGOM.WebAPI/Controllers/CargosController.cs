using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SAGOM.Application.Interfaces;
using SAGOM.WebAPI.Models;
using SAGOM.Application.DTOs;

namespace SAGOM.WebAPI.Controllers
{
    [ApiController]
    [Route("sagomapi/[controller]")]
    public class CargosController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IMapper mapper;

        public CargosController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet(Name = "GetRoles")]
        public async Task<ActionResult<IEnumerable<RoleDTO>?>> Get()
        {
            return Ok(await _roleService.GetAllRoles());

        }

        [HttpGet("{id:int}", Name = "GetRoleById")]
        public async Task<ActionResult<RoleDTO?>> Get(int id)
        {
            return Ok(await _roleService.GetRoleById(id));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RoleDTO role)
        {
            await _roleService.Add(role);

            return new CreatedAtRouteResult("GetRoleById", new { id = role.Id }, role);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] RoleDTO role)
        {
            await _roleService.Update(role);

            return new CreatedAtRouteResult("GetRoleById", new { id = role.Id }, role);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var role = await _roleService.GetRoleById(id); 

            await _roleService.Remove(role);

            return Ok(role);
        }


    }
}