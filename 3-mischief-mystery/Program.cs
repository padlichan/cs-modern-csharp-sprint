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

List<string> mischiefReports = new ()
{
 "stolen remote batteries,9,it usually happens at lunchtime",
  "shoe laces replaced with 4cm shorter shoelaces,1, a dusty pine-scented substance was found on the outside",
  "plastic container lids replaced with slightly smaller lids,13,only containers on lower shelves were affected",
  "sugar replaced with salt in the communal tea making facilities,14,a receipt dated yesterday lunchtime listing a purchase of 12 bags of rock salt was found at the scene",
  "knives moved to the fork section whilst forks were moved to the spoons section and spoons to the knives section of the cutlery drawer,10,the knives were slightly wet as if someone had hurriedly washed something off of them",
  "biscuits in a large biscuit tin replaced with a sewing kit,1,this is a betrayal to all biscuits"
  };

Reports reports = new Reports();
var reportList = reports.WriteReport(mischiefReports);
Console.WriteLine(reportList.Count);

reports.ShowReport(reportList).ForEach(Console.WriteLine);


//There have been {int number} reports of {string happenings}. Witnesses note that it {extra notes}

