﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalcKata
{
    class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers)) return 0;

            var delimiters = new [] { ',', '\n' };

            var result = numbers.Split(delimiters)
                .Select(s => int.Parse(s))
                .Sum();
            
            return result;
        }

    }
}
