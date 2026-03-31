using AppPOOInterface.Interface;

namespace AppPOOInterface.Model
{
    public class PagamentoBitcoin : PagamentoBase, IPagavel
    {
        public string CarteiraDestino { get; set; }

        public PagamentoBitcoin(decimal valor, string carteiraDestino)
            : base(valor)
        {
            CarteiraDestino = carteiraDestino;
        }

        public override string ProcessarPagamento()
        {
            return $"Processando pagamento via Bitcoin para a carteira {CarteiraDestino}";
        }
    }
}
