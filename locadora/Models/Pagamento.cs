using Enums;
namespace Models;

public class Pagamento
{
    public Pagamento(Locacao locacao, TipoPagamentoEnum tipoPagamento, decimal valor, DateTime dataPagamento, StatusPagamentoEnum statusPagamento)
    {
        Id = Guid.NewGuid();
        Locacao = locacao;
        TipoPagamento = tipoPagamento;
        Valor = valor;
        DataPagamento = dataPagamento;
        StatusPagamento = statusPagamento;
    }
    public Guid Id { get; }
    public Locacao Locacao { get; }
    public TipoPagamentoEnum TipoPagamento { get; private set; }
    public decimal Valor { get; private set; }
    public DateTime DataPagamento { get; private set; }
    public StatusPagamentoEnum StatusPagamento { get; private set; }

}
