using AppPOOInterface.Interface;

namespace AppPOOInterface.Model
{
    public abstract class PagamentoBase : IPagavel
    {
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }

        public PagamentoBase(decimal valor)
        {
            Valor = valor;
            Data = DateTime.Now;
        }

        public string EmitirRecibo()
        {
            return $"Recibo gerado em {Data:dd/MM/yyyy} no valor de R$ {Valor}";
        }

        public abstract string ProcessarPagamento();
    }
}
