public class Funcionario{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }
    public double Comissao { get; set; }

    public Funcionario(string funcionario_nome, string funcionario_cpf, string funcionario_cargo, double funcionario_salario)
    { 
        Nome = funcionario_nome;
        CPF = funcionario_cpf;
        Cargo = funcionario_cargo;
        Salario = funcionario_salario;
    }
}