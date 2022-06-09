namespace Banco
{
    class CartaoDeCredito
    {
        public long? numeroCartao;
        public string? dataValidade;

        public CartaoDeCredito(long numeroCartao){
            this.numeroCartao = numeroCartao;
        }
    }
}
