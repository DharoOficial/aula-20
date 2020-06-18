namespace Aula_20
{
    public class cliente : Pedido
    {
        public string nome { get; set; }
        public string endereçoAtual { get; set; }
        
        public void MostrarDados()
        {

        }
        public void MostrarDados( string restaurante, string formatoDePagamento, int valorPedido, bool pedidoPago)
        {
            this.restaurante = restaurante;
            this.formatoDePagamento = formatoDePagamento;
            this.valorPedido = valorPedido;
            this.pedidoPago = pedidoPago;

            System.Console.WriteLine($"O nome do restaurante é: {restaurante}, o formato de pagamento é: {formatoDePagamento}, o valor de pedido é: {valorPedido}");
        }
        




    }
}