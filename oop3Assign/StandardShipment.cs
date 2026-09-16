using System;
using System.Collections.Generic;
using System.Text;

namespace oop3Assign
{
    internal class StandardShipment :Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal deliveryFee, decimal weight, string destinantion)
          : base(trackingCode, description, deliveryFee, weight, destinantion)
        {
        }
    }
}
