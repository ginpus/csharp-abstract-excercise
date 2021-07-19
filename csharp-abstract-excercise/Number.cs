using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_excercise
{
    internal abstract class Number
    {
        protected readonly int[] _numberArray; //main array, where all the numbers will be kept
        protected readonly int _arrayLength; //array length that will be always randomly generated, when Number constructor will be called
        protected double _sum;

        public abstract int[] Generate(); // abstract method that is overriden in every number type

        public double GetSum() // method is public as all the numbers have exactly the same implementation
        {
            for (var i = 0; i < _arrayLength; i++)
            {
                _sum += _numberArray[i]; // all array members are added up
            }
            return _sum * 1.0; // to avoid upcasting, sum is multiplied by 1.0
        }

        public void GetValues() // method is public as all the numbers have exactly the same implementation
        {
            Console.WriteLine($"{this} array length: {_arrayLength}");
            //var fullArray = "";
            for (var i = 0; i < _arrayLength; i++)
            {
                Console.WriteLine(_numberArray[i].ToString());
                //fullArray += $"{_numberArray[i]}, ";
            }
            //Console.WriteLine(fullArray);
        }

        public Number() // when Number constructor is used (via Child class), it generates a 1) random number, which is used as a length of an array that also 2) gets created while calling up this constructor
        {
            Random rd = new Random();
            _arrayLength = rd.Next(20, 200);
            _numberArray = new int[_arrayLength];
        }
    }
}