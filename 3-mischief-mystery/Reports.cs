namespace _3_mischief_mystery
{   using Report = (string, int, string);

    public class Reports()
    {
        public List<Report> WriteReport(List<string> mischiefReports)
        {
            List<Report> reportList = mischiefReports.Select(x => new Report(x.Split(',')[0], int.Parse(x.Split(',')[1]), x.Split(',')[2])).ToList();
            return reportList;
        }

        public List<string> ShowReport(List<Report> reports)
        {
     
            List<string> outputs = new List<string>();
        
            for (int i = 0; i < reports.Count; i++)
            {
                string hasOrHave = reports[i].Item2 switch
                {
                    <= 1 => "has",
                    _ => "have"
                };
                string report = reports[i].Item2 switch
                {
                    <= 1 => "report",
                    _ => "reports"
                };
              string answer = $"There {hasOrHave} been {reports[i].Item2} {report} of {reports[i].Item1}. Witnesses note that {reports[i].Item3}";

                outputs.Add(answer);
            }
            return outputs;
        }

    }
}
