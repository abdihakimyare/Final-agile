using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Agile
{

    //this is connection class it connects to Sql server Database
    public class Myconnection
    {
        public SqlConnection con = new SqlConnection("Data Source=ADMIN-PC;Initial Catalog=dashboard;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public string qry;


    }
}
