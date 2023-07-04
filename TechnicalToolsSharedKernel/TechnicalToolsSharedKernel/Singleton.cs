using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalToolsSharedKernel
{
    public static class Singleton<T>
        where T : new()
    {
        private static T value = new();

        public static T Value { get { return Singleton<T>.value; } }
    }
}
