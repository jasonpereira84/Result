namespace JasonPereira84.Result
{
    public partial class Result
    {
        public Result ToUnknown()
        {
            Overall = null;
            return this;
        }

        public Result ToFailure()
        {
            Overall = false;
            return this;
        }

        public Result ToSuccess()
        {
            Overall = true;
            return this;
        }
    }

    public partial class Result<TValue>
    {
        public Result<TValue> ToUnknown(TValue value)
        {
            Overall = null;
            Value = value;
            return this;
        }
        public new Result<TValue> ToUnknown()
        {
            Overall = null;
            return this;
        }

        public Result<TValue> ToFailure(TValue value)
        {
            Overall = false;
            Value = value;
            return this;
        }
        public new Result<TValue> ToFailure()
        {
            Overall = false;
            return this;
        }

        public Result<TValue> ToSuccess(TValue value)
        {
            Overall = true;
            Value = value;
            return this;
        }
        private new Result<TValue> ToSuccess()
        {
            Overall = true;
            return this;
        }
    }

    public partial class Result<TValue, TError>
    {
        public Result<TValue, TError> ToUnknown(TValue value, TError error)
        {
            Overall = null;
            Value = value;
            Error = error;
            return this;
        }
        public new Result<TValue, TError> ToUnknown(TValue value)
        {
            Overall = null;
            Value = value;
            return this;
        }
        public Result<TValue, TError> ToUnknown(TError error)
        {
            Overall = null;
            Error = error;
            return this;
        }
        public new Result<TValue, TError> ToUnknown()
        {
            Overall = null;
            return this;
        }

        public Result<TValue, TError> ToFailure(TValue value, TError error)
        {
            Overall = false;
            Value = value;
            Error = error;
            return this;
        }
        private new Result<TValue, TError> ToFailure(TValue value)
        {
            Overall = false;
            Value = value;
            return this;
        }
        public Result<TValue, TError> ToFailure(TError error)
        {
            Overall = false;
            Error = error;
            return this;
        }
        private new Result<TValue, TError> ToFailure()
        {
            Overall = false;
            return this;
        }

        public Result<TValue, TError> ToSuccess(TValue value, TError error)
        {
            Overall = true;
            Value = value;
            Error = error;
            return this;
        }
        public new Result<TValue, TError> ToSuccess(TValue value)
        {
            Overall = true;
            Value = value;
            return this;
        }
        private Result<TValue, TError> ToSuccess(TError error)
        {
            Overall = true;
            Error = error;
            return this;
        }
        private new Result<TValue, TError> ToSuccess()
        {
            Overall = true;
            return this;
        }
    }

}