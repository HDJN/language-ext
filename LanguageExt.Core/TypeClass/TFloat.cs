﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageExt.TypeClass
{
    public struct TFloat : Ord<float>, Floating<float>
    {
        public bool Equals(float x, float y) => x == y;
        public bool LessOrEq(float x, float y) => x <= y;
        public bool GreaterOrEq(float x, float y) => x >= y;
        public bool LessThan(float x, float y) => x < y;
        public bool GreaterThan(float x, float y) => x > y;
        public float Add(float x, float y) => x + y;
        public float Difference(float x, float y) => x - y;
        public float Product(float x, float y) => x * y;

        /// <summary>
        /// Divide two numbers
        /// </summary>
        /// <param name="x">left hand side of the division operation</param>
        /// <param name="y">right hand side of the division operation</param>
        /// <returns>x / y</returns>
        public float Divide(float x, float y) =>
            x / y;

        public float Abs(float x) => Math.Abs(x);
        public float Signum(float x) => Math.Sign(x);
        public float FromInteger(int x) => (float)x;
        public float FromDecimal(decimal x) => (float)x;
        public float FromFloat(float x) => (float)x;
        public float FromDouble(double x) => (float)x;
        public float Div(float x, float y) => x / y;
        public float FromRational(Ratio<int> x) => x.Numerator / x.Denominator;
        public float Pi() => (float)Math.PI;
        public float Exp(float x) => (float)Math.Exp(x);
        public float Sqrt(float x) => (float)Math.Sqrt(x);
        public float Log(float x) => (float)Math.Log(x);
        public float Pow(float x, float y) => (float)Math.Pow(x, y);
        public float LogBase(float b, float x) => (float)Math.Log(x, b);
        public float Sin(float x) => (float)Math.Sin(x);
        public float Cos(float x) => (float)Math.Cos(x);
        public float Tan(float x) => (float)Math.Tan(x);
        public float Asin(float x) => (float)Math.Asin(x);
        public float Acos(float x) => (float)Math.Acos(x);
        public float Atan(float x) => (float)Math.Atan(x);
        public float Sinh(float x) => (float)Math.Sinh(x);
        public float Cosh(float x) => (float)Math.Cosh(x);
        public float Tanh(float x) => (float)Math.Tanh(x);
        public float Asinh(float x) => (float)Math.Log(x + Math.Sqrt((x * x) + 1.0));
        public float Acosh(float x) => (float)Math.Log(x + Math.Sqrt((x * x) - 1.0));
        public float Atanh(float x) => 0.5f * (float)Math.Log((1.0 + x) / (1.0 - x));
    }
}
