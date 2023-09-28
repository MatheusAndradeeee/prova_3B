using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3B
{
    internal class Funcionario
    {
        /*a) A empresa deseja controlar os funcionários, sendo que cada funcionário possui: nome, CPF,
matrícula, data de nascimento, sexo, salário.*/

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Matricula { get; set; }
        public string DataNasc { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string cpf, int matricula, string dataNasc, string sexo, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Matricula = matricula;
            this.DataNasc = dataNasc;
            this.Sexo = sexo;
            this.Salario = salario;
        }   
    }
}
