using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace webapp.Models
{
    public class Restaurant
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string cuisine { get; set; }
    }   
}
