using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iprsms
{
    class Program
    {
        static void Main(string[] args)
        {
            Request ewew = new Request();
            Console.WriteLine("Saldo: {0}\nSms: {1}", ewew.saldo,ewew.sms.Count);
            ewew.sendSms();
           /* var client = new RestClient("http://ipr.net.br/sms/app/controller/receber.php");
            var request = new RestRequest(Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("content-type", "application/json");
            List<Response> x = JsonConvert.DeserializeObject<List<Response>>(client.Execute(request).Content);

            var client2 = new RestClient("https://api.disparopro.com.br/mt");
            var request2 = new RestRequest(Method.POST);
            request2.AddHeader("postman-token", "b491d7e5-a03b-fb87-b817-acd97b329e4a");
            request2.AddHeader("cache-control", "no-cache");
            request2.AddHeader("content-type", "application/json");
            request2.AddHeader("authorization", "Bearer a4f2fdf25058d5c1d7f47b6ed3d77b13c5ab5da5");
            string numero;
            string json;
            foreach (Response t in ewew.sms ) {
                numero = "55" + t.telefone.Replace("(", "").Replace(")", "").Replace("-", "");
                json = "[{ \"numero\": \"" + numero + "\",\"mensagem\":\"IPR Informa: " + t.texto + "\",\"servico\":\"long\"}]";
                request2.AddParameter("application/json", json, ParameterType.RequestBody);
                IRestResponse response = client2.Execute(request2);
                Console.WriteLine(response.Content);
            }*/
            Console.ReadLine();
        }
    }
}
