namespace Aula26Interfaces
{
    public interface ICarrinho
    {
         // criamos uma espécie de "contrato" para deixar obrigatoria a 
         //implementação de todos os métodos e estruturas que herdarem dessa interface

         void Listar();
         void Cadastrar(Produto produto);
         void Alterar (int _codigo, Produto produto);
         void Deletar(Produto produto); 
    }
}