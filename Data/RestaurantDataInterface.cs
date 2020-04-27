
using System.Collections.Generic; 
using System.Linq;
using webapp.Models;

namespace webapp.Data 
{
    public interface RestaurantDataInterface
    {
            IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : RestaurantDataInterface
    {

        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{id = 1, name="Pannuci's Pizza", location="Here", cuisine="Indian"},
                new Restaurant{ id = 2, name="Chicken Lickin", location="There", cuisine="Italian"}
            };
        }

        public IEnumerable<Restaurant> GetAll() 
        {
            return from r in restaurants orderby r.name select r;
        }
    }

}
