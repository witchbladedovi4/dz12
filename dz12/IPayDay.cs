using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz12
{
    public interface IPayDay
    {
        double CalculateSalary();

        // Свойства для работы с полями
        string FullName { get; set; }
        int WorkingDays { get; set; }
    }
}
