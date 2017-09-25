namespace ch0401_Adapter.ChemicalDataBank
{
    //目标抽象类
    class ChemicalCompound
    {
        protected string name;
        protected float boilingpoint;
        protected float meltingpoint;
        protected double molecularweight;
        protected string molecularformula;

        public ChemicalCompound(string name)
        {
            this.name = name;
        }

        public float BoilingPoint
        {
            get { return boilingpoint; }
        }
        public float MeltingPoint
        {
            get { return meltingpoint; }
        }
        public double MolecularWeight
        {
            get { return molecularweight; }
        }
        public string MolecularFormula
        {
            get { return molecularformula; }
        }
    }
}
