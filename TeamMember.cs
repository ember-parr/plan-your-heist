namespace PlanYourHeist
{
    public class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public string CourageFactor { get; set; }


        public TeamMember(string name, int skill, double courage)
        {
            Name = name;
            SkillLevel = skill;
            if (courage < 0.5)
            {
                CourageFactor = "Justin Beiber";
            }
            else if (courage < 1.0)
            {
                CourageFactor = "Betty White";
            }
            else if (courage < 1.5)
            {
                CourageFactor = "Dwayne 'The Rock' Johnson";
            }
            else
            {
                CourageFactor = "Chuck Noris";
            }
        }

        public string GetTeamMember()
        {
            return $@"
            New Team Member: {Name}
            -----------------------
            Skill Level: {SkillLevel}
            Courage Factor: {CourageFactor}
            -----------------------
            ";
        }
    }
}