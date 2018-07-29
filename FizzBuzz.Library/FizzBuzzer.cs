﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            /*if (input % 3 == 0 && input % 5 == 0)
                return "FizzBuzz";
                if (input % 3 == 0)
                return "Fizz";
            if (input %5 == 0)
                return "Buzz";
            
            return input.ToString();*/

            string output = string.Empty;

            if (input % 3 == 0)
                output += "Fizz";
            if (input % 5 == 0)
                output += "Buzz";
            if (string.IsNullOrEmpty(output))
                output = input.ToString();
            return output;

        }
    }
}
