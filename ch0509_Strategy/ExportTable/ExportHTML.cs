using System.Text;

namespace ch0509_Strategy.ExportTable
{
    class ExportHTML : TableExporter
    {
        public override string GetExported(string[] data)
        {
            if (data == null)
                return string.Empty;
            StringBuilder sb = new StringBuilder("<table>\n");
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append("     <tr>\n");
                for (int j = 0; j < data[i].Length; j++)
                {
                    if (j > 0)
                        sb.AppendFormat("       <td>{0}</td>\n", data[i][j]);
                    sb.Append(data[i][j]);
                }
                
                sb.Append("     </tr>\n");
            }


            return sb.Append("</table>").ToString();
        }
    }
}
