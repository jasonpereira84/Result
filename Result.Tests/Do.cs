using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JasonPereira84.Result.Tests
{
    public partial class Test_Result
    {
        [TestMethod]
        public void Do()
        {

            {

                {
                    var result = new Result();

                    Assert.AreEqual(
                        expected: 3,
                        actual: result.Do(
                        onSuccess: () => 1,
                        onFailure: () => 2,
                        onUnknown: () => 3));
                }

                {
                    var result = new Result();
                    result.Overall = false;

                    Assert.AreEqual(
                        expected: 2,
                        actual: result.Do(
                        onSuccess: () => 1,
                        onFailure: () => 2,
                        onUnknown: () => 3));
                }

                {
                    var result = new Result();
                    result.Overall = true;

                    Assert.AreEqual(
                        expected: 1,
                        actual: result.Do(
                        onSuccess: () => 1,
                        onFailure: () => 2,
                        onUnknown: () => 3));
                }

            }

            {

                {
                    var result = new Result<Int32>(5);

                    Assert.AreEqual(
                        expected: 3,
                        actual: result.Do(
                        onSuccess: (v) => 1,
                        onFailure: (v) => 2,
                        onUnknown: (v) => 3));
                }

                {
                    var result = new Result<Int32>(5);
                    result.Overall = false;

                    Assert.AreEqual(
                        expected: 2,
                        actual: result.Do(
                        onSuccess: (v) => 1,
                        onFailure: (v) => 2,
                        onUnknown: (v) => 3));
                }

                {
                    var result = new Result<Int32>(5);
                    result.Overall = true;

                    Assert.AreEqual(
                        expected: 1,
                        actual: result.Do(
                        onSuccess: (v) => 1,
                        onFailure: (v) => 2,
                        onUnknown: (v) => 3));
                }

            }

            {

                {
                    var result = new Result<Int32, Decimal>(5, 10m);

                    Assert.AreEqual(
                        expected: 3,
                        actual: result.Do(
                        onSuccess: (v, e) => 1,
                        onFailure: (v, e) => 2,
                        onUnknown: (v, e) => 3));
                }

                {
                    var result = new Result<Int32, Decimal>(5, 10m);
                    result.Overall = false;

                    Assert.AreEqual(
                        expected: 2,
                        actual: result.Do(
                        onSuccess: (v, e) => 1,
                        onFailure: (v, e) => 2,
                        onUnknown: (v, e) => 3));
                }

                {
                    var result = new Result<Int32, Decimal>(5, 10m);
                    result.Overall = true;

                    Assert.AreEqual(
                        expected: 1,
                        actual: result.Do(
                        onSuccess: (v, e) => 1,
                        onFailure: (v, e) => 2,
                        onUnknown: (v, e) => 3));
                }

            }

        }

    }
}
