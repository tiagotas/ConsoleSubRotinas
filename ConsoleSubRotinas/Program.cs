using System;
using System.Collections.Generic;

namespace ConsoleSubRotinas
{
    class Program
    {
        static void Main(string[] args)
        {
            Saldacao();

            List<string> alunos = new List<string>();
            alunos.Add("Lucas");
            alunos.Add("Marcelo");
            alunos.Add("Thiago");
            alunos.Add("Tadeu");

            MostraNomes(alunos);

            getAlunoByPosition(alunos, 2);





            Console.WriteLine("Calculadora com Subrotinas");

            Console.WriteLine("Vamos Somar");


            Console.WriteLine("Digite o primero número");
            double digitado_n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            double digitado_n2 = Convert.ToDouble(Console.ReadLine());



            double retorno = Calculadora.somar(digitado_n1, digitado_n2);
            Console.WriteLine("O resultado da soma é {0}", retorno);


            Console.WriteLine(
                "O resultado da subtração é {0}",
                Calculadora.subtrair(digitado_n1, digitado_n2)
            );


            double retorno2 = Calculadora.multiplicar(4, 6.3);
            Console.WriteLine("O resultado da 1ª multiplicação é {0}", retorno2);


            double retorno3 = Calculadora.multiplicar(
                Calculadora.somar(digitado_n1, digitado_n2),
                2
            );
            Console.WriteLine("O resultado da 2ª multiplicação é {0}", retorno3);








            Console.ReadKey();
        }
    
        static void Saldacao()
        {
            Console.WriteLine("Bem-vindo ao estudo de subrotinas");
        }


        static void MostraNomes( List<string> lista_nomes )
        {
            foreach(string nome in lista_nomes)
            {
                Console.WriteLine("O nome da vez é {0}", nome);
            }
        }
        
        static void getAlunoByPosition( List<string> lista, int pos )
        {
            Console.WriteLine("O aluno da posição {0} é {1}", pos, lista[pos] );
        }
    }
}
