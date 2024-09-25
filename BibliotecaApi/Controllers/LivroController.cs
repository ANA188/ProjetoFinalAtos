using Azure.Core;
using BibliotecaApi.Models;
using BibliotecaApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace BibliotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository Repository;

        public LivroController(IConfiguration config)
        {
            Repository = new LivroRepository(config);
        }
        [HttpGet]
        public IActionResult BuscarTodas()
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

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {


                var Livro = Repository.BuscarPorId(id);
                return Ok(Livro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpGet("buscar-por-nome/{titulo}")]
        public async Task<IActionResult> BuscarPorNome(string titulo)
        {
            try
            {
                if (string.IsNullOrEmpty(titulo))
                {
                    return BadRequest("O título não pode estar vazio.");
                }

                var nomes = await Repository.BuscarPorNomeAsync(titulo);

                return Ok(nomes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Adicionar(LivroRequest request)
        {
            try
            {
                Livro livro = new Livro(request);
                Repository.Adicionar(livro);
                return Ok(livro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

           
        }
        [HttpPut("alterar-por-livro/{id}")]
        public IActionResult Alterar(int id, LivroRequest request)
        {
            try
            {
                Livro livro = new Livro(request);
                livro.LivroId = id;

                int numLinhas = Repository.Alterar(livro);
                return Ok(numLinhas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

            [HttpDelete("deletar-por-Livro/{id}")]
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


        



    

    

