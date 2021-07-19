using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_excercise
{
    internal class NegativeNumber : Number
    {
        protected int _number;

        public override int[] Generate()
        {
            for (var i = 0; i < _arrayLength; i++)
            {
                Random rd = new Random();
                _number = rd.Next(1, 1000);
                _numberArray[i] = (-1) * _number; // all randomly generated numbers are made into negative ones
            }
            return _numberArray;
        }
    }
}