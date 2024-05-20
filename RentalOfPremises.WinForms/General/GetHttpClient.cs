using System;
using System.Net.Http;

namespace RentalOfPremises.WinForms
{
    public class GetHttpClient
    {
        public HttpClient GetClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7190/");
            return client;
        }
    }
}
