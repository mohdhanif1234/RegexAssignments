﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexPatternMatching email = new RegexPatternMatching();
            email.ValidateEmailAllRules("abc.@gmail.com");
        }
    }
}
