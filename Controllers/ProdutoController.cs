using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using AutoGlass.Repository.interfaces;
using AutoGlass.Services.Interfaces;
using System.Threading.Tasks;
using AutoGlass.Models.Entitys;

namespace AutoGlass.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {

        private readonly IProtudoServices _protudoServices;

        public ProdutoController(IProtudoServices protudoServices)
        {
            _protudoServices = protudoServices;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> GetAll(string search)
        {
            try
            {
                var result = await _protudoServices.Get();

                if (result == null)
                    return NotFound("Não foi possivel consultar.");

                return Ok(result);
            }
            catch (System.Exception e)
            {
                return NotFound("ERRO: " + e.Message);
            }
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var result = await _protudoServices.GetId(id);

                return Ok(result);
            }
            catch (System.Exception e)
            {
                return NotFound("ERRO: " + e.Message);
            }
        }

        [HttpPut("Insert")]
        public async Task<IActionResult> Insert([FromBody] ProdutoEntitys protudo)
        {
            try
            {
                var result = await _protudoServices.Insert(protudo);

                return Ok(result);
            }
            catch (System.Exception e)
            {
                return NotFound("ERRO: " + e.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] ProdutoEntitys protudo)
        {
            try
            {
                var result = await _protudoServices.Update(protudo);

                return Ok(result);
            }
            catch (System.Exception e)
            {
                return NotFound("ERRO: " + e.Message);
            }
        }

        [HttpPut("Remove/{cod_produto}")]
        public async Task<IActionResult> Remove(int cod_produto)
        {
            try
            {
                var result = await _protudoServices.Remove(cod_produto);

                return Ok(result);
            }
            catch (System.Exception e)
            {
                return NotFound("ERRO: " + e.Message);
            }
        }
    }
}
