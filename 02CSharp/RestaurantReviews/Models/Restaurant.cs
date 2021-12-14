namespace Models;

public class Restaurant {
    //In a restaurant, I want to store the name, city, and state.

    //This is a propety, a type member
    //Access modifier controls the visibility of type and type members
    //Public, Private, Internal, and Protected
    //By default, class member has private access modifier
    //Class by default are internal

    public Restaurant(){
        this.Reviews = new List<Review>();
    }
    public Restaurant(string name){
        this.Reviews = new List<Review>();
        this.Name = name;
    }

    public string Name { get; set; }

    // private string _name;

    // public string GetName(){
    //     return this._name;
    // }

    // public void SetName(string name){
    //     this._name=name;
    // }
    public string City { get; set; }

    public string State { get; set; }

    public List<Review> Reviews { get; }


}