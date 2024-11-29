// See https://aka.ms/new-console-template for more information
using _3_mischief_mystery;
using Suspects = System.Collections.Generic.List<_3_mischief_mystery.Suspect>;

Console.WriteLine("Hello, World!");

ResidentData residentData = new();

residentData.NewFob = [..residentData.OldFobVisits, [1, 10, 4, 2, 1, 5], [1, 10, 8, 1, 3]];

List<int> suspectFlatNumbers = residentData.NewFob.Where(x => x is [_, 10, >= 3, .., 1, < 5]).Select((x, i) => i).ToList();

Console.WriteLine(suspectFlatNumbers.Count);

//Get the Residents from ResidentData
//CHekc apartment num
// if same create suspect obj

Suspects suspects = new Suspects();

Suspects linqSuspects = residentData.Residents
	.Where(r => suspectFlatNumbers.Contains(r.apartmentNumber))
	.Select(r => new Suspect(r.apartmentNumber,r.name, r.age,r.heightInCm.ToString(), true)).ToList();


for (int i = 0; i < residentData.Residents.Length; i++)
{
	if (suspectFlatNumbers.Contains(residentData.Residents[i].apartmentNumber))
	{
		Resident r = residentData.Residents[i];
		Suspect sus = new(r.apartmentNumber, r.name, r.age, r.heightInCm.ToString(), true);
		suspects.Add(sus);
		
	}

}


Console.WriteLine(linqSuspects.Count);

