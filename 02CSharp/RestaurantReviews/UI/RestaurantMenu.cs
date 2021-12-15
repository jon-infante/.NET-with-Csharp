using Models;
using BL;

namespace UI;

public class RestaurantMenu {

    private RRBL _bl;

    public RestaurantMenu(){
        _bl = new RRBL();
    }
   
    public void Start(){
        bool exit = false;
        while(!exit){
            Console.WriteLine("This is Restaurant Menu");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[1] Create a new restaurant: ");
            Console.WriteLine("[2] View all restaurants");
            Console.WriteLine("[x] Go back to main menu");
            string input = Console.ReadLine();
            switch (input){
                case "1":
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("City: ");
                    string city = Console.ReadLine();
                    Console.WriteLine("State: ");
                    string state = Console.ReadLine();

                    Restaurant newResto = new Restaurant{
                        Name = name,
                        City = city,
                        State = state
                    };

                    _bl.AddRestaurant(newResto);

                    break;
                case "2":
                        List<Restaurant> allRestaurants = _bl.GetAllRestaurants();
                        if(allRestaurants.Count == 0){
                            Console.WriteLine("No restaurants found :/");
                        }
                        else{
                        Console.WriteLine("Here is all your restaurants!");
                        foreach(Restaurant resto in _bl.GetAllRestaurants()){
                            Console.WriteLine($"Restaurant: {resto.Name} \nCity: {resto.City} \nState: {resto.State}");
                            if (resto.Reviews.Count > 0){

                            Console.WriteLine("=====Reviews=====");
                            foreach(Review review in resto.Reviews){
                                Console.WriteLine($"Rating: {review.Rating} \t Note: {review.Note}");
                            }
                            }
                            else{
                                Console.WriteLine("No Reviews :'(");
                            }
                        }
                        }
                     break;

                case "x":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("I'm not sure what that was.");
                    break;
                }
        }
    }
}