﻿using System.Net.Http;
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
        public static string Details { get; set; }
        public static string Credits { get; set; }


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
        private static void ClearYourHead()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(
                    "applicationException/json"));
        } // ClearYourHead()
    }
}