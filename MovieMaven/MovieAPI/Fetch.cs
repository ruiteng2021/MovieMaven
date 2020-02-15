using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MovieMaven.Models;

namespace MovieMaven.MovieAPI
{
    public static class Fetch
    {
        public static HttpClient client = new HttpClient();
        public static string api_key = "d194eb72915bc79fac2eb1a70a71ddd3";
        
        public static string Data { get; set; }
        public static string Search { get; set; }
        public static string Videos { get; set; }


        public static async Task GrabPosterAsync(string search)
        {
            ClearYourHead();

            //===========================>>
            // Grabs 20 posters
            HttpResponseMessage posterData =
                await client.GetAsync(
                    "https://api.themoviedb.org/3/search/movie?api_key=" + 
                    api_key + "&query=" + search);

            if(posterData.IsSuccessStatusCode)
            {
                Data = await posterData.Content.ReadAsStringAsync();
                Program.posterSet = JsonConvert.DeserializeObject<PosterSet>(Data);
            }
            else
            {
                Data = null;
            }
        } // GrabPosterAsync()


        public static async Task GetMovieDetails(string movieID)
        {
            ClearYourHead();

            //===========================>>
            // Grabs Video details
            HttpResponseMessage movieDetails =
                await client.GetAsync(
                    "https://api.themoviedb.org/3/movie/" + movieID
                                      + "/videos?api_key=" + api_key + "&language=en-US");

            if (movieDetails.IsSuccessStatusCode)
            {
                Videos = await movieDetails.Content.ReadAsStringAsync();
                Program.videoSet = JsonConvert.DeserializeObject<VideoSet>(Videos);
            }
            else
            {
                Data = null;
            }
        }

        private static void ClearYourHead()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(
                    "applicationException/json"));
        } // ClearYourHead()
    }
}