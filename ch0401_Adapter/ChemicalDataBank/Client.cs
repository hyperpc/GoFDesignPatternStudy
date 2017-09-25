namespace ch0401_Adapter.ChemicalDataBank
{
    public class Client
    {
        public static void Test()
        {
            Compound water = new Compound("Water");
            water.Display();

            Compound benzene = new Compound("Benzene");
            benzene.Display();

            Compound alcohol = new Compound("Alcohol");
            alcohol.Display();
        }
    }
}
