using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Produtos_API_ASP.NET.Model
{
    [Table("Product")]
    public class ProductModel
    {

        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [MaxLength(255, ErrorMessage = "Product name cannot exceed 255 characters.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Product price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Product price must be greater than zero.")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Product price must have up to two decimal places.")]
        public decimal ProductPrice { get; set; }

        [MaxLength(1000, ErrorMessage = "Product description cannot exceed 1000 characters.")]
        public string? ProductDescription { get; set; }

        public virtual ICollection<Stock> stock { get; set; }





    }
}
