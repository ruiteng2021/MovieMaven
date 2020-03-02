using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MovieMaven.Models;
using System;

namespace MovieMaven.MovieAPI
{
    public static class Fetch
    {
        public static HttpClient client = new HttpClient();
        // This is my API_KEY please get your own :) thank-you!
        //public static string api_key = "d194eb72915bc79fac2eb1a70a71ddd3";
        // This is my own API_KEY, your are willcome!
        public static string api_key = "60918711ab06f46cb045b0ee80dcebd9";

        public static string Data { get; set; }
        public static string Search { get; set; }
        public static string Videos { get; set; }
        public static string Details { get; set; }
        public static string Credits { get; set; }
        public static string Actors { get; set; }
        public static string MostPop { get; set; }


        public static async Task GrabPosterAsync(string search)
        {
            ClearYourHead();

            //===========================>>
            // Grabs 20 posters
            HttpResponseMessage posterData =
                await client.GetAsync(
                    "https://api.themoviedb.org/3/search/movie?api_key=" + 
                    api_key + "&query=" + search);

            //System.DateTime currentYear = new DateTime();
            string CurrentYear = DateTime.Now.Year.ToString();
            string currentDate = DateTime.Today.ToString("yyyy-MM-dd");
            string lastmonth = DateTime.Today.AddMonths(-2).ToString("yyyy-MM-dd");
            HttpResponseMessage mostPopularVedio =
                await client.GetAsync(
                    "https://api.themoviedb.org/3/discover/movie?api_key=" +
                    api_key + "&primary_release_date.gte=" + 
                    lastmonth + "&primary_release_date.lte=" + currentDate +
                    "&sort_by = popularity.desc");
            //+ "&sort_by=release_date.desc");

            if (posterData.IsSuccessStatusCode ||
                mostPopularVedio.IsSuccessStatusCode)
            {
                MostPop = await mostPopularVedio.Content.ReadAsStringAsync();
                Data = await posterData.Content.ReadAsStringAsync();
                Program.posterSet = JsonConvert.DeserializeObject<PosterSet>(Data);
                // BestVote has excatly as same data structure as posterSet
                Program.movieInTheatresSet = JsonConvert.DeserializeObject<PosterSet>(MostPop); 
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
            HttpResponseMessage videoDetails =
                await client.GetAsync(
                    "https://api.themoviedb.org/3/movie/" + movieID
                                      + "/videos?api_key=" + api_key + "&language=en-US");

            HttpResponseMessage movieDetails =
            await client.GetAsync(
                "https://api.themoviedb.org/3/movie/" + movieID 
                    + "?api_key=" + api_key + "&language=en-US");

            HttpResponseMessage castDetails =
            await client.GetAsync(
                "https://api.themoviedb.org/3/movie/" + movieID +
                    "/credits?api_key=" + api_key);

            if (videoDetails.IsSuccessStatusCode || 
                movieDetails.IsSuccessStatusCode ||
                castDetails.IsSuccessStatusCode)
            {
                Videos = await videoDetails.Content.ReadAsStringAsync();
                Details = await movieDetails.Content.ReadAsStringAsync();
                Credits = await castDetails.Content.ReadAsStringAsync();
                Program.videoSet = JsonConvert.DeserializeObject<VideoSet>(Videos);
                Program.movie = JsonConvert.DeserializeObject<Movie>(Details);
                Program.credits = JsonConvert.DeserializeObject<Credits>(Credits);
            }
            else
            {
                Data = null;
            }
        }

        public static async Task GetActorDetails(string id)
        {
            ClearYourHead();

            //===========================>>
            // Grab Actor Details
            HttpResponseMessage actorData =
                await client.GetAsync("https://api.themoviedb.org/3/person/" + id +
                    "?api_key=" + api_key + "&language=en-US");

            if (actorData.IsSuccessStatusCode)
            {
                Data = await actorData.Content.ReadAsStringAsync();
                Program.actor = JsonConvert.DeserializeObject<Actor>(Data);
            }
            else
            {
                Data = null;
            }
        }

        public static async Task GetActorImages(string id)
        {
            ClearYourHead();

            //===========================>>
            // Grab Actor Details
            HttpResponseMessage profileData =
                await client.GetAsync("https://api.themoviedb.org/3/person/" + id 
                    + "/images" + "?api_key=" + api_key + "&language=en-US");

            if (profileData.IsSuccessStatusCode)
            {
                Data = await profileData.Content.ReadAsStringAsync();
                Program.profileSet = JsonConvert.DeserializeObject<ProfileSet>(Data);
            }
            else
            {
                Data = null;
            }
        }

        public static async Task GetRelatedMovies(string id)
        {
            ClearYourHead();

            //===========================>>
            // Grab Related Movies
            HttpResponseMessage relatedData =
                await client.GetAsync("https://api.themoviedb.org/3/discover/movie?with_cast=" + id + 
                "&sort_by=revenue.desc&api_key=" + api_key + "&language=en-US");

            if (relatedData.IsSuccessStatusCode)
            {
                Data = await relatedData.Content.ReadAsStringAsync();
                Program.relatedSet = JsonConvert.DeserializeObject<RelatedSet>(Data);
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
    } // class
} // namespace