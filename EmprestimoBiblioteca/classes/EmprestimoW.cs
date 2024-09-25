using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimoBiblioteca.classes
{
    internal class EmprestimoW
    {

        public int EmprestimoId { get; set; }
        public int LeitorId { get; set; }
        public int LivroId { get; set; }
        public string DataEmprestimo { get; set; }
        public string DataDevolucaoPrevista { get; set; }


        public async Task<List<EmprestimoW>> BuscarTodosAsync()
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Emprestimo", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<EmprestimoW>>(response.Content);
            }
            else
                return null;


        }     



        public async Task<EmprestimoW> ObterEmprestimoAsync(int id)
        {

            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Emprestimo/emprestimo-por-emprestimo/" + id, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<EmprestimoW>(response.Content); //
            }
            else
                return null;


        }

        public async Task<List<EmprestimoW>> BuscarPorLeitorIdAsync(int id)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Emprestimo/emprestimo-por-leitor/" + id, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<EmprestimoW>>(response.Content);
            }
            else
                return null;


        }
        public async Task<EmprestimoW> AdicionarEmprestimo(EmprestimoW emprestimo)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest("https://localhost:7273/api/Emprestimo", Method.Post);

                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(emprestimo);

                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<EmprestimoW>(response.Content);

                }
                else
                {
                    return emprestimo;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public async Task<bool> DeletarEmprestimo(int id)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Emprestimo/deletar-por-emprestimo/" + id, Method.Delete);

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

