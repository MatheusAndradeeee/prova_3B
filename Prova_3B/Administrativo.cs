using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*c) Existe também os funcionários do administrativo que possui todos os atributos de
funcionários além da função. Esse tipo de funcionário tem no seu salário um acréscimo de
R$ 250 de vale transporte e 17% a mais do salário de vale alimentação (sobre o salário sem
conta o vale transporte).*/
namespace Prova_3B
{
    internal class Administrativo: Funcionario
    {
        public string Funcao { get; set; }

        public Administrativo(string nome, string cpf, int matricula, string dataNasc, string sexo, double salario,string funcao) : base(nome, cpf, matricula, dataNasc, sexo, salario)
        {
            this.Funcao = funcao;
        }
        public double Sall(double salario)
        {
            return (salario + (salario * 0.17))+250;
        }
    }
}
