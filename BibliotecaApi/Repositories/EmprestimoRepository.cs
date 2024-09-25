using BibliotecaApi.Data;
using BibliotecaApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace BibliotecaApi.Repositories
{
    public class EmprestimoRepository
    {
        private readonly DataContext context;

        public EmprestimoRepository(IConfiguration configuration)
        {
            var options = new DbContextOptionsBuilder<DataContext>();
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            context = new DataContext(options.Options);
        }

        public IEnumerable<Emprestimo> BuscarTodos()
        {
            return context.Emprestimos;
        }

        public async Task<IEnumerable<Emprestimo>> BuscarEmprestimosComLivrosAsync()
        {
            return await context.Emprestimos
                .Include(e => e.Livro) 
                .ToListAsync();
        }


        public IEnumerable<Emprestimo> BuscarEmprestimoPorLeitorId(int id)
        {
            return context.Emprestimos.Where(e => e.LeitorId == id).ToList();
        }


        public Emprestimo? BuscarPorEmprestimoId(int id)
        {
            return context.Emprestimos.Where(x => x.EmprestimoId == id).FirstOrDefault();

        }


        public int AdicionarEmprestimo(Emprestimo emprestimo)
        {
            try
            {
                context.Emprestimos.Add(emprestimo);
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
           public int Excluir(int id)
        {
            Emprestimo? emprestimo= BuscarPorEmprestimoId(id);
            if (emprestimo != null)
            {
                context.Remove(emprestimo);
                return context.SaveChanges();
            }
            return 0;
        }


    }

    }

