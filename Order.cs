using System;

namespace myApp
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }

        public Shipment Shipment;

        public Shipment GetShipment()
        {
            return Shipment;
        }

        public void SetShipment(Shipment value)
        {
            Shipment = value;
        }

        public float TotalPrice { get; set; }

        public bool IsShipped
        {
            get { return GetShipment() != null; }
        }
    }
}
