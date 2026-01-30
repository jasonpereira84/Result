using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JasonPereira84.Result.Tests
{
    public partial class Test_Result
    {
        [TestMethod]
        public void To()
        {

            {

                {
                    var result = new Result(true);
                    Assert.IsTrue(result.Overall);

                    result.ToUnknown();
                    Assert.IsNull(result.Overall);
                }

                {
                    var result = new Result(null);
                    Assert.IsNull(result.Overall);

                    result.ToFailure();
                    Assert.IsFalse(result.Overall);
                }

                {
                    var result = new Result(false);
                    Assert.IsFalse(result.Overall);

                    result.ToSuccess();
                    Assert.IsTrue(result.Overall);
                }

            }

            {

                {

                    {
                        var result = new Result<Int32>(true, 5);
                        Assert.IsTrue(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);

                        result.ToUnknown(6);
                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 6,
                            actual: result.Value);
                    }

                    {
                        var result = new Result<Int32>(true, 5);
                        Assert.IsTrue(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);

                        result.ToUnknown();
                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                    }

                }

                {

                    {
                        var result = new Result<Int32>(null, 5);
                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);

                        result.ToFailure(6);
                        Assert.IsFalse(result.Overall);
                        Assert.AreEqual(
                            expected: 6,
                            actual: result.Value);
                    }

                    {
                        var result = new Result<Int32>(null, 5);
                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);

                        result.ToFailure();
                        Assert.IsFalse(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                    }

                }

                {
                    var result = new Result<Int32>(false, 5);
                    Assert.IsFalse(result.Overall);
                    Assert.AreEqual(
                        expected: 5,
                        actual: result.Value);

                    result.ToSuccess(6);
                    Assert.IsTrue(result.Overall);
                    Assert.AreEqual(
                        expected: 6,
                        actual: result.Value);
                }

            }

            {

                {

                    {
                        var result = new Result<Int32, Decimal>(true, 5, 10m);
                        Assert.IsTrue(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);

                        result.ToUnknown(6, 11m);
                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 6,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 11m,
                            actual: result.Error);
                    }

                    {
                        var result = new Result<Int32, Decimal>(true, 5, 10m);
                        Assert.IsTrue(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);

                        result.ToUnknown(6);
                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 6,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);
                    }

                    {
                        var result = new Result<Int32, Decimal>(true, 5, 10m);
                        Assert.IsTrue(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);

                        result.ToUnknown(11m);
                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 11m,
                            actual: result.Error);
                    }

                    {
                        var result = new Result<Int32, Decimal>(true, 5, 10m);
                        Assert.IsTrue(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);

                        result.ToUnknown();
                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);
                    }

                }

                {

                    {
                        var result = new Result<Int32, Decimal>(null, 5, 10m);
                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);

                        result.ToFailure(6, 11m);
                        Assert.IsFalse(result.Overall);
                        Assert.AreEqual(
                            expected: 6,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 11m,
                            actual: result.Error);
                    }

                    {
                        var result = new Result<Int32, Decimal>(null, 5, 10m);
                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);

                        result.ToFailure(value: 6);
                        Assert.IsFalse(result.Overall);
                        Assert.AreEqual(
                            expected: 6,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);
                    }

                    {
                        var result = new Result<Int32, Decimal>(null, 5, 10m);
                        Assert.IsNull(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);

                        result.ToFailure(11m);
                        Assert.IsFalse(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 11m,
                            actual: result.Error);
                    }

                }

                {

                    {
                        var result = new Result<Int32, Decimal>(false, 5, 10m);
                        Assert.IsFalse(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);

                        result.ToSuccess(6, 11m);
                        Assert.IsTrue(result.Overall);
                        Assert.AreEqual(
                            expected: 6,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 11m,
                            actual: result.Error);
                    }

                    {
                        var result = new Result<Int32, Decimal>(false, 5, 10m);
                        Assert.IsFalse(result.Overall);
                        Assert.AreEqual(
                            expected: 5,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);

                        result.ToSuccess(6);
                        Assert.IsTrue(result.Overall);
                        Assert.AreEqual(
                            expected: 6,
                            actual: result.Value);
                        Assert.AreEqual(
                            expected: 10m,
                            actual: result.Error);
                    }

                }

            }

        }
    }
}
