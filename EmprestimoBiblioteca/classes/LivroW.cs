using BibliotecaApi.Models;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimoBiblioteca.classes
{

    public class LivroW
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public int QuantidadeDisponivel { get; set; }
        

        public async Task<List<LivroW>> BuscarTodosAsync()
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Livro", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<LivroW>>(response.Content);
            }
            else
                return null;

            
        }

        public async Task<List<LivroW>> BuscarPorTituloAsync(string titulo)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Livro/buscar-por-nome/" + titulo, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<LivroW>>(response.Content);
            }
            else
                return null;


        }


        public async Task<LivroW> ObterLivroAsync(int id )
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Livro/"+ id, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<LivroW>(response.Content);
            }
            else
                return null;


        }

        public async Task<bool> AtualizarLivro(int id, LivroW livro)//------------------
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Livro/alterar-por-livro/" + id, Method.Put);

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(livro);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

         public  async  Task<LivroW> AdicionarLivro(LivroW livro)
         {
            try
            {
                var client = new RestClient();
                var request = new RestRequest("https://localhost:7273/api/Livro", Method.Post);

                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(livro);

                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<LivroW>(response.Content);

                }
                else
                {
                    return livro;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null; 
            }

        }
        public async Task<bool> DeletarLivro(int id)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Livro/deletar-por-Livro/" + id, Method.Delete);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
  
}


