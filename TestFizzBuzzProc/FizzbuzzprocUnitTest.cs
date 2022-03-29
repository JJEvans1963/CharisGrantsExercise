using FizzBuzzProcessor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFizzBuzzProc
{
   [TestClass]
   public class FizzbuzzprocUnitTest
   {
      // Test numbers for being multiples of 3, 5 or 15, or not.

      [TestMethod]
      [DataRow(3)]
      [DataRow(6)]
      [DataRow(9)]
      [DataRow(12)]
      public void TestHelperIsMultipleOf3(int value)
      {
         var result = FizzBuzzProc.IsMultipleOf3(value);

         Assert.IsTrue(result, $"{value} is multiple of 3");
      }

      [TestMethod]
      [DataRow(1)]
      [DataRow(2)]
      [DataRow(4)]
      [DataRow(5)]
      public void TestHelperIsNotMultipleOf3(int value)
      {
         var result = FizzBuzzProc.IsMultipleOf3(value);

         Assert.IsFalse(result, $"{value} is NOT a multiple of 3");
      }

      [TestMethod]
      [DataRow(5)]
      [DataRow(10)]
      [DataRow(20)]
      [DataRow(25)]
      public void TestHelperIsMultipleOf5(int value)
      {
         var result = FizzBuzzProc.IsMultipleOf5(value);

         Assert.IsTrue(result, $"{value} is multiple of 5");
      }

      [TestMethod]
      [DataRow(4)]
      [DataRow(6)]
      [DataRow(9)]
      [DataRow(11)]
      public void TestHelperIsNotMultipleOf5(int value)
      {
         var result = FizzBuzzProc.IsMultipleOf5(value);

         Assert.IsFalse(result, $"{value} is NOT a multiple of 5");
      }

      [TestMethod]
      [DataRow(15)]
      [DataRow(30)]
      [DataRow(45)]
      [DataRow(60)]
      public void TestHelperIsMultipleOf15(int value)
      {
         var result = FizzBuzzProc.IsMultipleOf15(value);

         Assert.IsTrue(result, $"{value} is multiple of 15");
      }

      [TestMethod]
      [DataRow(14)]
      [DataRow(31)]
      [DataRow(44)]
      [DataRow(61)]
      public void TestHelperIsNotMultipleOf15(int value)
      {
         var result = FizzBuzzProc.IsMultipleOf15(value);

         Assert.IsFalse(result, $"{value} is NOT a multiple of 15");
      }
   }
}
