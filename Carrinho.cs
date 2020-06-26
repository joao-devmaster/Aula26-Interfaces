
using System;
using System.Collections.Generic;

namespace Aula26Interfaces
{
    public class Carrinho : ICarrinho
    {

        public float ValorTotal { get; set; }
        List<Produto> carrinho = new List<Produto>();
        public void Alterar(int _codigo, Produto produto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).preco = produto.preco;
            
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
            
        }

        public void Deletar(Produto produto)
        {
         carrinho.Remove(produto);  
        }

        public void Listar()
        {
            foreach(Produto p in carrinho){

            System.Console.WriteLine($"R$ {p.preco} - {p.Nome} ");
            }

            
          
        }

        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }
        public void MostrarProdutos()
        {

            if(carrinho != null)
            {

                foreach(Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine($"R$ {p.preco.ToString("n2")} - {p.Nome} ");
                    Console.ResetColor();
                }
                
            }
        }

        public void MostrarTotal()
        {

            Console.ForegroundColor = ConsoleColor.Red;

            if(carrinho != null)
            {
                foreach(Produto p in carrinho)
                {
                    ValorTotal += p.preco;
                }
                System.Console.WriteLine($"Total do carrinho R$ {ValorTotal.ToString("n2")} ");

            }else{
                System.Console.WriteLine("Seu carrinho ainda esta vazio!");
            }
            Console.ResetColor();
        }


    }
}