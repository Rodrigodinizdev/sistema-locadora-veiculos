namespace Models;
public class Endereco
{
    public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado)
    {
        Id = Guid.NewGuid();
        CEP = cep;
        Logradouro = logradouro;
        Numero = numero;
        Complemento = complemento;
        Bairro = bairro;
        Cidade = cidade;
        Estado = estado;
    }
    public Guid Id { get; }
    public string CEP { get; }
    public string Logradouro { get; }
    public string Numero { get; }
    public string Complemento { get; }
    public string Bairro { get; }
    public string Cidade { get; }
    public string Estado { get; }
}
