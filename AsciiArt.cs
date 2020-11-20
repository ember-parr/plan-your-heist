using System;


namespace PlanYourHeist
{
    public class TrialReport
    {
        public int ReportBank { get; set; }
        public int ReportTeam { get; set; }

        public int TrialRuns { get; set; }
        public int ThisRun { get; set; }

        public TrialReport(int bank, int team, int totalRuns, int thisRun)
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
|   |         T R I A L   R U N           |   |
| O |              R E P O R T            | O |
|   |                   [{ThisRun} of {TrialRuns}]                      
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
|   |                                     |   |";
        }
    }


    public class WelcomeToHeist
    {
        public string TeamName { get; set; }

        public WelcomeToHeist(string teamName)
        {
            TeamName = teamName;
        }

        public string DisplayWelcomeMessage()
        {
            return $@"
It's up to YOU to plan this heist properly.
                        .-""""-.
                       / j      \
                      :.d;       ;
                      $$P        :
           .m._       $$         :
          dSMMSSSss.__$$b.    __ :
         :MMSMMSSSMMMSS$$$b  $$P ;
         SMMMSMMSMMMSSS$$$$     :b
        dSMMMSMMMMMMSSMM$$$b.dP SSb.
       dSMMMMMMMMMMSSMMPT$$=-. /TSSSS.
      :SMMMSMMMMMMMSMMP  `$b_.'  MMMMSS.
      SMMMMMSMMMMMMMMM \  .'\    :SMMMSSS.
     dSMSSMMMSMMMMMMMM  \/\_/; .'SSMMMMSSSm
    dSMMMMSMMSMMMMMMMM    :.;'' :SSMMMMSSMM;
  .MMSSSSSMSSMMMMMMMM;    :.;   MMSMMMMSMMM;
 dMSSMMSSSSSSSMMMMMMM;    ;.;   MMMMMMMSMMM
:MMMSSSSMMMSSP^TMMMMM     ;.;   MMMMMMMMMMM
MMMSMMMMSSSSP   `MMMM     ;.;   :MMMMMMMMM;
'TMMMMMMMMMM      TM;    :`.:    MMMMMMMMM;
   )MMMMMMM;     _/\\    :`.:    :MMMMMMMM
  d$SS$$$MMMb.  |._\\\   :`.:     MMMMMMMM
  T$$S$$$$$$$$$$m;O\\\\'-;`.:_.-  MMMMMMM;
 :$$$$$$$$$$$$$$$b_l./\\ ;`.:    mMMSSMMM;
 :$$$$$$$$$$$$$$$$$$$./\\;`.:  .$$MSMMMMMM
  $$$$$$$$$$$$$$$$$$$$. \\`.:.$$$$SMSSSMMM;
  $$$$$$$$$$$$$$$$$$$$$. \\.:$$$$$SSMMMMMMM
  :$$$$$$$$$$$$$$$$$$$$$.//.:$$$$SSSSSSSMM;
  :$$$$$$$$$$$$$$$$$$$$$$.`.:$$SSSSSSSMMMP
   $$$$$$$$$;'^$J '^$$$$;.`.$$P  `SSSMMMM
   :$$$$$$$$$       :$$$;.`.P'..   TMMM$$b
   :$$$$$$$$$;      $$$$;.`/ c^'   d$$$$$S;
   $$$$$S$$$$;      '^^^:_d$g:___.$$$$$$SSS
   $$$$SS$$$$;            $$$$$$$$$$$$$$SSS;
  :$$$SSSS$$$$            : $$$$$$$$$$$$$SSS
  :$P'TSSSS$$$            ; $$$$$$$$$$$$$SSS;
  j    `SSSSS$           :  :$$$$$$$$$$$$$SS$
 :       '^S^'           :   $$$$$$$$$$$$$S$;
 ;.____.-;'               '--^$$$$$$$$$$$$$P
 '-....-'  Ready              ''^^T$$$$P' 
               {TeamName}?
            ";
        }
    }
}