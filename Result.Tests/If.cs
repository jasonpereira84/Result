using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JasonPereira84.Result.Tests
{
    public partial class Test_Result
    {
        [TestMethod]
        public void If()
        {
            {
                {
                    var result = new Result<Object, Object>();
                    result.Overall = null;

                    Assert.AreEqual(
                        expected: 3,
                        actual: result.If(
                        (e, v) => 1,
                        (e, v) => 2,
                        (e, v) => 3));
                }

                {
                    var result = new Result<Object, Object>();
                    result.Overall = false;

                    Assert.AreEqual(
                        expected: 2,
                        actual: result.If(
                        (e, v) => 1,
                        (e, v) => 2,
                        (e, v) => 3));
                }

                {
                    var result = new Result<Object, Object>();
                    result.Overall = true;

                    Assert.AreEqual(
                        expected: 1,
                        actual: result.If(
                        (e, v) => 1,
                        (e, v) => 2,
                        (e, v) => 3));
                }

            }

            {
                {
                    var result = new Result<Object, Object>();
                    result.Overall = null;

                    var retVal = default(Int32);
                    result.If(
                        (e, v) => retVal = 1,
                        (e, v) => retVal = 2,
                        (e, v) => retVal = 3);
                    Assert.AreEqual(
                        expected: 3,
                        actual: retVal);
                }

                {
                    var result = new Result<Object, Object>();
                    result.Overall = false;

                    var retVal = default(Int32);
                    result.If(
                        (e, v) => retVal = 1,
                        (e, v) => retVal = 2,
                        (e, v) => retVal = 3);
                    Assert.AreEqual(
                        expected: 2,
                        actual: retVal);
                }

                {
                    var result = new Result<Object, Object>();
                    result.Overall = true;

                    var retVal = default(Int32);
                    result.If(
                        (e, v) => retVal = 1,
                        (e, v) => retVal = 2,
                        (e, v) => retVal = 3);
                    Assert.AreEqual(
                        expected: 1,
                        actual: retVal);
                }

            }

        }

    }
}
