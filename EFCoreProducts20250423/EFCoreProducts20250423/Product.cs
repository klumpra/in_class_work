using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProducts20250423 {
    internal class Product {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(16)]
        [Required]
        public string Name { get; set; }
        [StringLength(128)]
        public string Description { get; set; }
        [Range(0.99,10.99,ErrorMessage="Price must be between 0.99 and 10.99.")]
        public double Cost { get; set; }
        [StringLength(8)]
        [Required]
        public string Abbreviation { get; set; }
        [Range(0,4)]
        public int Rating { get; set; }
        public Product() {
            Id = 0;
            Name = "";
            Description = "";
            Cost = 0;
            Abbreviation = "";
        }
        public Product(int id, string name, string desc, double cost, string abbr) {
            Id = id;
            Name = name;
            Description = desc;
            Cost = cost;
            Abbreviation = abbr;
        }
        public override string ToString() {
            return $"{Id}\t{Name}\t{Description}\t{Cost:C}\t{Abbreviation}";
        }
    }
}
