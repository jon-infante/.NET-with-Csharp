namespace ToDo;

//This is a class, blueprints for object
//It is a data type
//It has members:
//1. Constructor - this special method creates the object wtih the class' shape
//2. Fields - They hold values that pertains to the class
//3. Properties - They're wrapper around fields to make it more secure
//4. Methods - They define behaviors of a class (Functions that belong to the class)
//classes have access modifiers -> something that controls access to that particular class [public]
//public = anyone can access
public class ToDoItem {
    //Empty Constructor
    public ToDoItem() {}

    //Automatic default property with getter and setter [Think of react native setState]
    public bool IsDone { get; set;}
    public string Note { get; set;}

    //Method
    //Does not take any arguments
    public void CompleteItem() {
        this.IsDone = true; 
    }
    //Method signature goes: Access Modifier, return type, method name, paramaters/arguments
    public string Print(){
        //String interpolation
        return $"Note: {this.Note}, Done: {this.IsDone} ";
    }

}
// //instantiating a new class
// ToDoItem newItem = new ToDoItem();