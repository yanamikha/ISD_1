using System;


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address { Index = 51900, Country = "Ukraine", City = "Dnipro", Street = "Svobodu str.", House = "56", Apartment = 2};
            Console.WriteLine(address.Index + "\n" + address.Country + ", " + address.City + "\n" + address.Street + " " + address.House + "-" + address.Apartment);
        }
    }
    class Address
    {
        int index;
        string country;
        string city;
        string street;
        string house; //строка, так как в номере дома может быть дробь
        int apartment;

        public int Index { get => index; set => index = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string House { get => house; set => house = value; }
        public int Apartment { get => apartment; set => apartment = value; }
    }
}
