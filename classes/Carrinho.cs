using System;
using System.Collections.Generic;
using POO_OBJETOSCOMOARGUMENTOS_EX1.classes;

namespace POO_OBJETOSCOMOARGUMENTOS_EX1.classes
{
    public class Carrinho
    {
        public float ValorTotal{get;set;}

        List<Produto> carrinho = new List<Produto>();

        public Carrinho(){

        }

        public void AdicionarCarrinho(Produto produtos){
            carrinho.Add(produtos);
        }

        public void RemoverProduto(Produto produtos){
            carrinho.Remove(produtos);
            
        }

        public void ListarCarrinho(){
            if(carrinho != null){
                foreach(Produto p in carrinho){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"R$ {p.Valor} - {p.Nome}");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }

        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            if( carrinho != null)
            {
                foreach(Produto p in carrinho)
                {
                    ValorTotal += p.Valor;
                }
                Console.WriteLine($"Total do carrinho R$ {ValorTotal.ToString("n2")}");
            }else{
                Console.WriteLine($"Seu carrinho está vazio!");
            }
            Console.ResetColor();
        }


        public void AlterarItem(int codigo, Produto _novoProduto){
            carrinho.Find(x => x.Codigo == codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == codigo).Valor = _novoProduto.Valor;
        }
    }
}