using System;

namespace JasonPereira84.Result
{
    public class ResultException<TValue> : ResultException<Exception, TValue>
    {
        public ResultException(Nullable<Boolean> overall, Exception error, TValue value)
            : base(overall, error, value)
        {
        }
    }

}