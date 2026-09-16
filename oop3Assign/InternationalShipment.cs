using System;
using System.Collections.Generic;
using System.Text;

namespace oop3Assign
{
    internal class InternationalShipment : Shipment
    {
        private string destinationCountry = default!;
        private decimal customFee;

        public InternationalShipment(string trackingCode, string description, decimal deliveryFee, decimal weight, string destinationCountry, decimal customFee, string destination)
            : base(trackingCode, description, deliveryFee, weight, destination)
        {
            this.customFee = customFee;
            this.destinationCountry = destinationCountry;
        }

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (string.IsNullOrWhiteSpace(destinationCountry))
                {
                    destinationCountry = value;
                }
            }
        }
        public decimal CustomFee
        {
            get { return customFee; }
            set
            {
                if (customFee >= 0)
                {
                    customFee = value;
                }
            }
        }

        public override decimal EstimatedCost => base.EstimatedCost + customFee;

        public override string PrintShipment()
        {
            return base.PrintShipment();
            Console.WriteLine($"Destination country : {destinationCountry}");
            Console.WriteLine($"CustomFee : {customFee}");
        }

        public virtual void GenerateCustomReport()
        {
            Console.WriteLine($"CustomFee : {customFee}");
            Console.WriteLine($"Destination Country : {destinationCountry}");
        }
    }
}
