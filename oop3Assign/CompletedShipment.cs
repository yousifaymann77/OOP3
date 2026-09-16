using System;
using System.Collections.Generic;
using System.Text;

namespace oop3Assign
{
    #region part02 Q8 seales Class Completed Shipment
    internal sealed  class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee ) : base(trackingCode, description, weight, deliveryFee)
        {
        }
    } 
    #endregion
}
