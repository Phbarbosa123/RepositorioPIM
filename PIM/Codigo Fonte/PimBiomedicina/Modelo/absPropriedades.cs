using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PimBiomedicina.Modelo
{
    public abstract class absPropriedades
    {
        public String mensagem;
        public String nomeresp;
        public String nomeestagiario;
        public String raestagiario;
        public String senhaestagiario;
        public String nomepaciente;
        public String cpf;
        public Int32 numerocpf;
        public String dataatual;
        public DateTime datahoje;
        public String datadenascimento;
        public DateTime datanasc;
        public String idade;
        public Int32 numeroidade;
        public String telefone;
        public Int32 numerotel;
        public String celular;
        public Int32 numerocel;
        public String rg;
        public Int32 numero_rg;
        public String nomerua;
        public String casa;
        public Int32 numerocasa;
        public String complemento;
        public String bairro;
        public String cidade;
        public String estado;
        public String obs;
        public String racapaciente;

        protected absPropriedades
            (string nomepaciente, string rg, string cpf,
            string datadenascimento, string idade, string telefone, string celular,
            string nomerua, string casa, string complemento, string bairro,
            string cidade, string estado, string obs)
        {
            this.nomepaciente = nomepaciente;
            this.rg = rg;
            this.cpf = cpf;
            this.datadenascimento = datadenascimento;
            this.idade = idade;
            this.telefone = telefone;
            this.celular = celular;
            this.nomerua = nomerua;
            this.casa = casa;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.obs = obs;
        }

        public virtual void Executar()
        {

        }
    }
}
