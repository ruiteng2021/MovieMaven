using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieMaven.Pages
{
    public class AboutModel : PageModel
    {
        public List<string> posterURLs = new List<string>();
        public List<string> overviews = new List<string>();
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }

    }
}
