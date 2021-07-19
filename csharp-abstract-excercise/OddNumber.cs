using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_excercise
{
    internal class OddNumber : Number
    {
        protected int _number;

        public override int[] Generate()
        {
            for (var i = 0; i < _arrayLength; i++)
            {
                Random rd = new Random();
                _number = rd.Next(1, 999); // limit up to 999, as if there would be 1000, it would get a value of +1 (1001)
                if (_number % 2 != 0)
                {
                    _numberArray[i] = _number;
                }
                else
                {
                    _numberArray[i] = _number + 1;
                }
            }
            return _numberArray;
        }
    }
}