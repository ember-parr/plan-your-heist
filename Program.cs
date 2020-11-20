using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Plan Your Heist!");
            Console.WriteLine("----------------------");
            TeamMemberSetup();

        }

        static void TeamMemberSetup()
        {
            try
            {
                Console.Write("Enter Your Name: ");
                string NameResponse = Console.ReadLine();
                Console.WriteLine(" ");
                Console.Write("What Is Your Skill Level? (enter a number 1-100): ");
                string SkillResponse = Console.ReadLine();
                Console.WriteLine(" ");
                Console.Write("How Couragous Are You? (enter a number 0.0-2.0): ");
                string CourageResponse = Console.ReadLine();
                Console.WriteLine(" ");

                TeamMember Player = new TeamMember(NameResponse, int.Parse(SkillResponse), double.Parse(CourageResponse));
                Console.WriteLine($"{Player.GetTeamMember()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Be sure to use correct values when entering a team member. Please Try again.");
            };
        }
    }
}
