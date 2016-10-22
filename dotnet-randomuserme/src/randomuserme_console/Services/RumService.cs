using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using Models;

namespace Services
{
    public class RumService
    {
        private static string RESTURL = "http://api.randomuser.me/?results=1";
        
        public RumService() 
        {
        }

        public static async Task<RandomUserMeSearch> GetRandomUsers()
        {
            string url = RumService.RESTURL;

            using (var handler = new HttpClientHandler())
            {
                handler.AllowAutoRedirect = false;
                handler.ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => true;

                using (var client = new HttpClient(handler))
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var serializer = new DataContractJsonSerializer(typeof(RandomUserMeSearch));
                        var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
                        RandomUserMeSearch randomuser = (RandomUserMeSearch) serializer.ReadObject(ms);

                        return randomuser;
                    }
                }
            }
            return null;
        }
    }
}
