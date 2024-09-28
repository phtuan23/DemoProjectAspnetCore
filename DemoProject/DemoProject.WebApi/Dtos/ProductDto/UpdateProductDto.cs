namespace DemoProject.WebApi.Dtos.ProductDto
{
    public class UpdateProductDto
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public required string Description { get; set; }
    }
}
