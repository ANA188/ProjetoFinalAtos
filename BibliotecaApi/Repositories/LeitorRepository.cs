using BibliotecaApi.Data;
using BibliotecaApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BibliotecaApi.Repositories
{

    public class LeitorRepository
    {
        private readonly DataContext context;

        public LeitorRepository(IConfiguration configuration)
        {
            var options = new DbContextOptionsBuilder<DataContext>();
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            context = new DataContext(options.Options);
        }

        public IEnumerable<Leitor> BuscarTodos()
        {
            return context.Leitores;
        }

        public Leitor? BuscarPorId(int id)
        {
            return context.Leitores.Where(x => x.LeitorId == id).FirstOrDefault();

        }


        public int Adicionar(Leitor leitor)
        {
            try
            {
                context.Leitores.Add(leitor);
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public async Task<List<Leitor>> BuscarPorNomeAsync(string nome)
        {
            return await context.Leitores.Where(x => x.Nome.ToLower().Contains(nome.ToLower())).ToListAsync();
        }

        public int Alterar(Leitor leitor)
        {
            context.Entry(leitor).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public int Excluir(int id)
        {
            Leitor leitor = BuscarPorId(id);
            if (leitor != null)
            {
                context.Remove(leitor);
                return context.SaveChanges();
            }
            return 0;
        }

    }


    }




