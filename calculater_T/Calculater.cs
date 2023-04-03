using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculater_T
{
    static class Calculater
    {
        public static T  Sum <T>(T operand1 , T operand2) => (dynamic)operand1 + (dynamic)operand2;
        public static T Substraction<T>(T operand1, T operand2) => (dynamic)operand1 - (dynamic)operand2;
        public static T Multiply<T>(T operand1, T operand2) => (dynamic)operand1 * (dynamic)operand2;
        public static T Divide <T>(T operand1, T operand2) => (dynamic) operand1 / (dynamic) operand2;
    }
}
