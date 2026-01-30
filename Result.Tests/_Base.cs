using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JasonPereira84.Result.Tests
{
    [TestClass]
    public partial class Test_Result
    {
        [TestMethod]
#pragma warning disable IDE1006 // Naming Styles
        public void ctor()
#pragma warning restore IDE1006 // Naming Styles
        {

            {
                var result = new Result();

                Assert.IsNull(result.Overall);
            }

            {

                {
                    var result = new Result<Int32>(5);

                    Assert.IsNull(result.Overall);
                    Assert.AreEqual(
                        expected: 5,
                        actual: result.Value);
                }

                {
                    var result = new Result<Int32>();

                    Assert.IsNull(result.Overall);
                    Assert.AreEqual(
                        expected: default,
                        actual: result.Value);
                }

            }

            {

                {
                    var result = new Result<Int32, Decimal>(5, 10m);

                    Assert.IsNull(result.Overall);
                    Assert.AreEqual(
                        expected: 5,
                        actual: result.Value);
                    Assert.AreEqual(
                        expected: 10,
                        actual: result.Error);
                }

                {
                    var result = new Result<Int32, Decimal>(5);

                    Assert.IsNull(result.Overall);
                    Assert.AreEqual(
                        expected: 5,
                        actual: result.Value);
                    Assert.AreEqual(
                        expected: default,
                        actual: result.Error);
                }

                {
                    var result = new Result<Int32, Decimal>(10m);

                    Assert.IsNull(result.Overall);
                    Assert.AreEqual(
                        expected: default,
                        actual: result.Value);
                    Assert.AreEqual(
                        expected: 10m,
                        actual: result.Error);
                }

                {
                    var result = new Result<Int32, Decimal>();

                    Assert.IsNull(result.Overall);
                    Assert.AreEqual(
                        expected: default,
                        actual: result.Value);
                    Assert.AreEqual(
                        expected: default,
                        actual: result.Error);
                }
            }

        }

    }
}
