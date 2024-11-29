// See https://aka.ms/new-console-template for more information
using _1_warm_up;

Console.WriteLine("Hello, World!");
/*
string[] testArray1 = { "A", "B", "C" };
string[] testArray2 = { "A" };
string[] testArray3 = { "a" };

FindMatches myMatches = new();

Console.WriteLine(myMatches.FindJustA(testArray1)); //false
Console.WriteLine(myMatches.FindJustA(testArray2)); //true
Console.WriteLine(myMatches.FindJustA(testArray3)); //false
*/
FindMatches myMatches = new();

string[] testArray1 = { "I", "love", "Northcoders" }; //match
string[] testArray2 = { "Northcoders", "is", "great" }; //no match
string[] testArray3 = { "I", "study", "with", "Northcoders" }; //no match

Console.WriteLine(myMatches.FindNorthCodersMatches(testArray1));
Console.WriteLine(myMatches.FindNorthCodersMatches(testArray2));
Console.WriteLine(myMatches.FindNorthCodersMatches(testArray3));

int[][] nestedArrays = [[3],[4,3],[5,2,7],[4,2,7],[3,5,4],[4,5,5,5,3]];
int[][] emptyNestedArray = [];

Console.WriteLine(myMatches.CountSpecificArrays(nestedArrays));
Console.WriteLine(myMatches.CountSpecificArrays(emptyNestedArray));
