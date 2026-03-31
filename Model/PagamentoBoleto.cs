namespace AppPOOInterface.Model;

public class PagamentoBoleto : PagamentoBase
{
    public string CodigoBarras { get; set; }

    public PagamentoBoleto(decimal valor, string codigoBarras)
        : base(valor)
    {
        CodigoBarras = codigoBarras;
    }

    public override string ProcessarPagamento()
    {
        return $"Processando pagamento via boleto: {CodigoBarras}";
    }
}
