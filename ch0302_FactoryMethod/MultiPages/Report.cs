namespace MultiPages
{
    class Report : Document
    {
        public override void CreatePages()
        {
            pages.Add(new IntroductionPage());
            pages.Add(new ResultsPage());
            pages.Add(new ConclusionPage());
            pages.Add(new SummaryPage());
            pages.Add(new BibliographyPage());
        }
    }
}
