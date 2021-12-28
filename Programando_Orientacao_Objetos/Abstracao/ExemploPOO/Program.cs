using System;
using ExemploPOO.Models;
namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculadora c = new Calculadora();
            System.Console.WriteLine($"Resultado da primeira soma: {c.Somar(10,20)}");
            System.Console.WriteLine($"Resultado da segunda soma: {c.Somar(10,20,30)}");

            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Nota = 10;
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Leo";
            // p2.Idade = 20;
            // p2.Salario = 1000;

            // p2.Apresentar();


            // // Valores válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");  

            // // Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r.DefinirMedidas(0,0);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");  

            

            
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Miguel";
            // p1.Idade = 26;
            // p1.Apresentar();


        }
    }
}
