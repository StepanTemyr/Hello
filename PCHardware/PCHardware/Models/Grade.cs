using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCHardware.Models
{
    public enum HardwareType
    {
        Processor,
        GraphicsCard,
        Motherboard,
        RAM
    }

    public class Grade
    {
        public HardwareType HardwareGrade { get; set; }
    }
}
