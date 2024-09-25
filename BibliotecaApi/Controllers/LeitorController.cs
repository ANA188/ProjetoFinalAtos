using BibliotecaApi.Models;
using BibliotecaApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeitorController : ControllerBase
    {
            private readonly LeitorRepository Repository;

            public LeitorController(IConfiguration config)
            {
                Repository = new LeitorRepository(config);
            }
            [HttpGet]
            public IActionResult BuscarTodos()
            {
                try
                {


                    var lista = Repository.BuscarTodos();
                    return Ok(lista);
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }

            [HttpGet("buscar-leitor-por-leitor/{id}")]
            public IActionResult BuscarPorId(int id)
            {
                try
                {


                    var Leitor = Repository.BuscarPorId(id);
                    return Ok(Leitor);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }


            }
            [HttpGet("buscar-por-nome")]
            public async Task<IActionResult> BuscarLeitorPorNome(string nome)
            {
                try
                {
                    if (string.IsNullOrEmpty(nome))
                    {
                        return BadRequest("O nome não pode estar vazio.");
                    }

                    var livros = await Repository.BuscarPorNomeAsync(nome);

                    return Ok(nome);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            [HttpPost]
            public IActionResult Adicionar(LeitorRequest request)
            {
            try
            {
                Leitor leitor = new Leitor(request);
                Repository.Adicionar(leitor);
                return Ok(leitor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
            [HttpPut("alterar-por-Leitor/{id}")]
            public IActionResult Alterar(int id, LeitorRequest request)
            {
                try
                {
                    Leitor leitor = new Leitor(request);
                    leitor.LeitorId = id;

                    int numLinhas = Repository.Alterar(leitor);
                    return Ok(numLinhas);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }

            [HttpDelete("deletar-por-Leitor/{id}")]
            public IActionResult Excluir(int id)
            {
                try
                {
                    int numLinhas = Repository.Excluir(id);
                    return Ok(numLinhas);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }

        }
    }













