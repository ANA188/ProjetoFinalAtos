using BibliotecaApi.Models;
using BibliotecaApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevolucaoController : ControllerBase
    {
        private readonly DevolucaoRepository _repository;

        public DevolucaoController(DevolucaoRepository repository)
        {
            _repository = repository;
        }

     

        [HttpGet("devolucoes")]
        public IActionResult BuscarDevolucoes()
        {
            try
            {
                var result = _repository.BuscarDevolucoes();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("devolucao-por-devolucao/{id}")]
        public IActionResult BuscarDevolucaoId(int id)
        {
            try
            {
                var result = _repository.BuscarPorDevolucaoId(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("devolucoes-por-leitor/{id}")]
        public IActionResult Id(int id)
        {
            try
            {
                var result = _repository.BuscarPorLeitorId(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("Adicionar")]
        public IActionResult Adicionar(DevolucaoRequest request)
        {
            try
            {
                Devolucao devolucao = new Devolucao(request);
                _repository.AdicionarDevolucao(devolucao);
                return Ok(devolucao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [HttpDelete("delete-por-devolucao/{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                int numLinhas = _repository.Excluir(id);
                return Ok(numLinhas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
