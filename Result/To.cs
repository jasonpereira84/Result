namespace JasonPereira84.Result
{
    public partial class Result<TError, TValue>
    {
        public Result<TError, TValue> ToUnknown(TError error = default(TError), TValue value = default(TValue))
        {
            Overall = null;
            Error = error;
            Value = value;
            return this;
        }

        public Result<TError, TValue> ToFailure(TError error, TValue value = default(TValue))
        {
            Overall = false;
            Error = error;
            Value = value;
            return this;
        }

        public Result<TError, TValue> ToSuccess(TValue value, TError error = default(TError))
        {
            Overall = true;
            Error = error;
            Value = value;
            return this;
        }

    }

}