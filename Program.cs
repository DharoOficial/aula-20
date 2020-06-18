using System;

namespace Aula_20
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente Jakan = new cliente();
            retaurante Pedefava = new retaurante();

            System.Console.WriteLine("Bem vindo á o: "+Pedefava.nomeFantasia);
            System.Console.WriteLine("O que deseja?");
            Pedefava.fazerPedido();
            System.Console.WriteLine("Digite o formato de pagametno desejado(credito, debito, boleto)");
            Pedefava.formatoDePagamento = Console.ReadLine();
            System.Console.WriteLine("efetuando pagamento");
            System.Console.WriteLine("Digite o nome do Cliente, Formato ded Pagamento, valor do pedido, se o pedido ja foi pago, e o nome do restaurant.");
            Pedefava.MostrarDados(     
                Console.ReadLine(),
                Console.ReadLine(),
                int.Parse(Console.ReadLine()),
                bool.Parse(Console.ReadLine()),
                Console.ReadLine()
            );






 

        }   
    }
}
