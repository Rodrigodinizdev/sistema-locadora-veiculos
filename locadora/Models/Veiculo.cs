using Enums;
namespace Models;

public class Veiculo
{
    public Veiculo(string nome, string marca, string categoria, string placa, string quilometragem)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Marca = marca;
        Categoria = categoria;
        Placa = placa;
        Quilometragem = quilometragem;
        Status = StatusVeiculoEnum.Disponível;
    }
    public Guid Id { get; }
    public string Nome { get; }
    public string Marca { get; }
    public string Categoria { get; }
    public string Placa { get; }
    public string Quilometragem { get; private set; }
    public StatusVeiculoEnum Status { get; private set; }
}
