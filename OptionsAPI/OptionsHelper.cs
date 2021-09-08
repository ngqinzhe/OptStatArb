using System;
using System.Net.Http;
using System.Net.Http.Headers;
namespace OptionsAPI
{
    public class OptionsHelper
    {
        public static HttpClient httpClient;

        public static void Initialize()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
