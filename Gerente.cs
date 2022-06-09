namespace Banco
{
    class Gerente
    {
        public string? nome;
        public double salario;

        public Gerente(string nome, double salario) //Construtor da classe. Nome igual + parametros utilizados
        {
            this.nome = nome;
            this.salario = salario;
        }

        public double CalculaAumento()
        {
            return this.salario += this.salario * 0.1; //ao chamar o metodo sem passar uma taxa ele aplica esse metodo
        }

        public double CalculaAumento(double taxa)
        {
            return this.salario += this.salario * taxa; //ao chamar o metodo passando o parametro ele aplica o valor do parametro
        }
    }
}
