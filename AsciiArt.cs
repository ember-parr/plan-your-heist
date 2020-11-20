using System;


namespace PlanYourHeist
{
    public class Report
    {
        public int ReportBank { get; set; }
        public int ReportTeam { get; set; }

        public Report(int bank, int team)
        {
            ReportBank = bank;
            ReportTeam = team;
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
|   |                                     |   |
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