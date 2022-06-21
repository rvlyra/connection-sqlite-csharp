using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
/*
    não esquecer de instalar as libs:
    dotnet add package SQLite --version 3.13.0
    dotnet add package Microsoft.Data.Sqlite.Core
*/

namespace AppAny 
{
    class Conexao
    {
        public SqlConnection conn = new SqlConnection("Data Source=conntest.db");

        public void up()
        {
            conn.Open();
        }
        public void down()
        {
            conn.Close();
        }
    }
}