using AgendaServico.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaServico.InfraEstrutura.Context
{
    public interface IAgendaContext: IDisposable
    {
        DbSet<Usuario> Usuario { get; set; }
        DbSet<Contato> Contato { get; set; }
        DbSet<NumeroContato> NumeroContato { get; set; }
        DbSet<Categoria> Categoria { get; set; }

        int SaveChanges();
    }
}
