using AgendaServico.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaServico.InfraEstrutura.Configuracao
{
    public abstract class AgendaServiceConfiguracao<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : Entidade
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id)
                   .HasColumnName("Id")
                   .IsRequired();

            builder.Property(t => t.DataInclusao)
                   .HasColumnName("DataInclusao")
                   .IsRequired();

            builder.Property(t => t.DataAlteracao)
                   .HasColumnName("DataAlteracao");
        }
    }
}
