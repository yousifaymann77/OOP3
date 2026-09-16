using System;
using System.Collections.Generic;
using System.Text;

namespace oop3Assign
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments;

        public string CenterName { get; set; }

        public DeliveryCenter()
        {
            this.shipments = new Shipment[20];
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }
                else return default!;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }
                return default!;
            }
        }

        public bool AddShipment(Shipment shipment)
        {

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        
        public bool RemoveShipment(string delCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == delCode)
                {
                    for (int j = i; j < shipments.Length - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }

                    shipments[shipments.Length - 1] = null!;

                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    Console.WriteLine("----------------------------------------");

                    if (shipments[i] is StandardShipment standard)
                    {
                        Console.WriteLine("Standard Shipment");
                        Console.WriteLine();

                        Console.WriteLine($"Tracking Code : {standard.TrackingCode}");
                        Console.WriteLine($"Description   : {standard.Description}");
                        Console.WriteLine($"Weight        : {standard.Weight} KG");
                        Console.WriteLine($"Delivery Fee  : {standard.DeliveryFee} EGP");
                        Console.WriteLine($"Destination   : {standard.Destination}");
                        Console.WriteLine($"Estimated Cost: {standard.EstimatedCost}");
                    }

                    else if (shipments[i] is ExpressShipment express)
                    {
                        Console.WriteLine("Express Shipment");
                        Console.WriteLine();

                        Console.WriteLine($"Tracking Code : {express.TrackingCode}");
                        Console.WriteLine($"Description   : {express.Description}");
                        Console.WriteLine($"Weight        : {express.Weight} KG");
                        Console.WriteLine($"Delivery Fee  : {express.DeliveryFee} EGP");
                        Console.WriteLine($"Extra Fee     : {express.ExtraFee} EGP");
                        Console.WriteLine($"Estimated Cost: {express.EstimatedCost}");
                    }

                    else if (shipments[i] is InternationalShipment international)
                    {
                        Console.WriteLine("International Shipment");
                        Console.WriteLine();

                        Console.WriteLine($"Tracking Code      : {international.TrackingCode}");
                        Console.WriteLine($"Description        : {international.Description}");
                        Console.WriteLine($"Weight             : {international.Weight} KG");
                        Console.WriteLine($"Delivery Fee       : {international.DeliveryFee} EGP");
                        Console.WriteLine($"Destination Country: {international.DestinationCountry}");
                        Console.WriteLine($"Customs Fee        : {international.CustomFee} EGP");
                        Console.WriteLine($"Estimated Cost     : {international.EstimatedCost}");
                    }

                    Console.WriteLine("----------------------------------------");
                }
            }
        }
    }
}
