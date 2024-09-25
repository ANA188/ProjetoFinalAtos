using BibliotecaApi.Data;
using BibliotecaApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApi.Repositories
{
    public class LivroRepository
    {
        private readonly DataContext context;

        public LivroRepository(IConfiguration configuration)
        {
            var options = new DbContextOptionsBuilder<DataContext>();
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            context = new DataContext(options.Options);
        }

        public LivroRepository()
        {
        }

        public IEnumerable<Livro> BuscarTodos()
        {
            return context.Livros;
        }

        public Livro? BuscarPorId(int id)
        {
            return context.Livros.Where(x => x.LivroId == id).FirstOrDefault();

        }

        public int Adicionar(Livro livro)
        {
            try
            {
                context.Livros.Add(livro);
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

          
            }
        public async Task<List<Livro>> BuscarPorNomeAsync(string titulo)
        {
            return await context.Livros.Where(x => x.Titulo.ToLower().Contains(titulo.ToLower())).ToListAsync();
        }

        public int Alterar(Livro livro)
        {
            context.Entry(livro).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public int Excluir(int id)
        {
            Livro? livro = BuscarPorId(id);
            if (livro != null)
            {
                context.Remove(livro);
                return context.SaveChanges();
            }
            return 0;
        }


    }
}
