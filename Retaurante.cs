namespace Aula_20
{
    public class retaurante : Pedido
    {
        public string nomeFantasia = "Pé de Fava";
        public string endereço { get; set; }

        public void MostrarDados()
        {

        }
        public void MostrarDados(string cliente, string formatoDePagamento, int valorPedido, bool pedidoPago, string nomeFantasia)
        {
            this.nomeFantasia = nomeFantasia;
            this.cliente = cliente;
            this.formatoDePagamento = formatoDePagamento;
            this.valorPedido = valorPedido;
            this.pedidoPago = pedidoPago;

            System.Console.WriteLine($"O nome do reustarant é: {nomeFantasia}, o nome do cliente é: {cliente}, o formato de pagamento é: {formatoDePagamento}, o valor de pedido é: {valorPedido}.");
        }
    }
}