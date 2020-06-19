namespace Aula_20
{
    public class retaurante : Pedido
    {
        public string nomeFantasia = "Pé de Fava";
        public string endereço { get; set; }
        
       
        public void MostrarDados()
        {
            

            System.Console.WriteLine($"O nome do reustarant é: {nomeFantasia}, \no nome do cliente é: {cliente1}, \no formato de pagamento é: {formatoDePagamento}, \no valor de pedido é R$:  {valorPedido}");
        }
    }
}