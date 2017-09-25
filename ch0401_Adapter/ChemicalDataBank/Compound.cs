using System;

namespace ch0401_Adapter.ChemicalDataBank
{
    class Compound : ChemicalCompound
    {
        private ChemicalDataBank bank;
        public Compound(string name) : base(name)
        {
            bank = new ChemicalDataBank();
            boilingpoint = bank.GetCriticlePoint(name, "B");
            meltingpoint = bank.GetCriticlePoint(name, "M");
            molecularweight = bank.GetMolecularWeight(name);
            molecularformula = bank.GetMolecularStructure(name);
        }

        public void Display()
        {
            Console.WriteLine("\n 化合物： {0} ------ ", name);
            Console.WriteLine(" 分子式： {0} ", MolecularFormula);
            Console.WriteLine(" 分子量： {0} ", MolecularWeight);
            Console.WriteLine(" 熔点： {0} ", MeltingPoint);
            Console.WriteLine(" 沸点： {0} ", BoilingPoint);
        }
    }
}
