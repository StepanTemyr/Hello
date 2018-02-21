using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCHardware.Models
{
    public enum Manufacturer
    {
        AMD,
        Asrock,
        Asus,
        Corsair,
        Gigabyte,
        HyperX,
        Intel,
        MSI,
        Samsung

    }

    public class Component
    {
        public string Name { get; set; }
        public Manufacturer Mnfctr { get; set; }
        public Grade Grade { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}
