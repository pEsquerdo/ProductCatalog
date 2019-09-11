using ProductCatalog.Model;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProductCatalog.DAO
{
    // DbContext - Classe do EntityFramework que concentra o acesso ao Banco de Dados
    public class DataContext : DbContext
    {
        //Crio um construtor para o DataContext que passa a ConnectionString para a classe mãe (DbContext)
        public DataContext(): base(ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        // Definir os DbSet's para cada uma das Models
        // Serão criadas Tabelas no Banco para os DbSets/Models

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
