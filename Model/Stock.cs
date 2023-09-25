using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Produtos_API_ASP.NET.Model
{
    [Table("Stock")]
    public class Stock
    {
        [Key]
        public int EstoqueId { get; set; }

        [Required(ErrorMessage = "Stock quantity is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity must be a non-negative integer.")]
        public int QuantidadeEmEstoque { get; set; }

        [Required(ErrorMessage = "Stock date is required.")]
        public DateTime DataDoEstoque { get; set; }

        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }

        public virtual ProductModel product { get; set; }
    }
}
