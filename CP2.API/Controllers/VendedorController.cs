using CP2.Application.Dtos;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using CP2.Domain.Interfaces.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CP2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorApplicationService _applicationService;

        public VendedorController(IVendedorApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var objModel = _applicationService.ObterTodosVendedores();
            return Ok(objModel);
        }

        [HttpGet("{id}")]
        public IActionResult GetPorId(int id)
        {
            var objModel = _applicationService.ObterVendedorPorId(id);
            if (objModel is not null)
                return Ok(objModel);
            return NotFound("Vendedor não encontrado");
        }

        [HttpPost]
        public IActionResult Post([FromBody] IVendedorDto entity)
        {
            try
            {
                _applicationService.SalvarDadosVendedor(entity);
                return CreatedAtAction(nameof(GetPorId), new { id = entity.Id }, entity);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] IVendedorDto entity)
        {
            try
            {
                _applicationService.EditarDadosVendedor(id, entity);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _applicationService.DeletarDadosVendedor(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }
    }
}
