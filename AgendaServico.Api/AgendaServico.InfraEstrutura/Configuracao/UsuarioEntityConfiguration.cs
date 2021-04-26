using AgendaServico.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaServico.InfraEstrutura.Configuracao
{
    public class UsuarioEntityConfiguration : AgendaServiceConfiguracao<Usuario>
    {
        public override void Configure(EntityTypeBuilder<Usuario> builder)
        {
            base.Configure(builder);

            builder.ToTable("Usuario");

            builder.Property(t => t.Nome).HasColumnName("Nome").HasMaxLength(50).IsRequired();
            builder.Property(t => t.NomeUsuario).HasColumnName("Usuario").HasMaxLength(25).IsRequired();
            builder.Property(t => t.Senha).HasColumnName("Senha").HasMaxLength(25).IsRequired();
            builder.Property(t => t.Email).HasColumnName("Email").HasMaxLength(100).IsRequired();

            builder.HasMany(t => t.Contatos).WithOne(t => t.Usuario).HasForeignKey(t => t.IdUsuario);
        }
    }
}
