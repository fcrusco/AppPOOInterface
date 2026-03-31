namespace AppPOOInterface.Model;

public class PagamentoCartao : PagamentoBase
{
    public string NumeroCartao { get; set; }

    public PagamentoCartao(decimal valor, string numeroCartao)
        : base(valor)
    {
        NumeroCartao = numeroCartao;
    }

    public override string ProcessarPagamento()
    {
        return $"Processando pagamento no cartão {NumeroCartao}";
    }
}
