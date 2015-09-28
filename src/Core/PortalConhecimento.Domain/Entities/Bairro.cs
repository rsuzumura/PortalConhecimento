namespace PortalConhecimento.Domain.Entities
{
    public class Bairro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}