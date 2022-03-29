using FizzBuzzProcessor;
using System;

namespace CharisGrantsExercise
{
   class Program
   {
      static void Main(string[] args)
      {
         // Process first 100 positive numbers.
         for (var i = 1; i < 101; i++)
         {
            Console.WriteLine(FizzBuzzProc.ProcessNumber(i));
         }
      }
   }
}
