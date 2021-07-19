using System;

namespace csharp_abstract_excercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var possitive = new PossitiveNumber();
            var even = new EvenNumber();
            var odd = new OddNumber();
            var negative = new NegativeNumber();

            GenAndCalc(possitive);
            GenAndCalc(even);
            GenAndCalc(odd);
            GenAndCalc(negative);

            Console.WriteLine("---Bellow is in depth inforamtion for vlaidation---");

            possitive.GetValues(); // for validation purposes, displays the lenght of array and all its numbers/members
            even.GetValues();
            odd.GetValues();
            negative.GetValues();

            static void GenAndCalc(Number number)
            {
                number.Generate();
                Console.WriteLine($"{number} sum is: {number.GetSum()}");
            }
        }
    }
}