using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_01
{
    class Program3
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Infome a idade  ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tipo de Habilitação");
            char hb = char.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tempo de carteira ");
            double temp = double.Parse(Console.ReadLine());
            if (idade >= 21 && hb == 'c' && temp >= 1)
            {
                Console.WriteLine("Carteira Aprovada ");
            }
            else if (idade >= 21 && hb == 'b' && temp >= 2)
            {
                Console.WriteLine("Carteira Aprovada");
            }
            else
            {
                Console.WriteLine("Carteira Negada");
            }

            Console.ReadKey();
        }


    }
}
//Escreva um programa que leia a idade de uma pessoa, o tipo de habilitação que ela possui e o tempo
//que ela possui carteira de habilitação. Verifique e informe se a pessoa possui os requisitos necessários para
//tirar uma carteira de habilitação do tipo D. Caso ela não possua os requisitos, indique em uma mensagem
//o motivo pelo qual ela não possui permissão