using RestaurantReviews;

//initialize list of restaurants
List<Restaurant> allRestaurants = new List<Restaurant>();
bool exit = false;

while(!exit){

    Console.WriteLine("Welcome to Restaurant Reviews");
    Console.WriteLine("Create a new restaurant");
    Console.WriteLine("Name: ");
    string name = Console.ReadLine();

    Console.WriteLine("City: ");
    string city = Console.ReadLine();

    Console.WriteLine("State: ");
    string state = Console.ReadLine();

    // Restaurant newResto = new Restaurant();

    // newResto.Name = name;
    // newResto.City = city;
    // newResto.State = state;

    //using object initializer
    Restaurant newResto = new Restaurant{
        Name = name,
        City = city,
        State = state
    };

    allRestaurants.Add(newResto);

    Console.WriteLine("Here is all your restaurants!");
    foreach(Restaurant resto in allRestaurants){
        Console.WriteLine($"Restaurant: {resto.Name} \nCity: {resto.City} \nState: {resto.State}");
    }
    Console.WriteLine("Would you like to add another one? [y/n]");
    string decision = Console.ReadLine();
    if (decision == "n"){
        exit = true;
    }

}


