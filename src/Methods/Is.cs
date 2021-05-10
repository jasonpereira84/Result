using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace JasonPereira84.Result
{
    public partial struct Result
    {
        public Boolean IsSuccess => _internalHelpers.IsSuccess(this);

        public Boolean IsFailure => _internalHelpers.IsFailure(this);

        public Boolean IsUnknown => _internalHelpers.IsUnknown(this);

        public Boolean IsNotSuccess => _internalHelpers.IsNotSuccess(this);
    }

    public partial struct Result<TValue>
    {
        public Boolean IsSuccess => _internalHelpers.IsSuccess(this);

        public Boolean IsFailure => _internalHelpers.IsFailure(this);

        public Boolean IsUnknown => _internalHelpers.IsUnknown(this);

        public Boolean IsNotSuccess => _internalHelpers.IsNotSuccess(this);
    }

    public partial struct Result<TError, TValue>
    {
        public Boolean IsSuccess => _internalHelpers.IsSuccess(this);

        public Boolean IsFailure => _internalHelpers.IsFailure(this);

        public Boolean IsUnknown => _internalHelpers.IsUnknown(this);

        public Boolean IsNotSuccess => _internalHelpers.IsNotSuccess(this);
    }
}
