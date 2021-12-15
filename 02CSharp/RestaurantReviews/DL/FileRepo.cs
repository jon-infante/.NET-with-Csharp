using System.Text.Json;

namespace DL;

//This class reads and writes to the file
public class FileRepo{

    public FileRepo(){
    }
    //make path from UI folder to file location
    private string filePath = "../DL/Restaurants.json";

    /// <summary>
    /// Gets all restaurants from a file
    /// </summary>
    /// <returns>List of all restaurants</returns>
    public List<Restaurant> GetAllRestaurants(){
        //returns all restaurants written in the file
        string jsonString = File.ReadAllText(filePath);
        List<Restaurant> jsonDeserialized = JsonSerializer.Deserialize<List<Restaurant>>(jsonString);
        return jsonDeserialized;
    }   


    /// <summary>
    /// Adds a restaurant to the file
    /// </summary>
    /// <param name="restToAdd">Restaurant object</param>
    public void AddRestaurant(Restaurant restToAdd){
        List<Restaurant> allRestaurants = GetAllRestaurants();
        allRestaurants.Add(restToAdd);
        string jsonString = JsonSerializer.Serialize(allRestaurants);
        File.WriteAllText(filePath, jsonString);

    }
    /// <summary>
    /// Adds a review to the file
    /// </summary>
    /// <param name="restaurantIndex">Using index to select the restaurant</param>
    /// <param name="reviewToAdd">Review object</param>
    public void AddReview(int restaurantIndex, Review reviewToAdd){
        List<Restaurant> allRestaurants = GetAllRestaurants();
        allRestaurants[restaurantIndex].Reviews.Add(reviewToAdd);
        string jsonString = JsonSerializer.Serialize(allRestaurants);
        File.WriteAllText(filePath, jsonString);       

    }
}