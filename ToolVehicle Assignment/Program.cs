using System.Collections;
using System;
using System.Threading.Channels;
using System.Collections.Generic;
using ToolVehicle_Assignment;



class Program
{
    static void Main()
    {

        Car Car1 = new Car(1, "XYZ788", "Honda", "Civics 1200cc", 2000000);
        Bike bike1 = new Bike(2, "XYZ789", "Hyundai", "Hyundai CD70", 160000);
        HeavyVehicle hv1 = new HeavyVehicle(3, "LMN456", "Toyota", "Innoova 2700cc", 7784000);
        HeavyVehicle hv2 = new HeavyVehicle(4, "LMN456", "Hyundai", "Hyundai H-100", 10000000);
        HeavyVehicle hv3 = new HeavyVehicle(5, "LMN456", "Actros", "Mercedes", 2760000);
        Car Car2 = new Car(6, "XYZ7100", "Toyota", "Fortuner", 900000);
        Car Car3 = new Car(7, "XYG711", "Suzuki", "Alto VXR", 2750000);
        Bike bike2 = new Bike(8, "XYZ989", "United ", "US125 Deluxe", 150000);
        Bike bike3 = new Bike(9, "XYZ200", "Suzuki", "GD 110s", 250000);


        Car1.PayTax();
        bike1.PayTax();
        hv1.PassWithoutPaying();
        hv2.PassWithoutPaying();
        hv3.PayTax();
        Car2.PayTax();
        Car3.PassWithoutPaying();
        bike2.PayTax();
        bike3.PayTax();



        Console.WriteLine("Welcome to Tool Vehicle");
        do
        {



           
            Console.WriteLine("");
            Console.WriteLine("Select Category");
            Console.WriteLine("");

            Console.WriteLine("1. Total Vehicle");
            Console.WriteLine("2. Total Tax Paying Vehicle ");
            Console.WriteLine("3. Total Tax Non Paying Vehicle ");
            Console.WriteLine("4. Total Tax Collected ");
            Console.WriteLine("5. Total Unpaid Tax Amount ");
            Console.WriteLine("6. Exit");
            Console.WriteLine("");

            Console.Write("Enter Your Choise : ");


            if (!int.TryParse(Console.ReadLine(), out int Count))

            {
                Console.WriteLine("");
                Console.WriteLine("Invalid Choise");
                Console.WriteLine("");
                continue;



            }

            switch (Count)
            {
                case 1:
                    Console.WriteLine(" ");
                    Console.WriteLine("Select Category");
                    Console.WriteLine(" ");
                    Console.WriteLine("1. Total Vehicles");
                    Console.WriteLine("2. Total Cars");
                    Console.WriteLine("3. Total Bike");
                    Console.WriteLine("4. Total Heavy Vehicles");
                    Console.WriteLine(" ");
                    Console.Write("Enter Your Choise : ");
                    if (!int.TryParse(Console.ReadLine(), out int Total))
                    {
                        Console.WriteLine("Entre a Valid Value");
                        continue;

                    }
                    switch (Total)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine($"Total Vehicles : {ToolVehicle.TotalVehicles}");
                            Console.WriteLine("");
                            continue;

                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine($"Total Cars : {ToolVehicle.TotalCar}");
                            Console.WriteLine("");
                            continue;
                        case 3:
                            Console.WriteLine("");
                            Console.WriteLine($"Total Bikes : {ToolVehicle.TotalBike}");
                            Console.WriteLine("");
                            continue;
                        case 4:
                            Console.WriteLine("");
                            Console.WriteLine($"Total Heavy Vehicles : {ToolVehicle.TotalHeavyVehicle}");
                            Console.WriteLine("");
                            
                            continue;

                        default:
                            Console.WriteLine("");
                            Console.WriteLine("Invalid Operation");
                            Console.WriteLine("");
                            continue;
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine($"Total Tax Paying Vehicle : {ToolVehicle.TotalTaxPayingVehicles}");
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine($"Total Tax Non Paying Vehicle : {ToolVehicle.TotalNonTaxPayingVehicles}");
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine($"Total Tax Collected Amount : {ToolVehicle.TotalTaxCollected}.00$");
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    Console.WriteLine($"Total Unpaid Tax Amount : {ToolVehicle.TotalUnpaidTaxAmount}.00$");
                    Console.WriteLine("");
                    break;
                case 6:
                    
                       
                    return;

                    
                    break;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Invalid Operation");
                    Console.WriteLine("");

                    continue;
            };
        } while (true);

    }


}

