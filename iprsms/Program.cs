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
            Console.ReadLine();
        }
    }
}
