using Enums;
namespace Models;

public class Locacao
{
    public Locacao(Cliente cliente, Veiculo veiculo, int quilometragemRodada, DateTime dataInicio, DateTime dataPrevistaDevolucao, decimal valorDiaria)
    {
        Id = Guid.NewGuid();
        Cliente = cliente;
        Veiculo = veiculo;
        QuilometragemRodada = quilometragemRodada;
        DataInicio = dataInicio;
        DataPrevistaDevolucao = dataPrevistaDevolucao;
        ValorDiaria = valorDiaria;
        Status = StatusLocacaoEnum.Inativa;
    
    }
    public Guid Id { get; }
    public Cliente Cliente { get; }
    public Veiculo Veiculo { get; }
    public int QuilometragemRodada { get; }
    public DateTime DataInicio { get; }
    public DateTime DataPrevistaDevolucao { get; }
    public DateTime? DataRealDevolucao { get; private set; }
    public decimal ValorDiaria { get; }
    public StatusLocacaoEnum Status { get; private set; }
}
