namespace _3_mischief_mystery
{   using Report = (string, int, string);

    public class Reports()
    {
        public List<Report> WriteReport(List<string> mischiefReports)
        {
            List<Report> reportList = mischiefReports.Select(x => new Report(x.Split(',')[0], int.Parse(x.Split(',')[1]), x.Split(',')[2])).ToList();
            return reportList;
        }
    }
}
