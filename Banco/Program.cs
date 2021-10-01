using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionarioCamila = new Funcionario("Camila", "123.123.123-45", "Caixa", 1200);
            Funcionario funcionarioThulio = new Funcionario("Thulio", "123.456.789-10", "Caixa", 1200);
            Funcionario funcionarioAna = new Funcionario("Ana", "321.654.987-01", "Caixa", 1200);


            ContaCorrente contaDoPedro = new ContaCorrente("Pedro", 1234, 789, 100, funcionarioCamila);
            ContaCorrente contaDoRogerio = new ContaCorrente("Rogerio", 1234, 790, 120, funcionarioAna);
            ContaCorrente contaDaSilvana = new ContaCorrente("Silvana", 1234, 791, 150, funcionarioThulio);

            Console.WriteLine("O total de contas criadas é de: " + ContaCorrente.TotalDeContasCriadas + " conta(s).");

            Console.WriteLine("Saldo inicial: Pedro R$" + contaDoPedro.Saldo + "; conta vendida pelo vendedor: " + funcionarioCamila.Nome + ", que recebeu uma comissão de: R$" + funcionarioCamila.Comissao);
            Console.WriteLine("Saldo inicial: Rogerio R$" + contaDoRogerio.Saldo + "; conta vendida pelo vendedor: " + funcionarioAna.Nome + ", que recebeu uma comissão de: R$" + funcionarioAna.Comissao);
            Console.WriteLine("Saldo inicial: Silvana R$" + contaDaSilvana.Saldo + "; conta vendida pelo vendedor: " + funcionarioThulio.Nome + ", que recebeu uma comissão de: R$" + funcionarioThulio.Comissao);

            contaDoPedro.Sacar(10);
            contaDoRogerio.Depositar(50);
            contaDaSilvana.Transferir(30, contaDoPedro);

            Console.WriteLine("Saldo após saque: Pedro R$" + contaDoPedro.Saldo);
            Console.WriteLine("Saldo após depósito: Rogerio R$" + contaDoRogerio.Saldo);
            Console.WriteLine("Saldo após transferência: Silvana R$" + contaDaSilvana.Saldo + "; Saldo após transferência: Pedro R$" + contaDoPedro.Saldo);
        }
    }
}