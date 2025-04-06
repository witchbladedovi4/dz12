using dz12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz12
{
    public struct Scooter : ITransport
    {
        public string GetTransportType() => "Самокат";
        public decimal RentalCostPerMinute { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString() => $"Модель: {Model}, Год выпуска: {Year}";
    }
}