namespace Encapsulation
{
    public class Product
    {
        private string Name { get; }
        private string ProductId { get; }
        private decimal Price { get; }
        private int Quantity { get; }

        public Product(string name, string productId, decimal price, int quantity)
        {
            Name = name;
            ProductId = productId;
            Price = price;
            Quantity = quantity;
        }

        public decimal GetTotalCost()
        {
            return Price * Quantity;
        }

        public string GetPackingInfo()
        {
            return $"{Name} ({ProductId})";
        }
    }
}
