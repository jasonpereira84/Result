using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace JasonPereira84.Result
{
    using Internal;

    public partial struct Result
    {
        public String ToString(String format)
            => format
                .Replace($"{{{nameof(Overall)}}}", Overall.ToString())
                .Replace($"{{{nameof(Error)}}}", Error.EvaluateSanity().Value);

        public override String ToString()
            => ToString(
                Helpers.GetFormat("{{0}}",
                    Helpers.GetFormatForSet(nameof(Overall)),
                    Helpers.GetFormatForPair(nameof(Error))));
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
                Helpers.GetFormat("{{0}}",
                    Helpers.GetFormatForSet(nameof(Overall)),
                    Helpers.GetFormatForPair(nameof(Error)),
                    Helpers.GetFormatForPair(nameof(Value))));
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
                Helpers.GetFormat("{{0}}",
                    Helpers.GetFormatForSet(nameof(Overall)),
                    Helpers.GetFormatForPair(nameof(Error)),
                    Helpers.GetFormatForPair(nameof(Value))));
    }
}
