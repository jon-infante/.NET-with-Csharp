Console.WriteLine("FizzBuzz");

// Console.WriteLine("Enter a positive integer");
//String variable from user input

// Console.WriteLine("You entered " + input);
//Converts string to integer

// Console.WriteLine("We parsed your input to " + number);
// while (number <= 0) {
//     Console.WriteLine("The number should be greater than 0");
//     Console.WriteLine("Enter a positive number");
//     input = Console.ReadLine();
//     number = int.Parse(input);
// }
string input = "";
int number = 0;
do {
    Console.WriteLine("Enter a positive number");
    input = Console.ReadLine();
    number = int.Parse(input);
    if (number <= 0){
        Console.WriteLine("The number should be greater than 0");
    }
} while(number <= 0);

// int counter = 1;
//Count up number and print in console
// while(counter <= number){
//     Console.WriteLine(counter);
//     counter++;
// }
for(int i=1; i<=number; i++){
    if (i % 15 == 0){
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0){
        Console.WriteLine("Fizz");
    }
    else if (i % 3 == 0){
        Console.WriteLine("Buzz");
    }
    else{
        Console.WriteLine(i);
    }

}