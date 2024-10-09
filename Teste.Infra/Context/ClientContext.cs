
using Microsoft.EntityFrameworkCore;

using Teste.Infra.Entity;

namespace Teste.Infra.Context
{
    public partial class ClientContext : DbContext

    {
        public ClientContext(DbContextOptions<ClientContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Logradouro> Logradouro { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseLazyLoadingProxies();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

    }
}































//using Microsoft.EntityFrameworkCore;
//using Teste.Infra.Entity;

//namespace Teste.Infra.Context
//{
//    public partial class ClientContext : DbContext
//    {
//        // Construtor que aceita DbContextOptions para injeção de dependências
//        public ClientContext(DbContextOptions<ClientContext> options)
//            : base(options)
//        {
//        }

//        // DbSets representando as tabelas no banco de dados
//        public DbSet<Cliente> Clientes { get; set; }
//        public DbSet<Logradouro> Logradouros { get; set; }

//        // Configuração adicional para o contexto
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            // Apenas configure se as opções ainda não tiverem sido configuradas externamente
//            if (!optionsBuilder.IsConfigured)
//            {
//                // Configure seu provedor de banco de dados (exemplo: SQL Server)
//                optionsBuilder.UseSqlServer("Data Source=SQL5106.site4now.net;Initial Catalog=db_aae07c_edfdcorte0111;User Id=db_aae07c_edfdcorte0111_admin;Password=!098Cao10@");
//                // Caso você queira usar proxies para carregamento lazy
//                // optionsBuilder.UseLazyLoadingProxies();
//            }
//        }

//        // Configurações adicionais de mapeamento (relacionamentos, constraints, etc.)
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);

//            // Exemplo de configuração customizada usando Fluent API
//            modelBuilder.Entity<Cliente>(entity =>
//            {
//                entity.HasKey(e => e.Id);
//                entity.Property(e => e.Nome)
//                      .IsRequired()
//                      .HasMaxLength(200);
//            });

//            modelBuilder.Entity<Logradouro>(entity =>
//            {
//                entity.HasKey(e => e.Id);
//            });
//        }

//        // Sobrescrita de SaveChanges para possíveis customizações futuras
//        public override int SaveChanges()
//        {
//            // Exemplo de validação ou lógica antes de salvar
//            // Adicione aqui validações ou auditorias, se necessário

//            return base.SaveChanges();
//        }

//        // Método SaveChangesAsync para suporte a operações assíncronas
//        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
//        {
//            // Exemplo de lógica assíncrona antes de salvar (validação, auditoria, etc.)

//            return await base.SaveChangesAsync(cancellationToken);
//        }
//    }
//}



