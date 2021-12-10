using ToDo;

Console.WriteLine("Welcome to ToDo List");
Console.WriteLine("What would you like to do today");
Console.WriteLine("1. Create a new todo item");
Console.WriteLine("2. View my list");
Console.WriteLine("3. Complete an item");

ToDoItem item = new ToDoItem();
item.IsDone = false;
item.Note = "Eat Lunch";

Console.WriteLine(item.Print());

item.CompleteItem();

Console.WriteLine(item.Print());





