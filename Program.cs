namespace Banco
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Gerente gerente1 = new Gerente("Joao da silva", 5000.00);

            Console.WriteLine($"Salario com aumento padrão: {gerente1.CalculaAumento()}");
            Console.WriteLine($"Chama salario na classe: {gerente1.salario}");
            Console.WriteLine($"Salario com aumento com taxa: {gerente1.CalculaAumento(0.5)}");

            Agencia agenciaA = new Agencia(1234);
            CartaoDeCredito cartao1 = new CartaoDeCredito(123456798);

            Conta conta1 = new Conta(1234, agenciaA);
        }
    }
}
