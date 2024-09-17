namespace TristanPrelim.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    public class ShoppingCart
    {
        public List<Product> Items { get; private set; } = new List<Product>();
        public decimal TotalAmount => Items.Sum(item => item.Price);

        public void AddItem(Product product)
        {
            Items.Add(product);
        }
    }
}
