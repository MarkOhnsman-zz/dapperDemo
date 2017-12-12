using System.ComponentModel.DataAnnotations;

namespace dapperDemo
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }

}