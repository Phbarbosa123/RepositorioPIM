using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PimBiomedicina.Conexões
{
    public class Conexão
    {
        SqlConnection con = new SqlConnection();
        public Conexão()
        {
            con.ConnectionString = "server=MARIANE;user id=sa;password=1234;database=pim";

        }
        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            
        }
    }
}
