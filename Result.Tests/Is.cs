using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JasonPereira84.Result.Tests
{
    public partial class Test_Result
    {
        [TestMethod]
        public void Is()
        {
            {
                var result = new Result<Object, Object>();
                result.Overall = null;

                Assert.IsFalse(result.NotIsUnknown);
                Assert.IsTrue(result.NotIsFailure);
                Assert.IsTrue(result.NotIsSuccess);
            }

            {
                var result = new Result<Object, Object>();
                result.Overall = false;

                Assert.IsTrue(result.NotIsUnknown);
                Assert.IsFalse(result.NotIsFailure);
                Assert.IsTrue(result.NotIsSuccess);
            }

            {
                var result = new Result<Object, Object>();
                result.Overall = true;

                Assert.IsTrue(result.NotIsUnknown);
                Assert.IsTrue(result.NotIsFailure);
                Assert.IsFalse(result.NotIsSuccess);
            }

        }

    }
}
