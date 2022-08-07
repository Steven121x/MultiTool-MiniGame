using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTool
{
    class MatematicasLib
    {
        public int suma(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public int resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int multiplica(int num1, int num2)
        {
            return num1 * num2;
        }

        public int divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public double Pow0(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public double RaizCuadrada(double num1)
        {
            return Math.Sqrt(num1);
        }
    }
}
