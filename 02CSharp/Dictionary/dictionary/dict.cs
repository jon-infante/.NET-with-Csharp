namespace dict;

public class DictionaryClass{
    
    //Creates a non-generic dictonary with string types
    private Dictionary<string, string> funDictionary;

    public DictionaryClass(){
        funDictionary = new Dictionary<string, string>();
    }

    public void Start(){
        bool exit = false;
        Console.WriteLine("Welcome to our presentation about dictionaries!");
        while(!exit){
            Console.WriteLine("\n[1] List the current dictionary available");
            Console.WriteLine("[2] Add a new dictionary key/value pair");
            Console.WriteLine("[3] Look up a key");
            Console.WriteLine("[4] Look up a value");
            Console.WriteLine("[x] Exit");
            string input = Console.ReadLine();

             switch(input){
                 case "1":
                    if (funDictionary.Count == 0){
                        Console.WriteLine("\nThe dictionary is empty!");
                    }
                    else{
                        Console.WriteLine("\nItems:");
                    foreach(var pair in funDictionary)
                        {
                            Console.WriteLine($"Item with the key '{pair.Key}' has the value: {pair.Value}");
                        }
                    }
                    break;
                 case "2":
                    Console.WriteLine("\nEnter a key name:");
                    string key = Console.ReadLine();
                    Console.WriteLine("Enter a value for your key:");
                    string value = Console.ReadLine();
                    funDictionary.Add(key, value);
                    break;
                case "3":
                    Console.WriteLine("Please enter a key to look up in the dictionary");
                    string newKey = Console.ReadLine();
                    if (funDictionary.ContainsKey(newKey) == true){
                        Console.WriteLine($"\nThe value of the key {newKey} is: {funDictionary[newKey]}");
                    }
                    else{
                        Console.WriteLine($"\nUnable to find a value for the key: {newKey}");
                    }
                    break;
                case "4":
                    Console.WriteLine("Please enter a value to look up in the dictionary");
                    string valueVar = Console.ReadLine();
                    int i = 0;
                    foreach (string keyObj in funDictionary.Keys){
                            if (funDictionary[keyObj] == valueVar)
                            {
                                if (i == 0){
                                    Console.WriteLine("\nKeys found:");
                                }
                                i += 1;
                                Console.WriteLine($"Found value under key: {keyObj}");
                            }
                         }
                    if (i == 0){
                        Console.Write($"Unable to find and keys with the value: {valueVar}\n");
                    }
                    break;
                case "x":
                    exit = true;
                    Console.WriteLine("\nGoodbye!\n");
                    break;
                default:
                    Console.WriteLine("\nI didn't understand that command");
                    break;
             }

        }

    }
}