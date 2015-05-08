using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// namespace CalculatorLib perlu ditambahkan
// agar bisa mengakses interface ICalculator
using CalculatorLib;

using System.ServiceModel;

namespace CalculatorServer
{
    // class Calculator mengimplementasikan interface ICalculator
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.PerCall)]
    public class Calculator : ICalculator
    {
        public float Penambahan(float a, float b)
        {
            return a + b;
        }

        public float Pengurangan(float a, float b)
        {
            return a - b;
        }

        public float Perkalian(float a, float b)
        {
            return a * b;
        }

        public float Pembagian(float a, float b)
        {
            return a / b;
        }
    }
}
