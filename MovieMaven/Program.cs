using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MovieMaven.Models;

namespace MovieMaven
{
    public class Program
    {
        public static PosterSet posterSet;
        public static PosterSet movieInTheatresSet; // used for movies in theatre video data 
        public static VideoSet videoSet;
        public static Movie movie;
        public static Credits credits;
        public static Actor actor;
        public static string movieId;
        public static ProfileSet profileSet;
        public static RelatedSet relatedSet;
        public static string searchAgain;

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
