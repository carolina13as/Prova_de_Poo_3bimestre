using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Poo_3Bimestre
{
    internal class Administrativo:Funcionario
    {

        public string Funcao { get; set; }


      
        
         public Administrativo(string funcao, string nome, int matricula, DateTime dataNas, string sexo, double salario) :
            base(nome, matricula, dataNas, sexo, salario)
        {
            Funcao = funcao;
        }
        public Administrativo() { }



        public override void SalarioTotal(double salario)
        {
            double rt = (salario + 150);

            double rt2 = ((salario * 15) / 100) + salario;


            double rt3 = rt + rt2;
            Console.WriteLine($"O valor do seu salario é: {rt3}\n");     
        
       
        }
    }
}
