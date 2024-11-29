// See https://aka.ms/new-console-template for more information
using _1_warm_up;

Console.WriteLine("Hello, World!");

string[] testArray1 = { "A", "B", "C" };
string[] testArray2 = { "A" };
string[] testArray3 = { "a" };

FindMatches myMatches = new();

Console.WriteLine(myMatches.FindJustA(testArray1)); //false
Console.WriteLine(myMatches.FindJustA(testArray2)); //true
Console.WriteLine(myMatches.FindJustA(testArray3)); //false
