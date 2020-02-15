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
        public List<string> posterURLs = new List<string>();
        public List<string> overviews = new List<string>();
        public List<string> ids = new List<string>();
        public string movieID = "33";

        public void OnGet()
        { }

        public async Task OnPostGetPosters(string search)
        {
            await Fetch.GrabPosterAsync(search);
            foreach(Poster poster in Program.posterSet.results)
            {
                posterURLs.Add(poster.poster_path);
                overviews.Add(poster.overview);
                ids.Add(poster.id.ToString());
            }
        }

        public async Task OnPostDetails(string movieID)
        {
            await Fetch.GetMovieDetails(movieID);
        }
    }
}
