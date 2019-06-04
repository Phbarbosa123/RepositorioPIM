using PimBiomedicina.Conexões;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PimBiomedicina.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem;

        public bool entrar(String usuario, String senha)
        {
            VerLogin VeriLogin = new VerLogin();
            tem = VeriLogin.verificarLogin(usuario, senha);
            if (!VeriLogin.mensagem.Equals("")){
                this.mensagem = VeriLogin.mensagem;
            }
            return tem;
        }
    }
}
