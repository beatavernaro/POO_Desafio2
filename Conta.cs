namespace Banco
{
    class Conta
    {
        public Agencia agencia;
        public int numero;

        public Conta(int numero, Agencia agencia)
        {
            this.numero = numero;
            this.agencia = agencia;
        }
    }
}
