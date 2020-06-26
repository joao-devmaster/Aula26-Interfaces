using System;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // primeiro devemos criar os produtos, para poder adicionar eles no carrinho
            
           Produto p1 = new Produto(1, "Iphone 6s", 1300f);
           Produto p2 = new Produto(2,"Iphone 6s Plus",1550f);
           Produto p3 = new Produto(3,"Iphone 7s",2000f);
           Produto p4 = new Produto(4,"Ïphone 7s plus",2200f);
           Produto p5 = new Produto(5,"Iphone 8s",2600f);
           Produto p6 = new Produto(6,"Iphone 8 Plus", 3000f);
           Produto p7 = new Produto(7, "Iphone Xs",4000f);
           Produto p8 = new Produto(8, "Iphone Xs Max",4500f);
           Produto p9 = new Produto(9,"Iphone 11",4900f);
           Produto p10 = new Produto(10,"Iphone 11 pro max",6200f);

           // agora vamos adicionar os produtos para o carrinho
           Carrinho carro = new Carrinho();
           carro.AdicionarProduto(p7);
           carro.AdicionarProduto(p8);
           carro.AdicionarProduto(p9);
           carro.AdicionarProduto(p9);
           carro.AdicionarProduto(p10);

           //para mostrar toda a lista - de acordo com os comandos do "carrinho"
           carro.MostrarProdutos();
           
           //mostrar total - de acordo com os comando do "carrinho"
           carro.MostrarTotal();
           

        }
    }
}
