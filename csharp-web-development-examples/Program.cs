double fahrenheit;
double celsius;
string input;

//These lines below are to show how Console.WriteLine can take parameters of various types,
// but can only be provided a single argument (so we have to concantenate alot)
int year = 2020;
Console.WriteLine("Hello" + "World");
Console.WriteLine("The year is " + year.ToString() + "\n");

//string userInput = Console.ReadLine();
//int year = int.Parse(userInput);

Console.WriteLine("Temperature in F:");
input = Console.ReadLine();
fahrenheit = double.Parse(input);

celsius = (fahrenheit - 32) * 5 / 9;
Console.WriteLine("The Temperature in C is: " + celsius + "\n");
Console.ReadLine();

/* Here is how to
  have multi-line
  comments. */

/*
 or
like
this
*/

