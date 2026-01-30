using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace JasonPereira84.Result.Tests
{
    public partial class Test_Result
    {
        [TestMethod]
        public void Factory()
        {

            {

                {
                    var result = Result.FromUnknown();

                    Assert.IsNull(result.Overall);
                }

                {
                    var result = Result.FromFailure();

                    Assert.IsFalse(result.Overall);
                }

                {
                    var result = Result.FromSuccess();

                    Assert.IsTrue(result.Overall);
                }

            }

            {

                {

                    {
                        var result = Result<Int32>.FromUnknown(5);

                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                    }

                    {
                        var result = Result<Int32>.FromUnknown();

                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: default,
                            actual: result.Value);
                    }

                }

                {

                    {
                        var result = Result<Int32>.FromFailure(5);

                        Assert.IsFalse(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                    }

                    {
                        var result = Result<Int32>.FromFailure();

                        Assert.IsFalse(result.Overall);
                        Assert.AreEqual(
                            expected: default,
                            actual: result.Value);
                    }

                }

                {
                    var result = Result<Int32>.FromSuccess(5);

                    Assert.IsTrue(result.Overall);
                    Assert.AreEqual(
                        expected: 5,
                        actual: result.Value);
                }

            }

            {

                {

                    {
                        var result = Result<Int32, Decimal>.FromUnknown(5, 10m);

                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);
                    }

                    {
                        var result = Result<Int32, Decimal>.FromUnknown(5);

                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: default(Decimal),
                            actual: result.Error);
                    }

                    {
                        var result = Result<Int32, Decimal>.FromUnknown(5);

                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: default(Decimal),
                            actual: result.Error);
                    }

                    {
                        var result = Result<Int32, Decimal>.FromUnknown();

                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: default(Int32),
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: default(Decimal),
                            actual: result.Error);
                    }

                }

                {

                    {
                        var result = Result<Int32, Decimal>.FromFailure(5, 10m);

                        Assert.IsFalse(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);
                    }

                    {
                        var result = Result<Int32, Decimal>.FromFailure(5);

                        Assert.IsFalse(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: default,
                            actual: result.Error);
                    }

                    {
                        var result = Result<Int32, Decimal>.FromFailure(10m);

                        Assert.IsFalse(result.Overall);
                        Assert.AreEqual(
                            expected: default,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);
                    }

                }

                {

                    {
                        var result = Result<Int32, Decimal>.FromSuccess(5, 10m);

                        Assert.IsTrue(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);
                    }

                    {
                        var result = Result<Int32, Decimal>.FromSuccess(5);

                        Assert.IsTrue(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: default,
                            actual: result.Error);
                    }

                }

            }

        }

    }
}
