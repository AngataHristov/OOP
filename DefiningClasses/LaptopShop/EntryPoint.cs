
namespace LaptopShop
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            Laptop firstLaptop = new Laptop("Latitude", LaptopManufacturers.Dell, 3000, 3500, 4.5, "i7 QM", "8GB", "N-VIDIA", "SSD 128GB", "15.4\"", "Lit-Ion,6cells");

            Console.WriteLine(firstLaptop);

            var secondLAptop = new Laptop("Satellite", LaptopManufacturers.Toshiba, 800, "i3", "4GB", "N-VIDIA", "HDD 320GB", "15.4\"");

            // method for battery adding
            secondLAptop.AddBattery(2500, 1.5, "Lit-Ion,3cells");

            Console.WriteLine(new string('=', 30));

            Console.WriteLine(secondLAptop);

            var thirdLaptop = new Laptop("Aspire", 1200, LaptopManufacturers.Acer);

            Console.WriteLine(thirdLaptop);
        }
    }
}
