using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelHack.Model.Contract
{
    public class Iterator : IEnumerable<int>
    {
        int[] array;

        public IEnumerator GetEnumerator()
        {
            foreach (int o in array)
            {
                yield return o;
            }
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            foreach (int o in array)
            {
                yield return o;
            }
        }
    }
}