﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz12
{
    public interface ITax
    {
        static string RuClassName { get; set; }
        public string ProductName {  get; set; }

        double AddTax();
    }
}
