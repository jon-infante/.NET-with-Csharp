using DL;
using Models;

namespace BL;
public class RRBL
{
    /// <summary>
    /// Gets all restaurants
    /// </summary>
    /// <returns>list of all restaurants</returns>
    public List<Restaurant> GetAllRestaurants(){
        return StaticStorage.GetAllRestaurants();

    }
    /// <summary>
    /// Adds a new restaurant to the list
    /// </summary>
    /// <param name="restaurantToAdd">restaurant object to add</param>
    public void AddRestaurant(Restaurant restaurantToAdd){
        StaticStorage.AddRestaurant(restaurantToAdd);
    }
    /// <summary>
    /// Adds a new review to the restaurant on a particular index
    /// </summary>
    /// <param name="restaurantIndex">int, restaurant index </param>
    /// <param name="reviewToAdd">review to add</param>
    public void AddReview(int restaurantIndex, Review reviewToAdd){
        StaticStorage.AddReview(restaurantIndex, reviewToAdd);

    }
}
