// <copyright file="CalculatorTest.cs">Copyright ©  2015</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleWinForm;

namespace SampleWinForm.Tests
{
    /// <summary>このクラスには、Calculator に対するパラメーター化された単体テストが含まれています</summary>
    [PexClass(typeof(Calculator))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CalculatorTest
    {
        /// <summary>Add(Int32, Int32) のテスト スタブ </summary>
        [PexMethod]
        public int AddTest(
            [PexAssumeUnderTest]Calculator target,
            int number1,
            int number2
        )
        {
            int result = target.Add(number1, number2);
            return result;
            // TODO: アサーションを メソッド CalculatorTest.AddTest(Calculator, Int32, Int32) に追加します
        }

        /// <summary>Divide(Int32, Int32) のテスト スタブ </summary>
        [PexMethod]
        public int DivideTest(
            [PexAssumeUnderTest]Calculator target,
            int number1,
            int number2
        )
        {
            int result = target.Divide(number1, number2);
            return result;
            // TODO: アサーションを メソッド CalculatorTest.DivideTest(Calculator, Int32, Int32) に追加します
        }

        /// <summary>Multiply(Int32, Int32) のテスト スタブ </summary>
        [PexMethod]
        public int MultiplyTest(
            [PexAssumeUnderTest]Calculator target,
            int number1,
            int number2
        )
        {
            int result = target.Multiply(number1, number2);
            return result;
            // TODO: アサーションを メソッド CalculatorTest.MultiplyTest(Calculator, Int32, Int32) に追加します
        }

        /// <summary>Subtract(Int32, Int32) のテスト スタブ </summary>
        [PexMethod]
        public int SubtractTest(
            [PexAssumeUnderTest]Calculator target,
            int number1,
            int number2
        )
        {
            int result = target.Subtract(number1, number2);
            return result;
            // TODO: アサーションを メソッド CalculatorTest.SubtractTest(Calculator, Int32, Int32) に追加します
        }
    }
}
