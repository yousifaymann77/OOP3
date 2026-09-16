using System;
using System.Collections.Generic;
using System.Text;

namespace oop3Assign
{
    internal class ExpressShipment : Shipment
    {
        public ExpressShipment(string trackingCode, string description, decimal deliveryFee, decimal weight, string destinantion, decimal extraFee)
           : base(trackingCode, description, deliveryFee, weight, destinantion)
        {
            this.extraFee = extraFee;
        }

        private decimal extraFee;
        public decimal ExtraFee
        {

            get
            {
                return extraFee;
            }
            set
            {
                if (extraFee >= 0)
                {
                    extraFee = value;
                }
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + extraFee;

            }

        }
    }
}
