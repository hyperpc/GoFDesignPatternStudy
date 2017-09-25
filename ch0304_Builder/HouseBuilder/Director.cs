namespace HouseBuilder
{
    public class Director
    {
        public IHouse BuildHouse(bool mblnBackyard)
        {
            if (mblnBackyard)
                return new SingleFamilyHome();

            return new Apartment();
        }
    }
}
