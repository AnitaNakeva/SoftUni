using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Utilities
{
    internal class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int minValue;
        private readonly int maxValue;

        public MyRangeAttribute(int min, int max)
        {
            this.minValue = min;
            this.maxValue = max;
        }
        public override bool IsValid(object obj)
        {
            if (obj is int val)
            {
                return val >= minValue && val <= maxValue;
            }

            return false;
        }
    }
}
