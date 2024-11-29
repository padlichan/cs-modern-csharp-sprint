// See https://aka.ms/new-console-template for more information
using _3_mischief_mystery;

Console.WriteLine("Hello, World!");

ResidentData residentData = new();

residentData.NewFob = [..residentData.OldFobVisits, [1, 10, 4, 2, 1, 5], [1, 10, 8, 1, 3]];

int[] culpritFlatNumbers = residentData.NewFob.Where(x => x is [_, 10, >= 3, .., 1, < 5]).Select((x, i) => i).ToArray();

Console.WriteLine(culpritFlatNumbers.Length);

