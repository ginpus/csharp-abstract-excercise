using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_excercise
{
    internal class EvenNumber : Number
    {
        protected int _number;

        public override int[] Generate()
        {
            for (var i = 0; i < _arrayLength; i++)
            {
                Random rd = new Random();
                _number = rd.Next(1, 500) * 2; // numbers are guaranteed to be up to 1000 and even (modulus of 2 always 0)
                _numberArray[i] = _number;
            }
            return _numberArray;
        }
    }
}