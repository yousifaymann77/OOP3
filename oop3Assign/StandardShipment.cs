using System;
using System.Collections.Generic;
using System.Text;

namespace oop3Assign
{
    internal class StandardShipment :Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal deliveryFee, decimal weight)
          : base(trackingCode, description, deliveryFee, weight)
        {
        }

        #region part02 Q 4 override Print Shipment
        public override string PrintShipment()
        {
            return base.PrintShipment();
        } 
        #endregion
    }
}
