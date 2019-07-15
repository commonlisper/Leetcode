using System;
using System.Collections.Generic;
using System.Linq;

namespace _961.NRepeatedElementInSize2NArray
{
    public class NRepeatedElementInSize2NArray
    {
        public int RepeatedNTimes(int[] A)
        {
            if (A == null)
            {
                throw new ArgumentNullException(nameof(A));
            }

            if (A.Length == 0)
            {
                return 0;
            }

            var counted = A.Select(element => KeyValuePair.Create(element, A.Count(el => el == element)));
            var result = counted.First(keyValue => keyValue.Value == A.Length / 2);

            return result.Key;
        }
    }
}
