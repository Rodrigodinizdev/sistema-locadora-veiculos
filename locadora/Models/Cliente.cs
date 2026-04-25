namespace Models;
public class Cliente
{
    public Cliente(Endereco endereco, string nome, string cpf, string email, string telefone)
    {
        Id = Guid.NewGuid();
        Endereco = endereco;
        Nome = nome;
        CPF = cpf;
        Email = email;
        Telefone = telefone;
    }
    public Guid Id { get; }
    public Endereco Endereco { get; }
    public string Nome { get; }
    public string CPF { get; }
    public string Email { get; }
    public string Telefone { get; }
}
