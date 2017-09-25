namespace ch0401_Adapter.ChemicalDataBank
{
    //Adapter : 母接口
    class ChemicalDataBank
    {
        //获取临界点
        public float GetCriticlePoint(string compound, string point)
        {
            float temperature = 0.0F;
            if (point == "M")
            {
                switch (compound.ToLower())
                {
                    case "water":
                        temperature = 0.0F;
                        break;
                    case "benzene":
                        temperature = 5.5F;
                        break;
                    case "alcohol":
                        temperature = -114.1F;
                        break;
                }
            }
            else//沸点
            {
                switch (compound.ToLower())
                {
                    case "water":
                        temperature = 100.0F;
                        break;
                    case "benzene":
                        temperature = 80.1F;
                        break;
                    case "alcohol":
                        temperature = 78.3F;
                        break;
                }
            }
            return temperature;
        }

        //取得分子式
        public string GetMolecularStructure(string compound)
        {
            string structure = string.Empty;
            switch (compound.ToLower())
            {
                case "water":
                    structure = "H2O";
                    break;
                case "benzene":
                    structure = "C6H6";
                    break;
                case "alcohol":
                    structure = "C2H6O2";
                    break;
            }
            return structure;
        }

        //取得分子量
        public double GetMolecularWeight(string compound)
        {
            double weight = 0.0;
            switch (compound.ToLower())
            {
                case "water":
                    weight = 18.015;
                    break;
                case "benzene":
                    weight = 78.1134;
                    break;
                case "alcohol":
                    weight = 46.0688;
                    break;
            }
            return weight;
        }


    }
}
