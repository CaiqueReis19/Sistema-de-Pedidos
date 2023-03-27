using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Pedidos.Models
{
    public class FornecedorModel
    {
        [Key]
        public int IdFornecedor { get; set; }
        
        public string? Razao { get; set; }
        public int CNPJ { get; set; }

    }
}
