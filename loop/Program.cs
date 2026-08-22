/*
string [] names = ["John", "Jane", "Jack", "Jill"];

for (int i = 0; i<= names.Length-1; i++)
{
     if (names[i] == "John") names[i] = "Sammy";
    Console.WriteLine(names[i]);
}

Console.WriteLine(names);

Console.WriteLine("Reverse Order");

for (int i = names.Length-1; i >=0 ; i--)
{
    Console.WriteLine(names[i]);
}


//exercise: find whether the numbers are divisible by 3 or 5, if they are print them out. by fizz or buzz. if they are divisible by both print out fizzbuzz. if they are not divisible by either print out the number. to 100 numbers

for (int i = 1; i<=100; i++)
{
 if (i % 3 == 0)
 {
    Console.WriteLine($"{i} Fizz");
 }
 else if (i % 5 == 0)
 {
    Console.WriteLine($"{i} Buzz");
 }
 else if (i % 3 == 0 && i % 5 == 0)
 {
    Console.WriteLine($"{i} FizzBuzz");
 }
 else
 {
    Console.WriteLine(i);
 }
}
*/

//do while loop

/*
Random number = new();
int currentNumber;
do
{
    currentNumber = number.Next(1, 11);
    Console.WriteLine(currentNumber);
} while (currentNumber != 7);

*/
/*
Random random = new ();
int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

*/

/*
do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);


*/



// exercise: an rpg game. player starts with 10 health and mosnter also has 10 health. print the outcome below


int playerHealth = 10;
int monsterHealth = 10;
int round = 0;
Random random = new ();
int attacks;

while (playerHealth > 0 && monsterHealth > 0)
{   round ++;
    attacks = random.Next(1, 11);
if (round % 2 == 0)
    {

          playerHealth -= attacks;
        Console.WriteLine($"Round: {round}\n Monster attacks player for {attacks} damage. Player health is now {playerHealth}"); 
       
    }

    else
    {
         monsterHealth -= attacks;
    Console.WriteLine($"Round: {round}\nPlayer attacks monster for {attacks} damage. Monster health is now {monsterHealth}"); 
      
    }
   
}

if (playerHealth <= 0)
{
    Console.WriteLine("Monster wins!");
}
else
{
    Console.WriteLine("Player wins!");
}