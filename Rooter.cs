using System;

namespace comp311_lab3
{
    public class Rooter
    {
        // internal double SquareRoot(double input)
        // {
        //     // throw new NotImplementedException
        //     return input / 2;
        // }

        public double SquareRoot(double input)

        {

            double result = input;

            double previousResult = -input;

            while (Math.Abs(previousResult - result) > result / 1000)

            {

                previousResult = result;

                result = result - (result * result - input) / (2 * result);

            }

            return result;

        }

    }
}
