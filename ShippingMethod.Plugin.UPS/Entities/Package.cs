using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingMethod.Plugin.UPS.Entities
{
    public class Package
    {
        public decimal Height { get; set; }
        public decimal InsuredValue { get; set; }
        public bool IsOversize { get; set; }
        public decimal Length { get; set; }
        public decimal RoundedHeight
        {
            get { return Math.Ceiling(Height); }
        }
        public decimal RoundedLength
        {
            get { return Math.Ceiling(Length); }
        }
        public decimal RoundedWeight
        {
            get { return Math.Ceiling(Weight); }
        }
        public decimal RoundedWidth
        {
            get { return Math.Ceiling(Width); }
        }
        public decimal Weight { get; set; }
        public decimal Width { get; set; }
        public string Container { get; set; }
        public bool SignatureRequiredOnDelivery { get; set; }

        //public Package(int length, int width, int height, decimal weight, decimal insuredValue, string container = null, bool signatureRequiredOnDelivery = false) : this(length, width, height, weight, insuredValue, container, signatureRequiredOnDelivery)
        //{
        //}
        public Package()
        {

        }

        public Package(decimal length, decimal width, decimal height, decimal weight, decimal insuredValue, string container = null, bool signatureRequiredOnDelivery = false)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
            InsuredValue = insuredValue;
            Container = container;
            SignatureRequiredOnDelivery = signatureRequiredOnDelivery;
        }


    }
}
