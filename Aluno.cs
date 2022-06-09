namespace TestePOO
{
    class Aluno
    {
        public string? nome;
        public int rg;
        public string? dataNascimento;

        public Turma turma;

        public Aluno(long rg)
        {
            this.rg = rg;
        }

        public Aluno(int rg)
        {
            this.rg = rg;
        }

        public void imprimeDados(long rg)
        {
            Console.WriteLine(
                $"Nome do Aluno: {nome}  |  RG: {rg}  |  Data Nascimento: {dataNascimento}"
            );
            Console.WriteLine(
                $"Turma: {turma.serie}{turma.sigla}  |  Periodo: {turma.periodo}  |  Tipo de ensino: {turma.tipoEnsino}"
            );
        }

        public void imprimeDados(int rg)
        {
            Console.WriteLine(
                $"Nome do Aluno: {nome}  |  RG: {rg}  |  Data Nascimento: {dataNascimento}"
            );
            Console.WriteLine(
                $"Turma: {turma.serie}{turma.sigla}  |  Periodo: {turma.periodo}  |  Tipo de ensino: {turma.tipoEnsino}"
            );
        }
    }
}
