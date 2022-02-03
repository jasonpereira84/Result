using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace JasonPereira84.Result.Tests
{
    [TestClass]
    public partial class Test_Result
    {
        [TestMethod]
        public void ctor()
        {
            {
                {
                    var result = new Result<Int32, Object>();

                    Assert.IsNull(result.Overall);
                    Assert.AreEqual(
                        expected: default(Int32),
                        actual: result.Error);
                    Assert.AreEqual(
                        expected: default(Object),
                        actual: result.Value);
                }

                {
                    var result = new Result<SomeClass, Object>();

                    Assert.IsNull(result.Overall);
                    Assert.AreEqual(
                        expected: default(SomeClass),
                        actual: result.Error);
                    Assert.AreEqual(
                        expected: default(Object),
                        actual: result.Value);
                }

                {
                    var result = new Result<IEnumerable<Int32>, Object>();

                    Assert.IsNull(result.Overall);
                    Assert.AreEqual(
                        expected: default(IEnumerable<Int32>),
                        actual: result.Error);
                    Assert.AreEqual(
                        expected: default(Object),
                        actual: result.Value);
                }

                {
                    var result = new Result<DayOfWeek, Object>();

                    Assert.IsNull(result.Overall);
                    Assert.AreEqual(
                        expected: default(DayOfWeek),
                        actual: result.Error);
                    Assert.AreEqual(
                        expected: default(Object),
                        actual: result.Value);
                }

            }

            {
                {
                    var result = new Result<Object, Int32>();

                    Assert.IsNull(result.Overall);
                    Assert.AreEqual(
                        expected: default(Object),
                        actual: result.Error);
                    Assert.AreEqual(
                        expected: default(Int32),
                        actual: result.Value);
                }

                {
                    var result = new Result<Object, SomeClass>();

                    Assert.IsNull(result.Overall);
                    Assert.AreEqual(
                        expected: default(Object),
                        actual: result.Error);
                    Assert.AreEqual(
                        expected: default(SomeClass),
                        actual: result.Value);
                }

                {
                    var result = new Result<Object, IEnumerable<Int32>>();

                    Assert.IsNull(result.Overall);
                    Assert.AreEqual(
                        expected: default(Object),
                        actual: result.Error);
                    Assert.AreEqual(
                        expected: default(IEnumerable<Int32>),
                        actual: result.Value);
                }

                {
                    var result = new Result<Object, DayOfWeek>();

                    Assert.IsNull(result.Overall);
                    Assert.AreEqual(
                        expected: default(Object),
                        actual: result.Error);
                    Assert.AreEqual(
                        expected: default(DayOfWeek),
                        actual: result.Value);
                }
            }

        }

    }
}
