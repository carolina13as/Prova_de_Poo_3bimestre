using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Poo_3Bimestre
{
    internal class Medico:Funcionario
    {

        public string Crm { get; set; }
        public double HoraExtra { get; set; }
        public string Especialidade { get; set; }

        public Medico(string crm, double horaExtra, string especialidade, string nome, int matricula, DateTime dataNas, string sexo, double salario):
            base(nome, matricula,dataNas, sexo, salario)
        {
            Crm = crm;
            HoraExtra = horaExtra;
            Especialidade = especialidade;
        }
        public Medico() { }

        public override void SalarioTotal(double salario)
        {
            double rt = ((salario * 20) / 100) + salario;
           

            Console.WriteLine($"O valor do seu salario é: {rt}\n");
         
        }
    }
}
