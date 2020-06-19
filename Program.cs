using System;

namespace Aula_20
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente Jakan = new cliente("jackan");
            retaurante Pedefava = new retaurante();

            System.Console.WriteLine("Bem vindo á o: "+Pedefava.nomeFantasia);
            System.Console.WriteLine("O que deseja?");
            Pedefava.fazerPedido();
            System.Console.WriteLine("Digite o formato de pagametno desejado(credito, debito, boleto)");
            Pedefava.formatoDePagamento = Console.ReadLine();
            System.Console.WriteLine("efetuando pagamento");
           
            Pedefava.MostrarDados
            (     
               
            );





 
 

        }   
    }
}
