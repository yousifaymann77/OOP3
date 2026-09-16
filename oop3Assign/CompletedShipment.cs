using System;
using System.Collections.Generic;
using System.Text;

namespace oop3Assign
{
    internal class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, string destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
    }
}
