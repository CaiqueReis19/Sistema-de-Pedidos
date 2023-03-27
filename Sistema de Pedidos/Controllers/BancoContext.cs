using Microsoft.EntityFrameworkCore;
using Sistema_de_Pedidos.Models;

namespace Sistema_de_Pedidos.data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        
        }

        public DbSet<FornecedorModel> Fornecedores{ get; set; }
    }
}
