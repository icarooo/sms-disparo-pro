using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iprsms
{
    public class Response
    {
        public int idsms { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string texto { get; set; }
    }
    public class Data
    {
        public string numero { get; set; }
        public string servico { get; set; }
        public string mensagem { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public int status { get; set; }
        public detailinfo detail { get; set; }
    }
    public class detailinfo
    {
        public string saldo { get; set; }
    }
}
