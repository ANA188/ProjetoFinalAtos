
using BibliotecaApi.Models;
using BibliotecaApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoController : ControllerBase
    {
        private readonly EmprestimoRepository Repository;
        // private readonly IMapper _mapper;
        public EmprestimoController(IConfiguration config)
        {
            Repository = new EmprestimoRepository(config);

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

        [HttpGet("emprestimo-por-leitor/{id}")]
        public IActionResult BuscarPorLeitorId(int id)
        {
            try
            {


                var emprestimos = Repository.BuscarEmprestimoPorLeitorId(id);
                return Ok(emprestimos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("emprestimo-por-emprestimo/{id}")]
        public IActionResult BuscarPorEmprestimoId(int id)
        {
            try
            {


                var emprestimos = Repository.BuscarPorEmprestimoId(id);
                return Ok(emprestimos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("emprestimo-com-titulos-livros")]
        public async Task<IActionResult> BuscarEmprestimosComTitulosLivro()
        {
            var emprestimos = await Repository.BuscarEmprestimosComLivrosAsync();

            var resultado = emprestimos.Select(e => new
            {
                e.EmprestimoId,
                e.LeitorId,
                LivroTitulo = e.Livro.Titulo, 
                e.DataEmprestimo,
                e.DataDevolucaoPrevista
            });

            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Adicionar(EmprestimoRequest request)
        {
            try
            {
                Emprestimo emprestimo = new Emprestimo(request);
                Repository.AdicionarEmprestimo(emprestimo);
                return Ok(emprestimo); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

           [HttpDelete("deletar-por-emprestimo/{id}")]
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
