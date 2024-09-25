using BibliotecaApi.Data;
using BibliotecaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApi.Repositories
{
    public class DevolucaoRepository
    {
        private readonly DataContext context;

        public DevolucaoRepository(IConfiguration configuration)
        {
            var options = new DbContextOptionsBuilder<DataContext>();
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            context = new DataContext(options.Options);
        }

        public IEnumerable<dynamic> BuscarDevolucoes()
        {
            var query = from d in context.Devolucoes
                        join e in context.Emprestimos on d.EmprestimoId equals e.EmprestimoId
                        select new
                        {
                            d.DevolucaoId,
                            e.EmprestimoId,
                            e.LeitorId,
                            e.LivroId,
                            d.DataDevolucao,
                            e.DataDevolucaoPrevista,
                           
                           
                        };

            return query.ToList();
        }
        public dynamic? BuscarPorDevolucaoId(int devolucaoId)
        {
            var query = from d in context.Devolucoes
                        join e in context.Emprestimos on d.EmprestimoId equals e.EmprestimoId
                        where d.DevolucaoId == devolucaoId
                        select new
                        {
                            d.DevolucaoId,
                            e.EmprestimoId,
                            e.LeitorId,
                            e.LivroId,
                            d.DataDevolucao,
                            e.DataDevolucaoPrevista,
                        };

            return query.FirstOrDefault();
        }

        public IEnumerable<dynamic> BuscarPorLeitorId(int leitorId)
        {
            var query = from d in context.Devolucoes
                        join e in context.Emprestimos on d.EmprestimoId equals e.EmprestimoId
                        where e.LeitorId == leitorId
                        select new
                        {
                            d.DevolucaoId,
                            e.EmprestimoId,
                            e.LeitorId,
                            e.LivroId,
                            d.DataDevolucao,
                            e.DataDevolucaoPrevista,
                        };

            return query.ToList();
        }

        public int AdicionarDevolucao(Devolucao devolucao)
        {
            try
            {
                context.Devolucoes.Add(devolucao);
                return context.SaveChanges();
            }
            catch (DbUpdateException dbEx)
            {
                var innerException = dbEx.InnerException?.Message;
                throw new Exception("Erro ao adicionar devolução: " + innerException, dbEx);
            }
        }

        public Devolucao? BuscarPorDevolucaoparaDeletar(int id)
        {
            return context.Devolucoes.Where(x => x.DevolucaoId == id).FirstOrDefault();

        }
        public int Excluir(int id)
        {
            Devolucao? devolucao = BuscarPorDevolucaoparaDeletar(id);
            if (devolucao!= null)
            {
                context.Remove(devolucao);
                return context.SaveChanges();
            }
            return 0;
        }




    }
}

