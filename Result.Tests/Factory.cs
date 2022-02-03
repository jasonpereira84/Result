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
                var result = Result<Object, Object>.FromUnknown();

                Assert.IsNull(result.Overall);
            }

            {
                var result = Result<Object, Object>.FromFailure(new Object());

                Assert.IsFalse(result.Overall);
            }

            {
                var result = Result<Object, Object>.FromSuccess(new Object());

                Assert.IsTrue(result.Overall);
            }

        }

    }
}
