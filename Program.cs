/*
int saleAmount = 1001;

int discount = saleAmount > 1000? 100 : 50;

Console.WriteLine($"Discount applied: {discount}");



int coin = new Random().Next(0,2);

string value = coin == 0? "Heads" : "Tails";

Console.WriteLine($"Coin flip result: {value}");



//exercise to show different messages accordingt o different levels

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    Console.WriteLine("You have admin privileges.");
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine("You have manager privileges.");
}
else
{
    Console.WriteLine("You have standard user privileges.");
}

*/

//understanding code blocks and scope

/*
bool flag = true;
int value = 10;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}


Console.WriteLine($"Outside the code block: {value}");


int value3 = 5;

if (value3 > 0)
{
    int value4 = 6;
    int sum = value3 + value4;
    Console.WriteLine($"Sum: {sum}");
}

*/
//CHECK whether a number is available in a given range
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");