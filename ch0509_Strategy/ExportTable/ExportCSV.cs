using System.Text;

namespace ch0509_Strategy.ExportTable
{
    class ExportCSV : TableExporter
    {
        public override string GetExported(string[] data)
        {
            if (data == null)
                return string.Empty;
            StringBuilder sb = new StringBuilder(string.Empty);
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    if (j > 0)
                        sb.Append(",");
                    sb.Append(data[i][j]);
                }

                if (i < data.Length - 1)
                    sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
