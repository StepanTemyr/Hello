using System;
using PCHardware.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCHardware
{
    class Program
    {
        private static Component GetComponent1()
        {
            Component Component1 = new Component();
            Component1.Name = "I7-8700K";
            Component1.Mnfctr = Manufacturer.Intel;
            Component1.Grade = new Grade()
            {
                HardwareGrade = HardwareType.Processor
            };
            Component1.Description = "6x 3.70 Ghz, 1151-v2 Socket";
            Component1.Price = 20990;


            return Component1;
        }

        private static Component GetComponent2()
        {
            Component Component2 = new Component();
            Component2.Name = "Ryzen 7 1700";
            Component2.Mnfctr = Manufacturer.AMD;
            Component2.Grade = new Grade()
            {
                HardwareGrade = HardwareType.Processor
            };
            Component2.Description = "8x 3.0 (3.7) Ghz, AM4 Socket";
            Component2.Price = 17499;



            return Component2;
        }

        private static Component GetComponent3()
        {
            Component Component3 = new Component();
            Component3.Name = "GeForce GTX 1070 AORUS";
            Component3.Mnfctr = Manufacturer.Gigabyte;
            Component3.Grade = new Grade()
            {
                HardwareGrade = HardwareType.GraphicsCard
            };
            Component3.Description = "8 Gb, 1556 (1746) MHz OC";
            Component3.Price = 39990;



            return Component3;
        }

        private static Component GetComponent4()
        {
            Component Component4 = new Component();
            Component4.Name = "GeForce GTX 1080 STRIX";
            Component4.Mnfctr = Manufacturer.Asus;
            Component4.Grade = new Grade()
            {
                HardwareGrade = HardwareType.GraphicsCard
            };
            Component4.Description = "8 Gb, 1607 (1733) MHz OC";
            Component4.Price = 78690;



            return Component4;
        }

        private static Component GetComponent5()
        {
            Component Component5 = new Component();
            Component5.Name = "GeForce GTX 1060 Gaming 6G";
            Component5.Mnfctr = Manufacturer.MSI;
            Component5.Grade = new Grade()
            {
                HardwareGrade = HardwareType.GraphicsCard
            };
            Component5.Description = "6 Gb, 1531 (1746) MHz OC";
            Component5.Price = 34199;



            return Component5;
        }

        private static Component GetComponent6()
        {
            Component Component6 = new Component();
            Component6.Name = "Z370 PRO4 ATX";
            Component6.Mnfctr = Manufacturer.Asrock;
            Component6.Grade = new Grade()
            {
                HardwareGrade = HardwareType.Motherboard
            };
            Component6.Description = "Intel Z370 Chipset, 1151-v2 Socket, 4xDDR4, 2xPCIe(x16), 6xSATA3, M2 Slot";
            Component6.Price = 6399;



            return Component6;
        }

        private static Component GetComponent7()
        {
            Component Component7 = new Component();
            Component7.Name = "STRIX X370-F Gaming ATX";
            Component7.Mnfctr = Manufacturer.Asus;
            Component7.Grade = new Grade()
            {
                HardwareGrade = HardwareType.Motherboard
            };
            Component7.Description = "AMD X370 Chipset, AM4 Socket, 4xDDR4, 2xPCIe(x16), SLI/CrossfireX, 8xSATA3, M2 Slot";
            Component7.Price = 10590;



            return Component7;
        }

        private static Component GetComponent8()
        {
            Component Component8 = new Component();
            Component8.Name = "Vengeance LPX 16GB (2x8) DDR4 K2";
            Component8.Mnfctr = Manufacturer.Corsair;
            Component8.Grade = new Grade()
            {
                HardwareGrade = HardwareType.RAM
            };
            Component8.Description = "3200 MHz (PC4-25600), DIMM 288 Pin, CL16";
            Component8.Price = 12699;



            return Component8;
        }

        private static Component GetComponent9()
        {
            Component Component9 = new Component();
            Component9.Name = "DDR4-2133 16 Gb (1x16) ECC";
            Component9.Mnfctr = Manufacturer.Samsung;
            Component9.Grade = new Grade()
            {
                HardwareGrade = HardwareType.RAM
            };
            Component9.Description = "2133 MHz (PC4-17000), DIMM 288 Pin, CL15, ECC";
            Component9.Price = 10890;



            return Component9;
        }

        private static Component GetComponent10()
        {
            Component Component10 = new Component();
            Component10.Name = "Fury black 16 Gb (2x8) DDR4 K2 HX426C16FB2K2/16";
            Component10.Mnfctr = Manufacturer.HyperX;
            Component10.Grade = new Grade()
            {
                HardwareGrade = HardwareType.RAM
            };
            Component10.Description = "2666 MHz (PC4-21300U), DIMM 288 Pin, CL16";
            Component10.Price = 10999;



            return Component10;
        }

        static void Main(string[] args)
        {
            Component Component1 = GetComponent1();
            Component Component2 = GetComponent2();
            Component Component3 = GetComponent3();
            Component Component4 = GetComponent4();
            Component Component5 = GetComponent5();
            Component Component6 = GetComponent6();
            Component Component7 = GetComponent7();
            Component Component8 = GetComponent8();
            Component Component9 = GetComponent9();
            Component Component10 = GetComponent10();

            List<Component> Components = new List<Component>
            {
                Component1,
                Component2,
                Component3,
                Component4,
                Component5,
                Component6,
                Component7,
                Component8,
                Component9,
                Component10
            };
            WriteComponentInfo(Components);
            Console.WriteLine("--------------------------------------Сортировка комплектующих по производителю---------------------------------------;\n");
            SortByFretsCount(Components);
            WriteComponentInfo(Components);
            Console.ReadKey();
        }

        private static void SortByFretsCount(List<Component> Components)
        {
            for (int i = 0; i < Components.Count; i++)
            {
                for (int j = 0; j < Components.Count - i - 1; j++)
                {


                    if (Components[j].Mnfctr > Components[j + 1].Mnfctr)
                    {
                        Component temp = Components[j];
                        Components[j] = Components[j + 1];
                        Components[j + 1] = temp;
                    }

                    else
                    {
                        if (Components[j].Mnfctr > Components[j + 1].Mnfctr)
                        {
                            Component temp = Components[j];
                            Components[j] = Components[j + 1];
                            Components[j + 1] = temp;
                        }
                    }
                }
            }
        }

        private static void WriteComponentInfo(List<Component> Components)
        {
            Console.WriteLine("list of components:\r\n");
            int n = 1;
            foreach (var Component in Components)
            {
                Console.WriteLine($"Component {n}:\r\n");
                n++;
                string ComponentInfo = $"Component name: {Component.Name}\r\n" +
                    $"Component Manufacturer: {Component.Mnfctr}\r\n" +
                    $"Component Type: {Component.Grade.HardwareGrade}\r\n" +
                    $"Component Description: {Component.Description}\r\n" +
                    $"Component Price: {Component.Price}\r\n";
                Console.WriteLine(ComponentInfo);

            }
        }
    }
}
