namespace MultiPages
{
    class Resume:Document
    {
        public override void CreatePages()
        {
            pages.Add(new SkillsPage());
            pages.Add(new EducationPage());
            pages.Add(new ExperiencePage());
        }
    }
}
