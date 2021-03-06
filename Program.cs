﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Plan Your Heist!");
            Console.WriteLine("----------------------");
            TeamSizeSetup();

        }

        static void TeamSizeSetup()
        {
            Console.Write("How many players are on your team? ");
            int TeamSize = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            
            TeamMemberSetup(TeamSize);
        }



        static void TeamMemberSetup(int teamSize)
        {
            List<TeamMember> TeamRoster = new List<TeamMember>();

            Console.Write("What is your crew's alias? ");
            string CrewAlias = Console.ReadLine();
            WelcomeToHeist welcome = new WelcomeToHeist(CrewAlias);
            Console.WriteLine($"{welcome.DisplayWelcomeMessage()}");

            for (int i = 0; i < teamSize; i++)
            {
                try
                {
                    Console.Write($"Enter Player {i + 1}'s Name: ");
                    string NameResponse = Console.ReadLine();
                    Console.Write("What Is Your Skill Level? (enter a number 1-100): ");
                    string SkillResponse = Console.ReadLine();
                    Console.Write("How Couragous Are You? (enter a number 0.0-2.0): ");
                    string CourageResponse = Console.ReadLine();
                    Console.WriteLine(" ");

                    TeamMember Player = new TeamMember(NameResponse, int.Parse(SkillResponse), double.Parse(CourageResponse));
                    TeamRoster.Add(Player);
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: Be sure to use correct values when entering a team member. Please Try again.");
                };
            }
            Console.WriteLine($"Success! You have added {teamSize} players to your team");
            Console.WriteLine(" ");
            Console.Write("What is the bank's anti-heist score? ");
            int BankScore = int.Parse(Console.ReadLine());

            Console.Write("How many trial runs would you like to do today? ");
            int TrialRuns = int.Parse(Console.ReadLine());

            int TeamWins = 0;
            int BankWins = 0;
            
            for (int j = 0; j < TrialRuns; j++)
            {
                Random r = new Random();
                int HeistLuckValue = r.Next(-10, 10);

                int BankDifficultyLevel = BankScore + HeistLuckValue;
                int TeamDifficultyLevel = TeamRoster.Sum(player => player.SkillLevel);
                TrialReport DifficultyReport = new TrialReport(BankDifficultyLevel, TeamDifficultyLevel, TrialRuns, j + 1);
                Console.WriteLine($"{DifficultyReport.PrintReport()}");

                if (BankDifficultyLevel > TeamDifficultyLevel)
                {
                    BankWins++;
                    Console.WriteLine($"FAIL! Your entire team is going to jail. buh-bye! ");
                }
                else if (BankDifficultyLevel < TeamDifficultyLevel)
                {
                    TeamWins++;
                    Console.WriteLine($"WINNER WINNER CHICKEN DINNER! Dolla Dolla Bills, Y'all! ");
                }
                else
                {
                    Console.WriteLine("CAT SCRATCH");
                }
                int milliseconds = 2000;
                Thread.Sleep(milliseconds);
            }
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine($"{CrewAlias} Successfully Completed {TeamWins} out of {TrialRuns} Trial Heists");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(" ");

            FinalReport endOfGame = new FinalReport(TeamWins, BankWins);
            Console.WriteLine($"{endOfGame.DisplayMessage()}");

        }
    }
}
