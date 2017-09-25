using System;
using System.Data;
using System.Data.SqlClient;

namespace ch0510_TemplateMethod.DataObject
{
    class CustomerDataObj : DataObject
    {
        private string connectString = "";
        private string cmdString="";
        private DataSet dataset;
        private SqlConnection dataConn;
        public override void Connect()
        {
            dataConn = new SqlConnection(connectString);
            dataConn.Open();
        }

        public override void Disconnect()
        {
            dataset.Dispose();
            dataConn.Close();
        }

        public override void Process()
        {
            DataTable table = dataset.Tables["Customers"];
            foreach (DataRow row in table.Rows)
                Console.WriteLine(row["CompanyName"]);
        }

        public override void Select()
        {
            cmdString = "select top 5 CompanyName from Customers";
            SqlDataAdapter adapter = new SqlDataAdapter(cmdString, dataConn);
            dataset = new DataSet();
            adapter.Fill(dataset, "Customers");
        }
    }
}
