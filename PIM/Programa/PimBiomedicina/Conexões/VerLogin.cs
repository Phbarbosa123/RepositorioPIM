using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PimBiomedicina.Conexões
{
    class VerLogin
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexão con = new Conexão();
        SqlDataReader dr;

        public bool verificarLogin (String usuario, String senha)
        {
            cmd.CommandText = "select * from logins where usuario = @usuario and senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco de Dados";
            }
            return tem;
        }
        public String cadastrar(String usuario, String senha, String confSenha)
        {
            if (senha.Length < 4)
            {
                this.mensagem = "A senha precisa ter mais de 4 digitos!";
                return mensagem;
            }
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into logins values (@u,@s)";
                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.mensagem = "Cadastrado com sucesso";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com o Banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            return mensagem;
        }
    }
}
