namespace Aula_20
{
    public class cliente : Pedido
    {
        public string nome { get; set; }
        public string endereçoAtual { get; set; }
        
        public cliente(string _nome){
            _nome = this.cliente1;
        }
        
        public void MostrarDados( string restaurante1, string formatoDePagamento, int valorPedido, bool pedidoPago)
        {
            this.restaurante1 = restaurante1;
            this.formatoDePagamento = formatoDePagamento;
            this.valorPedido = valorPedido;
            this.pedidoPago = pedidoPago;

            System.Console.WriteLine($"O nome do restaurante é: {restaurante1}, \no formato de pagamento é: {formatoDePagamento}, \no valor de pedido é: {valorPedido}");
        }
        




    }
}