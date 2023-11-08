namespace WebApiEstudosMatheus.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public PessoaTipo PessoaTipo { get; set; }
        public int PessoaTipoId { get; set; }
    }
}
