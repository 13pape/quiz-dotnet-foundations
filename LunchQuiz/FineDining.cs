﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class FineDining : Restaurant
    {
        public int NumberofSeatsAtBar { get; set; }
        
        public override int capacity()
        {
            return NumberofSeatsAtBar + (Numberof4PersonTables * 4) + (Numberof2PersonTables * 2);
        }
    }
}
