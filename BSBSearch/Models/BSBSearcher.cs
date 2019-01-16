using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace BSBSearch.Models
{
    class BSBSearcher
    {
        public Bank BankResult = new Bank();
        public String BSBNumber { get; set; }
        private readonly String APIString = "http://api.beliefmedia.com/bsb/";
        HttpClient Client = new HttpClient();
        RootObject JsonObject = new RootObject();

        public async Task BSBQuery(String bsbNumber)
        {
            String requestUrl = APIString + bsbNumber + ".json";
            Console.WriteLine("Sending request to: " + requestUrl);
            HttpResponseMessage result = await Client.GetAsync(requestUrl);
            if (result.IsSuccessStatusCode)
            {
                String json = await result.Content.ReadAsStringAsync();
                JsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(json);
                BankResult = new Bank(JsonObject.data);   
            }

        }

    }

}
