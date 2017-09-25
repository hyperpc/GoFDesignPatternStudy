using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0509_Strategy.ExportTable
{
    class ExportTabs : TableExporter
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
                        sb.Append("\t");
                    sb.Append(data[i][j]);
                }

                if (i < data.Length - 1)
                    sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
