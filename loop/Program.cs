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