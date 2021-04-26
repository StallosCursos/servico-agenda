namespace AgendaServico.Modelo
{
    public class NumeroContato: Entidade
    {
        public int IdContato { get; set; }
        public int IdCategoria { get; set; }
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public TipoContato TipoContato { get; set; }

        public Contato Contato { get; set; }
        public Categoria Categoria { get; set; }
    }
}