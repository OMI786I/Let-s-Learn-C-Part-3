// code project 1
 
// * Your solution must include either a do-while or while iteration.
// * Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
/*
int userInput = 0;
Console.WriteLine("Please enter an  integer value between 5 and 10: ");
bool isValidInput = false;

while (!isValidInput)
{
    if (int.TryParse(Console.ReadLine(), out userInput) && userInput >= 5 && userInput <= 10)
    {
        isValidInput = true;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter an integer value between 5 and 10: ");
    }
}   

if (isValidInput)
{
    Console.WriteLine($"You entered: {userInput}");
}
*/

/*
string userInput;
Console.WriteLine("Enter your role name (Administrator, Manager, or User): ");
userInput = Console.ReadLine().ToLower().Trim();

while (userInput != "administrator" && userInput != "manager" && userInput != "user")
{

    Console.WriteLine("Invalid role name. Please enter a valid role name (Administrator, Manager, or User): ");
          userInput = Console.ReadLine().ToLower().Trim();
  
}

if (userInput == "administrator")
{
    Console.WriteLine("You have full access.");
}
else if (userInput == "manager")
{
    Console.WriteLine("You have limited access.");
}
else if (userInput == "user")
{
    Console.WriteLine("You have basic access.");
}


*/



string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };


for (int i = 0; i < myStrings.Length; i++)

{
    string currentString = myStrings[i];

    string[] sentences = currentString.Split(" .");

    foreach (string str in sentences)
    {
        Console.WriteLine(str);
    }
}