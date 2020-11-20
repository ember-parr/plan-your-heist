namespace PlanYourHeist
{
    public class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }


        public TeamMember(string name, int skill, double courage)
        {
            Name = name;
            SkillLevel = skill;
            CourageFactor = courage;
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