using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;

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
            StringBuilder builder = new StringBuilder();
            builder.Append(APIString);
            builder.Append(bsbNumber);
            builder.Append(".json");
            //String requestUrl = APIString + bsbNumber + ".json";
            String requestUrl = builder.ToString();
            Console.WriteLine("Sending request to: " + requestUrl);
            HttpResponseMessage result = await Client.GetAsync(requestUrl);
            if (result.IsSuccessStatusCode)
            {
                String json = await result.Content.ReadAsStringAsync();
                JsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(json);
                BankResult = new Bank(JsonObject.data);   
            }

        }

        public async Task BSBQuery(char[] bsbNumber)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(APIString);
            builder.Append(bsbNumber);
            builder.Append(".json");
            String requestUrl = builder.ToString();
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
