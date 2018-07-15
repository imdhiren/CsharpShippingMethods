using ShippingMethod.Plugin.UPS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingMethod.Plugin.UPS.Entities
{
    public class Shipment
    {
        public UPSServices Services { get; set; } = UPSServices.Ground;
        public UPSPickupType PickupType { get; set; } = UPSPickupType.OnCallAir;

        public decimal Rate { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }

    public class AddressValidationResponse
    {
        public string StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public Error Error { get; set; }
    }

    public class Error
    {
        public string Code { get; set; }
        public string Source { get; set; }
        public string Description { get; set; }
        public string HelpFile { get; set; }
        public string HelpContext { get; set; }
    }
}
