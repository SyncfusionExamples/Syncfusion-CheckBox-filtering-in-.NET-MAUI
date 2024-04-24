
namespace CheckBoxFiltering
{
    public class ProductInfo
    {
        public string Brand { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public Color Color { get; set; }
        public string Image { get; set; }

        public ProductInfo(string brand, string image, string size, Color color, string description)
        {
            Brand = brand;
            Description = description;
            Size = size;
            Color = color;
            Image = image;
        }
    }
}
