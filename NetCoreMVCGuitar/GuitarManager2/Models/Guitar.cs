using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GuitarManager.Models
{
    public class Guitar
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="You must specify the manufacturer.")]
        [StringLength(50,ErrorMessage ="The manufacturer name must be 50 characters or less.")]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "You must specify the model name.")]
        [StringLength(50, ErrorMessage = "The model name must be 50 characters or less.")]
        public string ModelName { get; set; }
        [Required(ErrorMessage = "You must specify the year the guitar was made.")]
        [Range(1800,2025,ErrorMessage = "The year must be between 1800 and 2025.")]
        public int YearMade { get; set; }
        [Required(ErrorMessage = "You must specify the guitar's price.")]
        [Range(0, 1000000, ErrorMessage = "The price must be between free and $1 million.")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
