using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace JasonPereira84.Result
{
    public partial struct Result
    {
        public String ToString(String format)
            => format
                .Replace($"{{{nameof(Overall)}}}", Overall.ToString())
                .Replace($"{{{nameof(Error)}}}", Error.EvaluateSanity().Value);

        public override String ToString()
            => ToString(
                _internalHelpers.GetFormat("{{0}}",
                    _internalHelpers.GetFormatForSet(nameof(Overall)),
                    _internalHelpers.GetFormatForPair(nameof(Error))));
    }

    public partial struct Result<TValue>
    {

        public String ToString(String format, Func<TValue, String> valueStringifier = null)
            => format
                .Replace($"{{{nameof(Overall)}}}", Overall.ToString())
                .Replace($"{{{nameof(Error)}}}", Error.EvaluateSanity().Value)
                .Replace($"{{{nameof(Value)}}}", valueStringifier.SafeInvoke(Value));

        public override String ToString()
            => ToString(
                _internalHelpers.GetFormat("{{0}}",
                    _internalHelpers.GetFormatForSet(nameof(Overall)),
                    _internalHelpers.GetFormatForPair(nameof(Error)),
                    _internalHelpers.GetFormatForPair(nameof(Value))));
    }

    public partial struct Result<TError, TValue>
    {
        public String ToString(String format, Func<TValue, String> valueStringifier = null, Func<TError, String> errorStringifier = null)
            => format
                .Replace($"{{{nameof(Overall)}}}", Overall.ToString())
                .Replace($"{{{nameof(Error)}}}", errorStringifier.SafeInvoke(Error))
                .Replace($"{{{nameof(Value)}}}", valueStringifier.SafeInvoke(Value));

        public override String ToString()
            => ToString(
                _internalHelpers.GetFormat("{{0}}",
                    _internalHelpers.GetFormatForSet(nameof(Overall)),
                    _internalHelpers.GetFormatForPair(nameof(Error)),
                    _internalHelpers.GetFormatForPair(nameof(Value))));
    }
}
