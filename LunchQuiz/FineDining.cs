﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class FineDining
    {
        public int NumberofSeatsAtBar { get; set; }
        public int Numberof4PersonTables { get; set; }
        public int Numberof2PersonTables { get; set; }

        public int capacity()
        {
            return NumberofSeatsAtBar + (Numberof4PersonTables * 4) + (Numberof2PersonTables * 2);
        }
    }
}
