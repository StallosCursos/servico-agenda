using AgendaServico.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaServico.InfraEstrutura.Configuracao
{
    public class ContatoEntittyConfiguration: AgendaServiceConfiguracao<Contato>
    {
        public override void Configure(EntityTypeBuilder<Contato> builder)
        {
            base.Configure(builder);

            builder.ToTable("Contato");

            builder.Property(t => t.IdUsuario).HasColumnName("IdUsuario").IsRequired();
            builder.Property(t => t.Nome).HasColumnName("Nome").HasMaxLength(150).IsRequired();
            builder.Property(t => t.Email).HasColumnName("Email").HasMaxLength(100).IsRequired();

            builder.HasOne(t => t.Usuario).WithMany(t => t.Contatos).HasForeignKey(t => t.IdUsuario);
            builder.HasMany(t => t.NumerContato).WithOne(t => t.Contato).HasForeignKey(t => t.IdContato);
        }
    }
}
