using RestaurantReviews;

//initialize list of restaurants
List<Restaurant> allRestaurants = new List<Restaurant>();
bool exit = false;

 Console.WriteLine("Welcome to Restaurant Reviews");

while(!exit){
    Console.WriteLine("What would you like to do today?");
    Console.WriteLine("1. Create a new restaurant");
    Console.WriteLine("2. Would you like to view the restaurants?");
    Console.WriteLine("3. Leave a review");
    Console.WriteLine("x. Exit");
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

            allRestaurants.Add(newResto);
            // Console.WriteLine("Would you like to add another one? [y/n]");
            // string decision = Console.ReadLine();
            // if (decision == "n"){
            //     exit = true;
            // }
            break;
        case "2":
            Console.WriteLine("Here is all your restaurants!");
            foreach(Restaurant resto in allRestaurants){
                Console.WriteLine($"Restaurant: {resto.Name} \nCity: {resto.City} \nState: {resto.State}");
            
                Console.WriteLine("=====Reviews=====");
                foreach(Review review in resto.Reviews){
                    Console.WriteLine($"Rating: {review.Rating} \t Note: {review.Note}");
                }
            }
            break;
        case "3":
                    Console.WriteLine("Select a restaurant to leave reviews for: ");
            for(int i = 0; i < allRestaurants.Count; i++){
                Console.WriteLine($"[{i}] Name: {allRestaurants[i].Name} \nCity: {allRestaurants[i].City} \nState: {allRestaurants[i].State}");
            }
                int selection = Int32.Parse(Console.ReadLine());
                Restaurant selectedRestaurant = allRestaurants[selection];
                 
                Console.WriteLine("Give a rating: ");
                int rating = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Give a review: ");
                string note = Console.ReadLine();

                Review newReview = new Review(rating, note);

                selectedRestaurant.Reviews.Add(newReview);
                Console.WriteLine("Your review has been successfully added!");
            break;
        case "x":
            exit = true;
            Console.Write("Goodbye!");
            break;
    }
}


