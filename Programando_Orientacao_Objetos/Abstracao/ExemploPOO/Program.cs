using System;
using System.IO;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.Collections.Generic;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novocaminhoArquivo = Path.Combine(caminho,"Pasta Teste 2","arquivo-teste-stream.txt");

            FileHelper helper = new FileHelper();

            var listaString = new List<string> {"linha 1","linha 2", "linha 3"};
            var listaStringContinuacao = new List<string> {"linha 4","linha 5", "linha 6"};

            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            // helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);

            // helper.MoverArquivo(caminhoArquivo, novocaminhoArquivo,false);

            // helper.LerArquivoStream(caminhoArquivo);

            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo,listaStringContinuacao);
    
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);

            // helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");

            // var caminho = "C:\\TrabalhandoComArquivos";
            // var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            // FileHelper helper = new FileHelper();
            // helper.ApagarDiretorio(caminhoPathCombine, true);

            // var caminho = "C:\\TrabalhandoComArquivos";
            // var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3", "subPastaTeste3");
            // FileHelper helper = new FileHelper();
            // helper.CriarDiretorio(Path.Combine(caminhoPathCombine));
            // System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);

            // var caminho = "C:\\TrabalhandoComArquivos";
            // FileHelper helper = new FileHelper();
            // helper.ListarArquivosDiretorios(caminho);


            // var caminho = "C:\\DIO\\dio-repositorio\\Programando_Orientacao_Objetos\\Abstracao\\ExemploPOO";
            // FileHelper helper = new FileHelper();
            // helper.ListarDiretorios(caminho);

            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10,20));

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();

            // Calculadora c = new Calculadora();
            // System.Console.WriteLine($"Resultado da primeira soma: {c.Somar(10,20)}");
            // System.Console.WriteLine($"Resultado da segunda soma: {c.Somar(10,20,30)}");

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
