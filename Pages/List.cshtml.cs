using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic; 
using webapp.Data;
using webapp.Models;
using webapp.PostgresSQL;

namespace webapp.Pages
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly RestaurantDataInterface restaurantData;
        private readonly RestaurantContext restaurantContext;

        public ListModel(IConfiguration config, RestaurantDataInterface restaurantData, RestaurantContext restaurantContext) {
            this.config = config;
            this.restaurantData = restaurantData;
            this.restaurantContext = restaurantContext;
        }
    
        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants  { get; set; }

        public IEnumerable<Restaurant> DatabaseRestaurants  { get; set; }

        public void OnGet()
        {
            Message = this.config["Message"];
            Restaurants = this.restaurantData.GetAll();
            DatabaseRestaurants = this.restaurantContext.Restaurants;
        }
    }
}
