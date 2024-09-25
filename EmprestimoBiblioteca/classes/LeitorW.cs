using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimoBiblioteca.classes
{
    internal class LeitorW
    {


        public int LeitorId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }
        public string DataNascimento { get; set; }

       
        public async Task<List<LeitorW>> BuscarTodosAsync()
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Leitor", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<LeitorW>>(response.Content);
            }
            else
                return null;


        }
        public async Task<LeitorW> ObterLeitorAsync(int id)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Leitor/buscar-leitor-por-leitor/" + id, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<LeitorW>(response.Content);
            }
            else
                return null;


        }

        public async Task<List<LeitorW>> BuscarPorLeitoresIdAsync(int id)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Emprestimo/emprestimo-por-leitor/" + id, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<LeitorW>>(response.Content);
            }
            else
                return null;


        }
        public async Task<bool> AtualizarLeitor(int id, LeitorW leitor)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Leitor/alterar-por-Leitor/" + id, Method.Put);

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(leitor);

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
        public async Task<LeitorW> AdicionarLeitor(LeitorW leitor)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest("https://localhost:7273/api/Leitor", Method.Post);

                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(leitor);

                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<LeitorW>(response.Content);

                }
                else
                {
                    return leitor;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public async Task<bool> DeletarLeitor(int id)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Leitor/deletar-por-Leitor/" + id, Method.Delete);

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
