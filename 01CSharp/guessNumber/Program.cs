//Create a number guessing game from 0 to 100 and have a user guess the correct number. Tell the user if
//they are over or under and how hot and cold they are on the guess. Also include the user's number of guesses.

Random r = new Random();
//Declaring a random number between 0 and 100
int randomNum = r.Next(0,100);

Console.WriteLine("Welcome to the number guessing game! Start by guessing a number between 0 and 100.");

string input = Console.ReadLine();
int userNum = int.Parse(input);

int counter = 1;
string temp = "";
string guessed = "";

while (true){
    while (userNum > 100 || userNum < 0){
        Console.WriteLine("Please enter a number between 0 and 100");
        input = Console.ReadLine();
        userNum = int.Parse(input);
    }
    int diff=(randomNum - userNum);
    if (diff < 0){
        diff = diff*-1;
    }
    //If the user has guessed the right number
    if (diff == 0){
        break;
    }
    else if (diff < 5){
        temp = "very hot!";
    }
    else if (diff < 10){
        temp = "hot!";
    }   
    else if (diff < 25){
        temp = "warm.";
    }   
    else if (diff < 50){
        temp = "cold";
    }
    else if (diff > 49){
        temp = "very cold";
    }
    //Write how close the guess is
    Console.WriteLine("You are " + temp);
    //Increase counter
    counter = counter + 1;
    if (userNum < randomNum){
        guessed = "lower";
    }
    else{
        guessed = "higher";
    }
    Console.WriteLine("Try again! The number you guessed is " +  guessed + " than the random number.");
    input = Console.ReadLine();
    userNum = int.Parse(input);
}
string checkCount = "guess";

if (counter != 1){
    checkCount = "guesses";
}

Console.WriteLine("You guessed the correct number " + randomNum + " Congratulations!");
Console.WriteLine("You guessed the number in " + counter + " " + checkCount);