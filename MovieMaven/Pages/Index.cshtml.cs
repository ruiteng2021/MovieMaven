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
        public string searchTerm = Temp.searchTerm;
        // poster data
        public List<string> posterURLs = new List<string>();
        public List<string> overviews = new List<string>();
        public List<string> movieIDs = new List<string>();

        // video data
        public List<string> videoNames = new List<string>();
        public List<string> videoKeys = new List<string>();
        public int MAX_VIDS = 3; // limits the vids that show

        public void OnGet()
        {
            
        }

        public async Task OnPostGetPosters(string search)
        {
            if (Temp.searchTerm != null && search == null)
                search = Temp.searchTerm;

            await Fetch.GrabPosterAsync(search);
            foreach(Poster poster in Program.posterSet.results)
            {
                posterURLs.Add(poster.poster_path);
                overviews.Add(poster.overview);
                movieIDs.Add(poster.id.ToString());
            }
            Temp.searchTerm = search;
        } // OnPostGetPosters()

        public async Task OnPostDetails(string movieID)
        {
            await Fetch.GetMovieDetails(movieID);
            foreach (Video video in Program.videoSet.results)
            {
                videoNames.Add(video.name);
                videoKeys.Add(video.key);
            }
        } // OnPostDetails()
    } // class
} // namespace
