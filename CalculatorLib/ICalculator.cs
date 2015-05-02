using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;

namespace CalculatorLib
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        float Penambahan(float a, float b);

        [OperationContract]
        float Pengurangan(float a, float b);

        [OperationContract]
        float Perkalian(float a, float b);

        [OperationContract]
        float Pembagian(float a, float b);
    }
}
