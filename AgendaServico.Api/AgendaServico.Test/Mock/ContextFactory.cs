using AgendaServico.InfraEstrutura.Context;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Data.Common;

namespace AgendaServico.Test.Mock
{
    public class ContextFactory : IDisposable
    {
        public readonly DbConnection Connection;
        private readonly DbContextOptions<AgendaContext> _options;

        public ContextFactory()
        {
            _options = CreateOptions();
            Connection = RelationalOptionsExtension.Extract(_options).Connection;

            Context.Database.EnsureCreated();
        }

        public AgendaContext Context
        {
            get => CreateContext();
        }

        private AgendaContext CreateContext(params object[] AdicioanlParameters)
        {
           return (AgendaContext)Activator.CreateInstance(typeof(AgendaContext), new object[] { _options });
        }


        private DbContextOptions<AgendaContext> CreateOptions() =>
           new DbContextOptionsBuilder<AgendaContext>().UseSqlite(CreateInMemoryDataBase())
                                                                 .EnableSensitiveDataLogging()
                                                                 .Options;

        private DbConnection CreateInMemoryDataBase()
        {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();
            return connection;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Connection.Close();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
