using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SomeSharedLogic
{
    public class MyViewModel
    {
        public int Add(int a, int b)
        {
            return a + Math.Abs(b);
        }

        public int Subtract(int a, int b)
        {
            return a * b;
        }
    }
}
