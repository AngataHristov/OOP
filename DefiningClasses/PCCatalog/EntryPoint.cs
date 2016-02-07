
namespace PCCatalog
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    public class EntryPoint
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Computer pc1 = new Computer("Pravetz", "i7-3770k", 500m, "gotin processor", "NVIDIA 900-52055-0020-000 GRID K2 8GB", 150m, "qka", "ASRock 990FX Extreme3", 300.99m, "wow");

            Computer pc2 = new Computer("HP", "Core i3-3220 (3.30 GHz, 3 MB cache, 2 cores)", 300, "gotin processor", "Intel HD Graphics", 200m, "qka", "ASUS Z97-A LGA 1150 Intel Z97 HDMI SATA 6Gb/s ", 220m, "wow");

            Computer pc3 = new Computer("ASUS", "Core i5-4130 ", 420m, "gotin processor", "NVIDIA GeForce GTX 970", 1200m, "qka", "ASUS MAXIMUS VII HERO", 580m, "wow");

            var pc4 = new Computer("Lenovo");

            List<Computer> ListOfPCs = new List<Computer>();

            ListOfPCs.Add(pc1);
            ListOfPCs.Add(pc2);
            ListOfPCs.Add(pc3);
            ListOfPCs.Add(pc4);

            pc4.AddOrReplaceComponent(ComponentsEnum.GraphicsCard, "dger", 230, "rrtt");

            ListOfPCs = ListOfPCs.OrderBy(pc => pc.Price).ToList();

            foreach (var pc in ListOfPCs)
            {
                Console.WriteLine(pc);
            }
        }
    }
}
