using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wharehouse_api.Models
{
    [Table("Categories")]
    public class Category
    {

        public Category()
        {
            Products = new Collection<Product>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string? Name { get; set; }

        [StringLength(300)]
        public string?  ImageUrl { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
