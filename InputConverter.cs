using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;
            bool isConverted = double.TryParse(argTextInput, out convertedNumber);
            if (!isConverted)
            {
                throw new ArgumentException("Expected a numeric value.");
            }

            return convertedNumber;
        } 
    }
}
