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
        public string actorName;
        public string birthday;
        public int age;
        public string placeOfBirth;
        public string knownFor;
        public string homepage;
        public List<string> imageUrls = new List<string>();
        public List<string> movieImages = new List<string>();
        public bool backToHome = false;

        public async Task OnGet(string id)
        {
            await Fetch.GetActorDetails(id);
            await Fetch.GetActorImages(id);

            for(int i = 0; i < Program.profileSet.profiles.Count; i++)
            {
                imageUrls.Add(Program.profileSet.profiles[i].file_path);
            }

            await Fetch.GetRelatedMovies(id);

            for(int i = 0; i < Program.relatedSet.results.Count; i++)
            {
                movieImages.Add(Program.relatedSet.results[i].poster_path);
            }

            biography = Program.actor.biography;
            actorName = Program.actor.name;
            birthday = Program.actor.birthday;
            // calculate age
            if (Program.actor.birthday != null) {
                age = DateTime.Now.Year - Convert.ToInt32(Program.actor.birthday.Substring(0, 4));
            }
            placeOfBirth = Program.actor.place_of_birth;
            knownFor = Program.actor.known_for_department;
            if(Program.actor.homepage != null)
                homepage = Program.actor.homepage.ToString();
        }
    }
}
