using System;
using POO_OBJETOSCOMOARGUMENTOS_EX1.classes;
using System.Collections.Generic;


namespace POO_OBJETOSCOMOARGUMENTOS_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();
            List<Produto> produto = new List<Produto>();
            Produto produtos = new Produto(); //Instaciar a lista para usar o Add , RemoveAll e etc.

            //Menu
            Funcoes menu = new Funcoes();

            int resposta1;

            

            
            do{
                menu.Menu();
                resposta1 = int.Parse(Console.ReadLine());

            switch(resposta1){
                case 1:
                    Console.WriteLine("Deseja adicionar quantos produtos?");
                    int resposta2 = int.Parse(Console.ReadLine());

                    int i = 0;
                    do{
                        Produto produtoAdicionar = new Produto();

                        Console.WriteLine($"Digite o nome do {i+1}° produto: ");
                        produtoAdicionar.Nome = Console.ReadLine();

                        Console.WriteLine($"Digite o valor do {i+1}° produto: ");
                        produtoAdicionar.Valor = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o código do {i+1}° produto: ");
                        produtoAdicionar.Codigo = int.Parse(Console.ReadLine()); 

                        i++;

                        produto.Add(new Produto(produtoAdicionar));
                        carrinho.AdicionarCarrinho(produtoAdicionar);


                     }while(i < resposta2);
                break;
                case 2:
                    Produto removerProduto = new Produto();

                    Console.WriteLine("Qual item deseja excluir? Digite o código do produto");
                    removerProduto.Codigo = int.Parse(Console.ReadLine());


                    
                    carrinho.RemoverProduto(removerProduto.Codigo);

                break;
                case 3:
                    Produto produtosAlterar = new Produto();

                    System.Console.WriteLine("Quantos produtos deseja alterar?");
                    int resposta4 = int.Parse(Console.ReadLine());

                    int i2 = 0;

                   do{
                        Console.WriteLine("Qual o código do produto do qual deseja alterar?");
                        produtosAlterar.Codigo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o nome do novo produto que deseja adicionar?");
                        produtosAlterar.Nome = Console.ReadLine();

                        Console.WriteLine("Qual o valor do novo produto?");
                        produtosAlterar.Valor = int.Parse(Console.ReadLine());


                        carrinho.AlterarItem(produtosAlterar.Codigo, produtosAlterar);
                        i2++;

                   } while(i2 < resposta4);
                break;
                case 4:
                    carrinho.ListarCarrinho();
                break;
                case 5:
                   
                break;
            }
        } while (resposta1 != 5);
        }
    }
}
