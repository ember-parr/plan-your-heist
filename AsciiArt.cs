using System;


namespace PlanYourHeist
{
    public class Report
    {
        public int ReportBank { get; set; }
        public int ReportTeam { get; set; }

        public int TrialRuns { get; set; }
        public int ThisRun { get; set; }

        public Report(int bank, int team, int totalRuns, int thisRun)
        {
            ReportBank = bank;
            ReportTeam = team;
            TrialRuns = totalRuns;
            ThisRun = thisRun;
        }

        public string PrintReport()
        {
            return $@"
/   /                                     /   /
| O |                                     | O |
|   |- - - - - - - - - - - - - - - - - - -|   |
| O |                                     | O |
|   |         H E I S T                   |   |
| O |              R E P O R T            | O |
|   |         [{ThisRun} of {TrialRuns}]                      
| O |                                     | O |
|   |  Bank Skill Level: {ReportBank}    
| O |                                     | O |
|   |                                     |   |
| O |  Team's Skill Level: {ReportTeam}                
|   |                                     |   |
| O |                                     | O |
|   |                                     |   |
| O |                                     | O |
|   |                                     |   |
| O |- - - - - - - - - - - - - - - - - - -| O |
|   |                                     |   |
            
            ";
        }
    }
}