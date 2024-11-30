namespace Encapsulation
{
    public class Customer
    {
        private string Name { get; }
        private Address Address { get; }

        public Customer(Address address, string name)
        {
            Address = address;
            Name = name;
        }

        public bool LivesInUSA()
        {
            return Address.IsInUSA();
        }

        public string GetShippingLabel()
        {
            return $"{Name}\n{Address.GetFullAddress()}";
        }
    }
}
