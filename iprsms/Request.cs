using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iprsms
{
    public class Request
    {
        RestClient client = new RestClient();
        RestRequest request = new RestRequest();
        public List<Response> sms = new List<Response>();
        public string saldo;
        public Request()
        {
            request.AddHeader("authorization", "Bearer a4f2fdf25058d5c1d7f47b6ed3d77b13c5ab5da5");
            this.getSaldo();
            this.getSms();
        }
        public void getSaldo()
        {
            client.BaseUrl = new Uri("https://api.disparopro.com.br/balance");
            request.Method = Method.GET;
            Data ew = JsonConvert.DeserializeObject<Data>(client.Execute(request).Content);
            this.saldo = ew.detail.saldo;
        }
        public void getSms()
        {
            client.BaseUrl = new Uri("http://ipr.net.br/sms/app/controller/receber.php");
            request.Method = Method.GET;
            this.sms = JsonConvert.DeserializeObject<List<Response>>(client.Execute(request).Content);
        }
        public void sendSms()
        {
            client.BaseUrl = new Uri("https://api.disparopro.com.br/mt");
            request.Method = Method.POST;
            string json,numero;
            foreach (Response t in this.sms)
            {
                RestClient client2 = new RestClient();
                RestRequest request2 = new RestRequest();
                request2.AddHeader("authorization", "Bearer a4f2fdf25058d5c1d7f47b6ed3d77b13c5ab5da5");
                request2.Method = Method.POST;
                numero = "55" + t.telefone.Replace("(", "").Replace(")", "").Replace("-", "");
                json = "[{ \"numero\": \"55" + t.telefone.Replace("(", "").Replace(")", "").Replace("-", "") + "\",\"mensagem\":\"IPR Internet: " + t.texto + "\",\"servico\":\"short\"}]";
                Console.WriteLine(json);
                request2.AddParameter("application/json", json, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request2);
                Console.WriteLine(response.Content);
            }

        }
    }
}
