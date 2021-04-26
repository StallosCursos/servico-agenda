using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AgendaServico.Modelo;

namespace AgendaServico.InfraEstrutura.Configuracao
{
    public class NumeroContatoConfiguracao: AgendaServiceConfiguracao<NumeroContato>
    {
        public override void Configure(EntityTypeBuilder<NumeroContato> builder)
        {
            base.Configure(builder);

            builder.ToTable("NumeroContato");

            builder.Property(t => t.IdContato).HasColumnName("IdContato").IsRequired();
            builder.Property(t => t.Numero).HasColumnName("Numero").HasMaxLength(9).IsRequired();
            builder.Property(t => t.Ddd).HasColumnName("Ddd").HasMaxLength(3).IsRequired();
            builder.Property(t => t.TipoContato).HasColumnName("TipoContato").HasConversion(
                v => v.ToString(),
                v => (TipoContato)Enum.Parse(typeof(TipoContato), v)
            ).IsUnicode();

            builder.HasOne(t => t.Contato).WithMany(t => t.NumerContato).HasForeignKey(t => t.IdContato);
            builder.HasOne(t => t.Categoria).WithMany(t => t.NumeroContatos).HasForeignKey(t => t.IdCategoria);
;        }
    }
}
