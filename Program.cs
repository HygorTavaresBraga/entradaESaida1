using System;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("PLACEHOLDERS (2 CASAS DECIMAIS)");

            String nome = "Alex Green";
            double valor1 = 3;
            double valor2 = 500.50;
            String cor = "Green";
            int valor3 = 21;
            double valor4 = 1.73;

            Console.WriteLine("Nome: {0}",nome);
            Console.WriteLine("Primeiro Valor: {0:F2}", valor1);
            Console.WriteLine("Segundo Valor: {0:F2}", valor2);
            Console.WriteLine("Cor: {0}", cor);
            Console.WriteLine("Terceiro Valor: {0:F2}", valor3);
            Console.WriteLine("Quarto Valor: {0:F2}", valor4);


            Console.WriteLine("----------------------------------");
            Console.WriteLine("CONCATENAÇÃO (3 CASAS DECIMAIS)");

            String produto = "Computadores";
            double valor = 2.500;
            int quantidade = 10;

            double total = valor * quantidade;

            Console.WriteLine(+quantidade+" "+produto+" de "+ valor.ToString("F3") +" é igual a: "+ total.ToString("F3"));

            Console.WriteLine("----------------------------------");
            Console.WriteLine("INTERPOLAÇÃO (2 CASAS DECIMAIS)");

            String aluno = "Hygor";
            double introducao = 10;
            double projetoESolucao = 8.6;
            double github = 10;

            double media = (introducao + projetoESolucao + github)/3;

            Console.WriteLine($"A média do aluno {aluno} é: {media.ToString("F2")}");
        }
    }
}
