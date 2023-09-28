using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3B
{
    internal class Medico : Funcionario
    {
        public string CRM { get; set; }
        public double HoraExtra { get; set; }
        public string especialidade { get; set; }
      

      

        public Medico(string nome, string cpf, int matricula, string dataNasc, string sexo, double salario,string cRM, double horaExtra, string especialidade):base(nome,cpf,matricula,dataNasc,sexo,salario)
        {
            this.CRM = cRM;
            this.HoraExtra = horaExtra;
            this.especialidade = especialidade;
         
        }
        public double Sal(double salario)
        {
            return salario + (salario * 0.22);
        }
      
    }
}
