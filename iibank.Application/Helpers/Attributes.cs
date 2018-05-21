using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iibank.Application.Helpers
{
    class Attributes
    {
        public class MinValueAttribute : ValidationAttribute
        {
            private readonly int _minValue;

            public MinValueAttribute(int minValue)
            {
                _minValue = minValue;
            }

            public override bool IsValid(object value)
            {
                return (int)value >= _minValue;
            }
        }

        public class MaxValueAttribute : ValidationAttribute
        {
            private readonly int _maxValue;

            public MaxValueAttribute(int maxValue)
            {
                _maxValue = maxValue;
            }

            public override bool IsValid(object value)
            {
                return (int)value <= _maxValue;
            }
        }
    }
}
