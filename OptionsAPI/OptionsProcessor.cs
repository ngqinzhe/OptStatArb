using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OptionsAPI
{
    public class OptionsProcessor
    {
        public async Task<OptionsModel> getAPI(string ticker)
        {
            string url = $"https://query1.finance.yahoo.com/v7/finance/options/{ticker}";
            OptionsHelper.Initialize();

            using (var response = await OptionsHelper.httpClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    OptionsModel optmodel = await response.Content.ReadAsAsync<OptionsModel>();
                    return optmodel;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
