using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PimBiomedicina.Modelo
{
    public class Validacao : absPropriedades
    {
        public Validacao(string nomepaciente, string rg,
            string cpf,string datadenascimento, string idade,
            string telefone, string celular, string nomerua,
            string casa, string complemento, string bairro,
            string cidade, string estado, string obs) : base(nomepaciente, 
                rg, cpf, datadenascimento, idade, telefone, celular, 
                nomerua, casa, complemento, bairro, cidade, estado, obs)
        {
        }

        public override void Executar()
        {
            this.mensagem = "";
            try
            {
                this.numero_rg = Convert.ToInt32(this.rg);
                this.datanasc = Convert.ToDateTime(this.datadenascimento);
                this.numeroidade = Convert.ToInt32(this.idade);
                this.numerotel = Convert.ToInt32(this.telefone);
                this.numerocel = Convert.ToInt32(this.celular);
                this.numerocasa = Convert.ToInt32(this.casa);

                int[] mt1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] mt2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string TempCPF;
                string Digito;
                int soma;
                int resto;

                this.cpf = this.cpf.Trim();
                this.cpf = this.cpf.Replace(".", "").Replace("-", "");

                if (this.cpf.Length != 11)
                    this.mensagem = "CPF inválido";

                TempCPF = this.cpf.Substring(0, 9);
                soma = 0;
                for (int i = 0; i < 9; i++)
                    soma += int.Parse(TempCPF[i].ToString()) * mt1[i];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                Digito = resto.ToString();
                TempCPF = TempCPF + Digito;
                soma = 0;

                for (int i = 0; i < 10; i++)
                    soma += int.Parse(TempCPF[i].ToString()) * mt2[i];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                Digito = Digito + resto.ToString();

                this.numerocpf = Convert.ToInt32(this.cpf.EndsWith(Digito));
            }
            catch (Exception)
            {
                this.mensagem = "Algumas informações podem estar inválidas";
            }
        }
    }
}
