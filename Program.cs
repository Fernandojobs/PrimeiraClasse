using System;

namespace PrimeiraClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            string nome;
            string marca;
            double preco;

            //limpar a tela de console
            Console.Clear();

            Console.WriteLine("Digite o codigo do produto");
            codigo = int.Parse (Console.ReadLine());

            Console.WriteLine("Digite o nome do produto");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do marca");
            marca = Console.ReadLine();

            Console.WriteLine("Digite o nome do preco");
            preco = double.Parse(Console.ReadLine());

            //Instância da classe CriarArquivo
            CriarArquivo ca = new CriarArquivo();
            ca.nomearquivo = "produtos";
            ca.extensao = "csv";
            ca.codigoproduto = codigo;
            ca.nomeproduto = nome;
            ca.marcaproduto = marca;
            ca.precoproduto = preco;
            Console.WriteLine(ca.salvar());
            

        }
    }
}
