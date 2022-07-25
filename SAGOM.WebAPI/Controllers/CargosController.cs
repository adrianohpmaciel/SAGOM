using Microsoft.AspNetCore.Mvc;
using SAGOM.Application.Interfaces;
using SAGOM.Application.DTOs;
using SAGOM.WebAPI.Models;
using System.Xml.Linq;
using SAGOM.Domain.Entities;
using Newtonsoft.Json;

namespace SAGOM.WebAPI.Controllers
{
    [ApiController]
    [Route("sagomapi/[controller]")]
    public class CargosController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public CargosController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet(Name = "GetRoles")]
        public async Task<ActionResult<IEnumerable<CargoModel>?>> Get()
        {

            IEnumerable<RoleDTO> roles = await _roleService.GetAllRoles();
            List<CargoModel> cargoModels = new List<CargoModel>();
            foreach (RoleDTO roleDTO in roles)
            {
                cargoModels.Add(new CargoModel(roleDTO));
            }

            return (Ok(cargoModels));

        }

        [HttpGet("{id:int}", Name = "GetRoleById")]
        public async Task<ActionResult<CargoModel>> Get(int id)
        {
            return Ok(new CargoModel(await _roleService.GetRoleById(id)));
        }

        [HttpPost(Name = "CreateRole")]
        public async Task<ActionResult<CargoModel>> Post([FromBody]CargoModel role)
        {
            RoleDTO roleDTO = new RoleDTO(role.Nome, role.Descricao);

            roleDTO = await _roleService.Add(roleDTO);


            return Ok(new CargoModel(await _roleService.GetRoleById(roleDTO.Id.GetValueOrDefault())));
        }

        [HttpPut("UpdateRoleDescription/{id:int}")]
        public async Task<ActionResult<CargoModel>> Put(int id, [FromBody][JsonProperty("Descricao")] string? descricao)
        {
            RoleDTO? roleToUpdate = await _roleService.GetRoleById(id);

            if (roleToUpdate != null)
            {
                roleToUpdate.Description = descricao;
                await _roleService.Update(roleToUpdate);
            }                
            else
                return NotFound("Role not founded");

            return new CreatedAtRouteResult("GetRoleById", new { id = roleToUpdate.Id }, roleToUpdate);
        }

        [HttpDelete("{id:int}", Name = "DeleteRole")]
        public async Task<ActionResult<CargoModel>> Delete(int id)
        {
            RoleDTO? role = await _roleService.GetRoleById(id);

            if (role != null)
                await _roleService.Remove(role);
            else
                return NotFound("Role not founded");

            return Ok(new CargoModel(role));
        }

        [HttpDelete("{nome}", Name = "DeleteRoleByName")]
        public async Task<ActionResult> Delete(string nome)
        {
            try
            {
                await _roleService.RemoveByName(nome);
                return Ok("Remoção concluída con sucesso");

            }
            catch
            {
                return NotFound("Role not founded");
            }

        }



    }
}