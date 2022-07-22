using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SAGOM.Application.Interfaces;
using SAGOM.Application.DTOs;

namespace SAGOM.WebAPI.Controllers
{
    [ApiController]
    [Route("sagomapi/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
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
            role = await _roleService.Add(role);
            return new CreatedAtRouteResult("GetRoleById", new { id = role.Id }, role);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] RoleDTO role)
        {

            role.SetId(id);

            if (role != null)
                await _roleService.Update(role);
            else
                return NotFound("Role not founded");

            return new CreatedAtRouteResult("GetRoleById", new { id = role.Id }, role);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            RoleDTO? role = await _roleService.GetRoleById(id);

            if (role != null)
                await _roleService.Remove(role);
            else
               return NotFound("Role not founded");

            return Ok(role);
        }


    }
}