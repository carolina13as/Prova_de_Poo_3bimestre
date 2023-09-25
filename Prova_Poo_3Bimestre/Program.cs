
using System;
using Prova_Poo_3Bimestre;
namespace Prova_Poo_3Bimestre;


public class Program
{
    static void Main(string[] args)
    {
        List<Medico> listMedico = new List<Medico>();
        List<Administrativo> listadm = new List<Administrativo>();
        List<Funcionario> lisfun = new List<Funcionario>();
        Funcionario f = new Funcionario();
        Administrativo a = new Administrativo();
        Medico m = new Medico();



        try
        {
            while (true)
            {
            inicio:;
                Console.Write("Qual tipo de cadastro: \n1-Médico\n2-Administrativo\n3-Comum\n4-Sair\nQual: ");
                int op = Convert.ToInt32(Console.ReadLine());

                if (op == 1)
                {
                    Console.Write("Digite seu nome: ");
                    m.Nome = Console.ReadLine();
                    Console.Write("Digite sua matricula: ");
                    m.Matricula = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite sua data de nascimento: ");
                    m.DataNas = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Digite seu sexo: ");
                    m.Sexo = Console.ReadLine();
                    Console.Write("Digite seu codigo do CRM: ");
                    m.Crm = Console.ReadLine();
                    Console.Write("Digite sua Especialidade: ");
                    m.Especialidade = Console.ReadLine();
                    Console.Write("Digite seu salario: ");
                    m.Salario = Convert.ToDouble(Console.ReadLine());

                    m.SalarioTotal(m.Salario);

                    listMedico.Add(m);


                }
                else if (op == 2)
                {

                    Console.Write("Digite seu nome: ");
                    a.Nome = Console.ReadLine();
                    Console.Write("Digite sua matricula: ");
                    a.Matricula = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite sua data de nascimento: ");
                    a.DataNas = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Digite seu sexo: ");
                    a.Sexo = Console.ReadLine();
                    Console.Write("Digite sua função:");
                    a.Funcao = Console.ReadLine();
                    Console.Write("Digite seu salario: ");
                    a.Salario = Convert.ToDouble(Console.ReadLine());

                    a.SalarioTotal(a.Salario);

                    listadm.Add(a);

                }
                else if (op == 3)
                {
                    Console.Write("Digite seu nome: ");
                    f.Nome = Console.ReadLine();
                    Console.Write("Digite sua matricula: ");
                    f.Matricula = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite sua data de nascimento: ");
                    f.DataNas = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Digite seu sexo: ");
                    f.Sexo = Console.ReadLine();
                    Console.Write("Digite sua função:");
                    f.Salario = Convert.ToDouble(Console.ReadLine());


                    lisfun.Add(f);

                }
                else if (op == 4)
                {
                    
                    for(int i = 0; i<=listMedico.Count; i++)
                    {
                        Console.WriteLine($"Nome: {m.Nome}\nSalario: {m.Salario}");
                    }


                    for (int i = 0; i <= listadm.Count; i++)
                    {
                        Console.WriteLine($"Nome: {a.Nome}\nSalario: {a.Salario}");
                    }


                    for (int i = 0; i <= lisfun.Count; i++)
                    {
                        Console.WriteLine($"Nome: {f.Nome} \nSalario:{f.Salario}");
                    }



                    break;
                }

                else
                {
                    Console.WriteLine("Opção invalida, faça novamente!");
                    goto inicio;
                }

              


            }
        }catch(Exception ex)
        {
            Console.WriteLine($"Erro:{ex.Message}");
        }
       

    }
}




