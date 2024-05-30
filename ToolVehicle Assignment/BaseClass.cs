using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolVehicle_Assignment
{
    public abstract class ToolVehicle
    {
        public int VehicleID { get; set; }
        public string RegNo { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal BasePrice { get; set; }
        public string VehicleType { get; set; }

        public static int TotalVehicles { get; set; }
        public static int TotalCar { get; set; }
        public static int TotalBike { get; set; }
        public static int TotalHeavyVehicle { get; set; }
        public static int TotalTaxPayingVehicles { get; set; }
        public static int TotalNonTaxPayingVehicles { get; set; }
        public static decimal TotalTaxCollected { get; set; }
        public static decimal TotalUnpaidTaxAmount { get; set; }

        public ToolVehicle(int VehicleID, string RegNo, string Model, string Brand, decimal BasePrice, string VehicleType)
        {
            this.VehicleID = VehicleID;
            this.RegNo = RegNo;
            this.Model = Model;
            this.Brand = Brand;
            this.BasePrice = BasePrice;
            this.VehicleType = VehicleType;
        }

        public abstract void PayTax();

        public void PassWithoutPaying()
        {
            TotalNonTaxPayingVehicles++;
            TotalVehicles++;


        }

    }

    class Car : ToolVehicle

    {
        private int Cartax = 2;
        public Car(int VehicleID, string RegNo, string Model, string Brand, decimal BasePrice) : base(VehicleID, RegNo, Model, Brand, BasePrice, "Car")
        {



        }


        public override void PayTax()
        {
            TotalTaxCollected += Cartax;
            TotalTaxPayingVehicles++;
            TotalVehicles++;
            TotalCar++;

        }
        public new void PassWithoutPaying()
        {
            TotalUnpaidTaxAmount += Cartax;
            TotalNonTaxPayingVehicles++;
            TotalVehicles++;
            TotalCar++;
        }
    };

    class Bike : ToolVehicle
    {
        private int Biketax = 1;
        public Bike(int VehicleID, string RegNo, string Model, string Brand, decimal BasePrice) : base(VehicleID, RegNo, Model, Brand, BasePrice, "Bike")
        {



        }

        public override void PayTax()
        {
            TotalTaxCollected += Biketax;
            TotalTaxPayingVehicles++;
            TotalVehicles++;
            TotalBike++;


        }
        public new void PassWithoutPaying()
        {
            TotalUnpaidTaxAmount += Biketax;
            TotalNonTaxPayingVehicles++;
            TotalVehicles++;
            TotalBike++;
        }
    }
    class HeavyVehicle : ToolVehicle
    {
        private int HeavyVehicleTax = 4;
        public HeavyVehicle(int VehicleID, string RegNo, string Model, string Brand, decimal BasePrice) : base(VehicleID, RegNo, Model, Brand, BasePrice, "HeavyVehicle")
        {



        }

        public override void PayTax()
        {
            TotalTaxCollected += HeavyVehicleTax;
            TotalTaxPayingVehicles++;
            TotalVehicles++;
            TotalHeavyVehicle++;

        }
        public new void PassWithoutPaying()
        {
            TotalUnpaidTaxAmount += HeavyVehicleTax;
            TotalNonTaxPayingVehicles++;
            TotalVehicles++;
            TotalHeavyVehicle++;
        }
    };
}
