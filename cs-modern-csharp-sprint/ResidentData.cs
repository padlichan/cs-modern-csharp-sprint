global using Resident = (int apartmentNo, string name, int age, int heightInCm);
namespace mischief_mystery
{
    public class ResidentData
    {
        public int[][]? NewFob { get; set; }
        public int[][] OldFobVisits =
        [
            [11, 13, 1, 0],
            [10, 10, 3, 5, 1, 4], //yes
            [5, 5, 11, 2],
            [1, 10, 2, 1, 4],
            [0, 10, 4, 2, 2, 1, 2], //yes
            [11, 10, 9, 3, 1, 4], //yes
            [2, 3, 11, 0, 1, 5],
            [9, 10, 2, 2, 0],
            [10, 4, 1, 4],
            [2, 10, 8, 3, 1, 1], //yes
            [0, 1, 4, 9],
            [10, 10, 10, 10, 1, 2], //yes
            [1, 10, 3, 1, 4], //yes
            [1, 0, 5, 9],
            [3, 10, 3, 3, 1, 3], //yes
        ];
        public Resident[] Residents = [
            (0, "Alex", 19, 169),
            (1, "Bea", 50, 176),
            (2, "Maureen", 44, 170),
            (3, "Peter", 44, 190),
            (4, "Larry", 42,172),
            (5, "Aliyah", 35, 161),
            (6, "Caoimhe", 24, 179),
            (7, "Mag", 55, 154),
            (8, "Pat", 56, 180),
            (9, "Jeff", 62, 180),
            (10, "Blessing", 37, 163 ),
            (11, "Robin", 22, 170),
            (12, "Mo", 37, 179),
            (13, "Sarah", 28, 159),
            (14, "Aurora", 29, 180),
            (15, "Cyrus", 30, 174),
            (16, "Theresa", 74, 151)
            ];
    }


}
