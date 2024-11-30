namespace Encapsulation
{
    public class Address
    {
        private string StreetAddress { get; }
        private string City { get; }
        private string State { get; }
        private string Country { get; }

        public Address(string streetAddress, string city, string state, string country)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Country = country;
        }

        public bool IsInUSA()
        {
            return Country.ToUpper() == "USA";
        }

        public string GetFullAddress()
        {
            return $"{StreetAddress}\n{City}, {State}\n{Country}";
        }
    }
}
