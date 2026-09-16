using System;
using System.Collections.Generic;
using System.Text;

namespace oop3Assign
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, decimal deliveryFee, decimal weight, string destinationCountry, decimal customFee, string destination)
            : base(trackingCode, description, deliveryFee, weight, destination , customFee , destinationCountry)
        {
        }

        public sealed override void GenerateCustomReport()
        {
            base.GenerateCustomReport();
        }
    }
}
