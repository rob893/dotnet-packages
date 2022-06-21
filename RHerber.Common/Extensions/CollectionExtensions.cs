using System;
using System.Collections.Generic;
using System.Linq;

namespace RHerber.Common.Extensions
{
    public static class CollectionExtensions
    {
        public static long Percentile(this IEnumerable<long> source, double percentile, bool isSourceSorted = false)
        {
            if (percentile < 0 || percentile > 1)
            {
                throw new ArgumentException($"{nameof(percentile)} must be >= 0 and <= 1");
            }

            if (source is long[] asArray)
            {
                var index = (int)Math.Floor(percentile * (asArray.Length - 1));

                if (isSourceSorted)
                {
                    return asArray[index];
                }

                var copy = source.ToArray();
                Array.Sort(copy);

                return copy[index];
            }

            var copyAsArray = source.ToArray();
            var i = (int)Math.Floor(percentile * (copyAsArray.Length - 1));

            Array.Sort(copyAsArray);

            return copyAsArray[i];
        }
    }
}