using System;
using System.Collections.Generic;
using System.Linq;

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
                    // Console.WriteLine($"{Player.GetTeamMember()}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: Be sure to use correct values when entering a team member. Please Try again.");
                };
            }
            Console.WriteLine($"Success! You have added {teamSize} players to your team:");
            // foreach (TeamMember member in TeamRoster)
            // {
            //     Console.WriteLine($"\t - {member.Name}  \t  Rank: {member.CourageFactor}  \t  Skill: {member.SkillLevel}");
            // }


            int BankDifficultyLevel = 100;
            int TeamDifficultyLevel = TeamRoster.Sum(player => player.SkillLevel);
            if (BankDifficultyLevel > TeamDifficultyLevel)
            {
                Console.WriteLine($"LOOSER! ");
                Console.WriteLine($"Your teams score: {TeamDifficultyLevel}");
                Console.WriteLine($"Bank's score: {BankDifficultyLevel}");
            }
            else
            {
                Console.WriteLine($"WINNER WINNER CHICKEN DINNER! ");
                Console.WriteLine($"Your teams score: {TeamDifficultyLevel}");
                Console.WriteLine($"Bank's score: {BankDifficultyLevel}");
            }

        }
    }
}
