using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingMethod.Plugin.UPS.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string PhoneNo { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public Country Country { get; set; }
        public State State { get; set; }
        public string Suite { get; set; }
        public AddressType Type { get; set; }
        public Company Company { get; set; }
        public AddressType AddressType { get; set; }
        public bool IsDefault { get; set; }
        public bool IsBillSameShip { get; set; }
    }
    public class AddressType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AbbreviationName { get; set; }
        public string CountryCode { get; set; }
        public string CurrencyCode { get; set; }
    }

    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public string AbbreviationName { get; set; }
        public string StateCode { get; set; }
    }
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
