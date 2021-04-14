using DescricaoDoEnum.Enuns;
using DescricaoDoEnum.Helpers;
using System;

namespace DescricaoDoEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descrição do Enum");
            Console.WriteLine(ETipoDePessoa.Fisica.GetEnumDescription());
            Console.WriteLine(ETipoDePessoa.Juridica.GetEnumDescription());
            Console.ReadLine();
        }
    }
}
