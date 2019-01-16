using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
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

        public async void BSBQuery(String bsbNumber)
        {
            String requestUrl = APIString + bsbNumber + ".json";
            Console.WriteLine("Sending request to: " + requestUrl);
            HttpResponseMessage result = await Client.GetAsync(requestUrl);
            if (result.IsSuccessStatusCode)
            {
                Console.WriteLine("Attempting to retrieve JSON resource");
                String json = await result.Content.ReadAsStringAsync();
                JsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(json);
                Console.WriteLine("INSTCODE");
                Console.WriteLine(JsonObject.data.instcode);
                BankResult = new Bank(JsonObject.data);
                
            }

        }

        //public Bank SetBankData()
        //{
            
        //    BankData data = new BankData(JsonObject);
        //    Console.WriteLine(JsonObject.data.instcode);
        //    Bank bank = new Bank(JsonObject.data);

        //    return bank;
        //}

    }

}
