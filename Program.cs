using System;

namespace ConstrutorPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //instância sem argumentos
            Produto Sapato = new Produto();
            Sapato.Nome = "Vizzano";
            
            //instância com 1 argumento
            Produto chinelo = new Produto(45);
            chinelo.Codigo = 45;
            
            //Instância com todos os atributos como argumento
            Produto camisa = new Produto(34,"supreme",234,"azul");
            System.Console.WriteLine(camisa.Codigo);
            System.Console.WriteLine(camisa.Nome);
            System.Console.WriteLine(camisa.Estoque);
            System.Console.WriteLine(camisa.Descrição);
        }
    }
}
