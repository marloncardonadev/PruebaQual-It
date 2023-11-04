namespace PruebaQualit.Core.Entities
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? ProductType { get; set; }
        public string? Description { get; set; }
    }
}
