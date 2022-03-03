﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjtesting
{
    internal class Calculatortestcase
    {
        Calculator calculator=new Calculator();

        [TestCase]

        public void Add()
        {
            Assert.AreEqual(40, calculator.Addition(30, 10));
        }
        [TestCase]
        public void Sub()
        {
            Assert.Catch<ArgumentException>(() => calculator.Subtraction(2, 4));
        }

    }
}
