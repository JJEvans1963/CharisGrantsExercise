namespace FizzBuzzProcessor
{
   public class FizzBuzzProc
   {
      #region FizzBuzzNumber Processing Function

      // Check whether the number is a multiple of 3 or 5.
      public static string ProcessNumber(int number)
      {
         string answer;

         if (IsMultipleOf15(number))
         {
            answer = "fizzbuzz";
         }
         else if (IsMultipleOf3(number))
         {
            answer = "fizz";
         }
         else if (IsMultipleOf5(number))
         {
            answer = "buzz";
         }
         else
         {
            answer = number.ToString();
         }

         return answer;
      }

      #endregion

      #region Helper Functions

      public static bool IsMultipleOf3(int number) => number % 3 == 0;

      public static bool IsMultipleOf5(int number) => number % 5 == 0;

      public static bool IsMultipleOf15(int number) => number % 15 == 0;
      
      #endregion
   }
}
