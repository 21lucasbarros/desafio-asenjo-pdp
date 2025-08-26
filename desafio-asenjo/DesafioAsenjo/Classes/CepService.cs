using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesafioAsenjo.Classes
{
    internal class CepService
    {
        public static async Task<(string Estado, string Cidade, string Bairro, string Rua)> BuscarEndereco(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";
                var response = await client.GetStringAsync(url);
                var json = JObject.Parse(response);

                return (
                    json["uf"].ToString(),
                    json["localidade"].ToString(),
                    json["bairro"].ToString(),
                    json["logradouro"].ToString()
                );
            }
        }
    }
}
