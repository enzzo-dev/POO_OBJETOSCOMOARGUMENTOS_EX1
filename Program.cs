using System;
using POO_OBJETOSCOMOARGUMENTOS_EX1.classes;
using System.Collections.Generic;


namespace POO_OBJETOSCOMOARGUMENTOS_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu
            Funcoes menu = new Funcoes();
            Carrinho carrinho = new Carrinho();
            List<Produto> produtos = new List<Produto>(); //Instaciar a lista para usar o Add , RemoveAll e etc.

            int resposta1;
            do{

            Console.WriteLine(menu.Menu());
            resposta1 = int.Parse(Console.ReadLine());

            switch(resposta1){
                case 1:
                    Console.WriteLine("Deseja adicionar quantos produtos?");
                    int resposta2 = int.Parse(Console.ReadLine());

                    int i = 0;
                    do{
                        Console.WriteLine("Digite o nome o produto: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Digite o valor do produto: ");
                        float valor = float.Parse(Console.ReadLine());

                        produtos.Add(new Produto(i+1,nome,valor));
                        carrinho.AdicionarCarrinho(produtos[i]);

                         i++;
                     }while(i < resposta2);
                break;
                case 2:
                    Console.WriteLine("Qual item deseja excluir?");
                    string resposta3 = Console.ReadLine();

                    produtos.RemoveAll(x => x.Nome == resposta3);
                    //carrinho.RemoverProduto();
                break;
                case 3:
                    System.Console.WriteLine("Quantos produtos deseja alterar?");
                    int resposta4 = int.Parse(Console.ReadLine());

                    int i2 = 0;
                   do{
                        Console.WriteLine("Qual o nome do produto do qual deseja alterar?");
                        string resposta5 = Console.ReadLine();

                        Console.WriteLine("Qual o nome do novo produto que deseja adicionar?");
                        string adicionar = Console.ReadLine();

                        Console.WriteLine("Qual o valor do novo produto?");
                        int valorNovo = int.Parse(Console.ReadLine());


                        //Falta adicionar para alterar o carrinho
                        i2++;

                   } while(i2 < resposta4);
                break;
                case 4:
                    foreach (Produto p in produtos)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{p.Nome} - R$ {p.Valor}");
                        Console.ResetColor();
                    }
                break;
                case 5:
                   
                break;
            }
        } while (resposta1 != 5);
        }
    }
}
