using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieMaven.MovieAPI
{
    public static class Fetch
    {
        public static HttpClient client = new HttpClient();
        public static string Data { get; set; }
        public static string Search { get; set; }
        //public static string api_key = "d194eb72915bc79fac2eb1a70a71ddd3";
        public static string api_key = "OmU5MmRmZGQ4MTc2NTEyNTU2YjEzYTIwMDdkZTFlZGMx";
        

        public static async Task GrabPosterAsync(string search)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(
                    "applicationException/json"));

        
              /*
              HttpResponseMessage posterData =
                  await client.GetAsync(
                      "https://api.themoviedb.org/3/search/movie?api_key=" + 
                      api_key + "&query=" + search);
              */

            HttpResponseMessage posterData =
                await client.GetAsync(
                       "https://api-v2.intrinio.com/companies/AAPL?api_key=" +
                        api_key + "&query=" + search);
            if (posterData.IsSuccessStatusCode)
            {
                Data = await posterData.Content.ReadAsStringAsync();
                // next
            }
            else
            {
                Data = null;
            }
        } // GrabPosterAsync()
    }
}
