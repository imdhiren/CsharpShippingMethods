using ShippingMethod.Plugin.UPS;
using ShippingMethod.Plugin.UPS.Domain;
using ShippingMethod.Plugin.UPS.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingMethodsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string encoding = "utf-8";

            var appSettings = ConfigurationManager.AppSettings;

            var upsLicenseNumber = appSettings["UPSLicenseNumber"];
            var upsUserId = appSettings["UPSUserId"];
            var upsPassword = appSettings["UPSPassword"];

            var packages = new List<Package>();
            packages.Add(new Package(12, 12, 12, 35, 150));
            packages.Add(new Package(4, 4, 6, 15, 250));

            var shipperAddress = new Address();
            shipperAddress.ZipCode = "06405";
            shipperAddress.City = "";
            shipperAddress.Country = new Country()
            {
                CountryCode = "US"
            };
            shipperAddress.State = new State()
            {
                StateCode = "MI"
            };

            var destinationAddress = new Address();
            destinationAddress.ZipCode = "20852";
            destinationAddress.Country = new Country()
            {
                CountryCode = "US"
            };

            var p = new List<Package>();
            p.Add(new Package(12, 12, 12, 35, 0));
            p.Add(new Package(4, 4, 6, 15, 0));

            var getServiceCode = UPS.GetUPSCode(UPSServices.Ground.ToString());

            UPS uPS = new UPS();
            uPS.SetCredentials(upsLicenseNumber, upsUserId, upsPassword, null);
            var rateString = uPS.RatingServiceSelectionRequest(shipperAddress, destinationAddress, p, getServiceCode,"03");
            var rateResponse = HttpHelper.Post(appSettings["UPSRateUrl"], rateString, encoding);
            var error = "";
            var rate = UPS.GetRate(rateResponse, false, ref error);

            var validAdd = uPS.AddressValidation(shipperAddress);
            var addressResponse = HttpHelper.Post(appSettings["UPSAddressValidationURL"], validAdd, encoding);
            var addressValid = UPS.GetAddressValidationResponses(addressResponse, ref error);
        }
    }
}
