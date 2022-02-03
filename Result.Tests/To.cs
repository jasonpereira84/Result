using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace JasonPereira84.Result.Tests
{
    public partial class Test_Result
    {
        [TestMethod]
        public void To()
        {
            {
                {
                    var result = new Result<Int32, Object>();

                    var error = 1;
                    result.ToFailure(error);
                    Assert.IsFalse(result.Overall);
                    Assert.AreEqual(
                        expected: error,
                        actual: result.Error);
                }

                {
                    var result = new Result<SomeClass, Object>();

                    var error = new SomeClass { Value = 1 };
                    result.ToFailure(error);
                    Assert.IsFalse(result.Overall);
                    Assert.AreEqual(
                        expected: error,
                        actual: result.Error);
                }

                {
                    var result = new Result<IEnumerable<Int32>, Object>();

                    var error = new[] { 1 };
                    result.ToFailure(error);
                    Assert.IsFalse(result.Overall);
                    Assert.AreEqual(
                        expected: error,
                        actual: result.Error);
                }

                {
                    var result = new Result<DayOfWeek, Object>();

                    var error = DayOfWeek.Monday;
                    result.ToFailure(error);
                    Assert.IsFalse(result.Overall);
                    Assert.AreEqual(
                        expected: error,
                        actual: result.Error);
                }

            }

            {
                {
                    var result = new Result<Object, Int32>();

                    var value = 1;
                    result.ToSuccess(value);
                    Assert.IsTrue(result.Overall);
                    Assert.AreEqual(
                        expected: value,
                        actual: result.Value);
                }

                {
                    var result = new Result<Object, SomeClass>();

                    var value = new SomeClass { Value = 1 };
                    result.ToSuccess(value);
                    Assert.IsTrue(result.Overall);
                    Assert.AreEqual(
                        expected: value,
                        actual: result.Value);
                }

                {
                    var result = new Result<Object, IEnumerable<Int32>>();

                    var value = new[] { 1 };
                    result.ToSuccess(value);
                    Assert.IsTrue(result.Overall);
                    Assert.AreEqual(
                        expected: value,
                        actual: result.Value);
                }

                {
                    var result = new Result<Object, DayOfWeek>();

                    var value = DayOfWeek.Monday;
                    result.ToSuccess(value);
                    Assert.IsTrue(result.Overall);
                    Assert.AreEqual(
                        expected: value,
                        actual: result.Value);
                }

            }

        }

    }
}
