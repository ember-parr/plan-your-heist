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

    public class FinalReport
    {
        public int TeamWins { get; set; }
        public int BankWins { get; set; }
        public string FinalMessage { get; set; }
        public FinalReport(int team, int bank)
        {
            TeamWins = team;
            BankWins = bank;
            if (TeamWins > BankWins)
            {
                FinalMessage = "Good Job, Enjoy Your Earnings";
            }
            else if (TeamWins < BankWins)
            {
                FinalMessage = "You're Going Downtown";
            }
            else
            {
                FinalMessage = "It's A Draw, Keep Training";
            }

        }

        public string DisplayMessage()
        {
        if (TeamWins < BankWins)
        {
            return $@"
                      ________________
                      \      __      /         __
                       \_____()_____/         /  )
                       '============`        /  /
                        #---\  /---#        /  /
                       (# @\| |/@  #)      /  /
                        \   (_)   /       /  /
                        |\ '---` /|      /  /
                _______/ \\_____// \____/ o_|
               /       \  /     \  /   / o_|
              / |           o|        / o_| \
             /  |  _____     |       / /   \ \
            /   |  |===|    o|      / /\    \ \
           |    |   \@/      |     / /  \    \ \
           |    |___________o|__/----)   \    \/
           |    '              ||  --)    \     |
           |___________________||  --)     \    /
                |           o|   ''''   |   \__/
                |            |          |

                  {FinalMessage}
            ";
        }


        else if (TeamWins > BankWins)
        {
            return $@"
            {FinalMessage}
                                       .
              . .                     -:-             .  .  .
            .'.:,'.        .  .  .     ' .           . \ | / .
            .'.;.`.       ._. ! ._.       \          .__\:/__.
             `,:.'         ._\!/_.                     .';`.      . ' .
             ,'             . ! .        ,.,      ..======..       .:.
            ,                 .         ._!_.     ||::: : | .        ',
     .====.,                  .           ;  .~.===: : : :|   ..===.
     |.::'||      .=====.,    ..=======.~,   |'|: :|::::::|   ||:::|=====|
  ___| :::|!__.,  |:::::|!_,   |: :: ::|'|l_l|'|:: |:;;:::|___!| ::|: : :|
 |: :|::: |:: |!__|; :: |: |===::: :: :|'||_||'| : |: :: :|: : |:: |:::::|
 |:::| _::|: :|:::|:===:|::|:::|:===F=:|'!/|\!'|::F|:====:|::_:|: :|::__:|
 !_[]![_]_!_[]![]_!_[__]![]![_]![_][I_]!//_:_\\![]I![_][_]!_[_]![]_!_[__]!
 -----------------------------------'---''''```---'-----------------------
 _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ |= _ _:_ _ =| _ _ _ _ _ _ _ _ _ _ _ _
                                     |=    :    =|                
_____________________________________L___________J________________________
--------------------------------------------------------------------------
            ";
        }


        else
        {
            return $@"
    {FinalMessage}
   _______
  /\ o o o\
 /o \ o o o\_______
<    >------>   o /|
 \ o/  o   /_____/o|
  \/______/     |oo|
        |   o   |o/
        |_______|/
            ";
        }
        }
    }
}