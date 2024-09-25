using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimoBiblioteca.classes
{
    internal class DevolucaoW
    {

     
            public int DevolucaoId { get; set; }
            public int EmprestimoId { get; set; }
            public int LeitorId { get; set; }
            public int LivroId { get; set; }
            public string DataDevolucao { get; set; }
           
            public string DataDevolucaoPrevista { get; set; }

        public async Task<List<DevolucaoW>> BuscarTodosAsync()
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Devolucao/devolucoes", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<DevolucaoW>>(response.Content);//
            }
            else
                return null;


        }

        public async Task<DevolucaoW> ObterDevolucaoAsync(int id)
        {

            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Devolucao/devolucao-por-devolucao/" + id, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<DevolucaoW>(response.Content); //
            }
            else
                return null;


        }

        public async Task<List<DevolucaoW>> BuscarPorLeitorIdAsync(int id)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Devolucao/devolucoes-por-leitor/" + id, Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<DevolucaoW>>(response.Content);
            }
            else
                return null;


        }

        public async Task<DevolucaoW> AdicionarDevolucao(DevolucaoW devolucao)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest("https://localhost:7273/api/Devolucao/Adicionar", Method.Post);

                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(devolucao);

                RestResponse response = await client.ExecuteAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<DevolucaoW>(response.Content);

                }
                else
                {
                    return devolucao;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public async Task<bool> DeletarDevolucao(int id)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7273/api/Devolucao/delete-por-devolucao/" + id, Method.Delete);

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
