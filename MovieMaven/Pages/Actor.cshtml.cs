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
    public class ActorModel : PageModel
    {
        public string biography;
        public async Task OnGet(string id)
        {
            await Fetch.GetActorDetails(id);

            biography = Program.actor.biography;
        }
    }
}
