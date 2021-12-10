﻿using ToDo;
using System.Collections.Generic;

bool exit = false;
List<ToDoItem> toDoList = new List<ToDoItem>();

do {

    Console.WriteLine("\nWelcome to ToDo List");
    Console.WriteLine("What would you like to do today");
    Console.WriteLine("1: Create a new todo item");
    Console.WriteLine("2: View my list");
    Console.WriteLine("3: Complete an item");
    Console.WriteLine("x: Exit");
    string input = Console.ReadLine();

    // ToDoItem item = new ToDoItem();
    // item.IsDone = false;
    // item.Note = "Eat Lunch";

    // Console.WriteLine(item.Print());

    // item.CompleteItem();

    // Console.WriteLine(item.Print());

    switch(input){
        case "1":
            Console.WriteLine("Enter details for the new item.");
            Console.WriteLine("Item Note: ");
            string newNote = Console.ReadLine();
            
            ToDoItem newItem = new ToDoItem();
            newItem.IsDone = false;
            newItem.Note = newNote;

            toDoList.Add(newItem);
            Console.WriteLine("You created the following item: ");
            Console.WriteLine(newItem.Print());
        break;
        case "2":   
            foreach(ToDoItem item in toDoList)
            {
                Console.WriteLine(item.Print());
            }
        break;
        case "3": 
            Console.WriteLine("Completing an item");
        break;
        case "x":
            exit = true;
        break;
        default:
            Console.WriteLine("I'm not sure what that was");
        break;
}

}while (!exit);




