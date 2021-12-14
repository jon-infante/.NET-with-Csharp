namespace RestaurantReviews;

public class Review {
    

    public Review(){
        Console.WriteLine("Empty Constructor");
    }

     public Review(int rating) { 
        this.Rating = rating;
    }
    public Review(int rating, string note) { 
        this.Rating = rating;
        this.Note = note;
    }


    public int Rating { get; set; }
    
     public string Note { get; set; }

}