using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Poo_3Bimestre
{
    internal class Funcionario
    {      
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public DateTime DataNas { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, int matricula, DateTime dataNas, string sexo, double salario)
        {
            Nome = nome;
            Matricula = matricula;
            DataNas = dataNas;
            Sexo = sexo;
            Salario = salario;
        }
        public Funcionario()
        { }
        public virtual void SalarioTotal(double salario)
        {
            Console.WriteLine($"Seu salario é: {salario}");
        }
    }
}
