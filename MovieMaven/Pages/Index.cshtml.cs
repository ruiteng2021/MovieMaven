using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieMaven.MovieAPI;
using MovieMaven.Models;

namespace MovieMaven.Pages
{
    public class IndexModel : PageModel
    {
        //public string searchTerm = Temp.searchTerm;
        
        // poster data
        public List<string> posterURLs = new List<string>();
        public List<string> overviews = new List<string>();
        public List<string> movieIDs = new List<string>();

        // video data
        public List<string> videoNames = new List<string>();
        public List<string> videoKeys = new List<string>();
        public int MAX_VIDS = 3; // limits the vids that show
        public int videoRandIndex;

        // movie details
        public string movieOverview;
        public int movieRuntime;
        public string movieTagline;
        public int movieRevenue;
        public string movieReleaseDate;

        // cast details
        public List<string> castPics = new List<string>();
        public List<int> actorIDs = new List<int>();
        public List<string> castNames = new List<string>();

        // inital video 
        public List<string> movieInTheatreURLs = new List<string>();
        public List<string> movieInTheatreIDs = new List<string>();
        public List<Poster> movieInTheatrePosters = new List<Poster>();

        public async Task OnGet()
        {
            // Grab best voting movie by page start up
            await Fetch.GrabPosterAsync("");
            Random randNum = new Random();
            for(int i = 0; i < 20; i++) {
                videoRandIndex = randNum.Next(20);
                await Fetch.GetMovieDetails(Program.movieInTheatresSet.results[videoRandIndex].id.ToString());
                if ((Program.videoSet.results.Count != 0)&&(Program.videoSet.results[0].key != null))
                    break;                     
            }
            for (int i = 0; i < Program.movieInTheatresSet.results.Count; i++)
            {
                await Fetch.GetMovieDetails(Program.movieInTheatresSet.results[i].id.ToString());
                if (Program.videoSet.results.Count != 0)
                {   // remove poster without video to play
                    movieInTheatrePosters.Add(Program.movieInTheatresSet.results[i]);
                    movieInTheatreURLs.Add(Program.movieInTheatresSet.results[i].poster_path);
                    movieInTheatreIDs.Add(Program.movieInTheatresSet.results[i].id.ToString());
                }
            }
        }

        public async Task OnPostGetPosters(string search)
        {
            if (Temp.searchTerm != null && search == null)
                search = Temp.searchTerm;

            Temp.searchTerm = search;
            if (search != null) 
            {
                await Fetch.GrabPosterAsync(search);
                foreach (Poster poster in Program.posterSet.results)
                {
                    posterURLs.Add(poster.poster_path);
                    overviews.Add(poster.overview);
                    movieIDs.Add(poster.id.ToString());
                }
            }
        } // OnPostGetPosters()

        public async Task OnPostDetails(string movieID)
        {
            await Fetch.GetMovieDetails(movieID);
            foreach (Video video in Program.videoSet.results)
            {
                videoNames.Add(video.name);
                videoKeys.Add(video.key);
            }
            movieOverview = Program.movie.overview;
            movieRuntime = Program.movie.runtime;
            movieTagline = Program.movie.tagline;
            movieRevenue = Program.movie.revenue;
            movieReleaseDate = Program.movie.release_date;

            for(int i = 0; i < Program.credits.cast.Count; i++)
            {
                castPics.Add(Program.credits.cast[i].profile_path);
                actorIDs.Add(Program.credits.cast[i].id);
                castNames.Add(Program.credits.cast[i].name);
            }

        } // OnPostDetails()

        public void OnPostCastDetails(string actorID)
        {
            Response.Redirect("./Actor?id=" + actorID);
        }

        public async Task OnPostMoviesInTheatresDetails(string movieInTheatreID)
        {
            for (int i = 0; i < Program.movieInTheatresSet.results.Count; i++)
            {
                await Fetch.GetMovieDetails(Program.movieInTheatresSet.results[i].id.ToString());
                if (Program.videoSet.results.Count != 0)
                {   // remove poster without video to play
                    movieInTheatrePosters.Add(Program.movieInTheatresSet.results[i]);
                    movieInTheatreURLs.Add(Program.movieInTheatresSet.results[i].poster_path);
                    movieInTheatreIDs.Add(Program.movieInTheatresSet.results[i].id.ToString());
                }
            }
            await Fetch.GetMovieDetails(movieInTheatreID);
        }
    } // class
} // namespace
