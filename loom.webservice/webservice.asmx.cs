using System;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

using loom.time.models;

namespace loom.webservice
{
    public class webservice : System.Web.Services.WebService
    {
        /*private static DataSet SelectRows(DataSet dataset, string connectionString, string queryString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(queryString, connection);
                adapter.Fill(dataset);
                return dataset;
            }
        }
        */
        [WebMethod]
        public Stammdaten DBLookUpStammdaten (int id)
        {
            Stammdaten temp_dummy_result = new Stammdaten()
            {
                PersonalNr = 2506,
                Vorname = "Andreas",
                Name = "Hauber",
                Abteilung = "TO High Rise",
                AbteilungsNr = 4
            };

            return temp_dummy_result;
        }
    }
}
