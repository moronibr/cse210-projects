using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Order
    {
        private List<Product> Products { get; }
        private Customer Customer { get; }

        public Order(Customer customer)
        {
            Products = new List<Product>();
            Customer = customer;
        }

        public void AddProductToOrder(Product product)
        {
            Products.Add(product);
        }

        public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;
            foreach (var product in Products)
            {
                totalCost += product.GetTotalCost();
            }
            totalCost += Customer.LivesInUSA() ? 5m : 35m;
            return totalCost;
        }

        public string GetPackingLabel()
        {
            StringBuilder packingLabel = new StringBuilder("Packing Label:\n");
            foreach (var product in Products)
            {
                packingLabel.AppendLine(product.GetPackingInfo());
            }
            return packingLabel.ToString();
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{Customer.GetShippingLabel()}";
        }
    }
}
