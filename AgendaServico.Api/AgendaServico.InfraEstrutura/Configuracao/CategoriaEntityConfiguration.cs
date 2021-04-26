using AgendaServico.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaServico.InfraEstrutura.Configuracao
{
    public class CategoriaEntityConfiguration: AgendaServiceConfiguracao<Categoria>
    {
        public override void Configure(EntityTypeBuilder<Categoria> builder)
        {
            base.Configure(builder);

            builder.ToTable("Categoria");

            builder.Property(t => t.Nome).HasColumnName("Nome").HasMaxLength(150).IsRequired();

            builder.HasMany(t => t.NumeroContatos).WithOne(t => t.Categoria).HasForeignKey(t => t.IdCategoria);
        }
    }
}
