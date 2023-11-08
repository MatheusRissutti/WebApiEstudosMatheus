namespace WebApiEstudosMatheus.Entities
{
    public class ContaCorrente
    {
        public int Id { get; set; }
        public string NumeroConta { get; set; }
        public int Agencia { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
    }
}
