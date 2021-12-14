using Models;
namespace DL;
public static class StaticStorage
{
    private static List<Restaurant> _allRestaurants = new List<Restaurant>();

    /// <summary>
    /// Returns all restaurants from _allRestaurants List
    /// </summary>
    /// <returns>all restaurants in the list</returns>
    public static List<Restaurant> GetAllRestaurants(){
        return StaticStorage._allRestaurants;
    }
    /// <summary>
    /// adds a new restaurant to list list
    /// </summary>
    /// <param name="restaurantToAdd">new restaurant to add</param>
    public static void AddRestaurant(Restaurant restaurantToAdd){
        StaticStorage._allRestaurants.Add(restaurantToAdd);
    }
    /// <summary>
    /// Adds review object to the restaurant users have selected
    /// </summary>
    /// <param name="restaurantIndex">int, index of the restaurant in the list</param>
    /// <param name="reviewToAdd">Review object to add to the list</param>
    public static void AddReview(int restaurantIndex, Review reviewToAdd){
        StaticStorage._allRestaurants[restaurantIndex].Reviews.Add(reviewToAdd);
    }
}
