using System;
namespace Aula_20
{
    public class Pedido
    {
        string[] Itens = new string[5];



        public string cliente1 = "jackan";
        public string restaurante1 { get; set; }
        public string formatoDePagamento { get; set; }
        public bool pedidoPago { get; set; }
        public int valorPedido = 30;
        public retaurante restaurante { get; set; }
        public cliente cliente { get; set; }

       
        

        public void EntregarPedido()
        {
            if( pedidoPago == true ){
                System.Console.WriteLine("pedido entregue");
            }else{
                System.Console.WriteLine("Você previsa efetuar o pagamento para que o pedido seja entregue.");
            }
        }
        public string fazerPedido()
        {
            Itens[0] = Console.ReadLine();
            System.Console.WriteLine("caso nao deseje mais nada, aperte enter 4 vezes");
            Itens[1] = Console.ReadLine();
            System.Console.WriteLine("caso nao deseje mais nada, aperte enter 3 vezes");
            Itens[2] = Console.ReadLine();
            System.Console.WriteLine("caso nao deseje mais nada, aperte enter 2 vezes");
            Itens[3] = Console.ReadLine();
            System.Console.WriteLine("caso nao deseje mais nada, aperte enter 1 vezes");
            Itens[4] = Console.ReadLine();
            return "";
        }
    }
}