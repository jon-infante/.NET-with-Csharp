using DL;
using Models;

namespace BL;
public class RRBL
{
    private FileRepo _dl;

    public RRBL() {
        _dl = new FileRepo();
    }
    /// <summary>
    /// Gets all restaurants
    /// </summary>
    /// <returns>list of all restaurants</returns>
    public List<Restaurant> GetAllRestaurants(){
        return _dl.GetAllRestaurants();

    }
    /// <summary>
    /// Adds a new restaurant to the list
    /// </summary>
    /// <param name="restaurantToAdd">restaurant object to add</param>
    public void AddRestaurant(Restaurant restaurantToAdd){
        _dl.AddRestaurant(restaurantToAdd);
    }
    /// <summary>
    /// Adds a new review to the restaurant on a particular index
    /// </summary>
    /// <param name="restaurantIndex">int, restaurant index </param>
    /// <param name="reviewToAdd">review to add</param>
    public void AddReview(int restaurantIndex, Review reviewToAdd){
        _dl.AddReview(restaurantIndex, reviewToAdd);

    }
}
