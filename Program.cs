using System;

namespace ExercicioClasseProduto
{
    class Program
    {
        static void Main(string[] args)
        {


            /*Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());*/


            Produto p1 = new Produto("TV 4K", 900.00,10);

            p1.Nome = "T";
            
            Console.WriteLine(p1);

            Console.WriteLine("Set / Properties: " + p1.Nome);
            Console.WriteLine("Get / Properties: " + p1.Preco);
            Console.WriteLine("Get / Auto-Properties: " + p1.Quantidade);



            /*Produto p1 = new Produto(nome, preco, quantidade);


           

            //Adiciona no estoque
            Console.WriteLine("Atualizar estoque: \n");
            Console.WriteLine("Digite a quantidade adicional: ");
            int adicional = int.Parse(Console.ReadLine());

            p1.AdicionaProduto(adicional);

            Console.WriteLine(p1);


            //Remove do estoque
            Console.WriteLine("Atualizar estoque: \n");
            Console.WriteLine("Digite a quantidade removida: ");
            int removido = int.Parse(Console.ReadLine());

            p1.RemoverProdutos(removido);


            Console.WriteLine(p1);*/



        }
    }
}