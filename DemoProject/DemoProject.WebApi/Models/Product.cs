using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoProject.WebApi.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        public float Price { get; set; }

        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}
