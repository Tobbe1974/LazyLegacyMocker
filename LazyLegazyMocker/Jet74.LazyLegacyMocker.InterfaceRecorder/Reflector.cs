using System;
using System.Collections.Generic;
using System.Reflection;

namespace Jet74.LazyLegacyMocker.InterfaceRecorder
{
    internal class Reflector
    {
        internal static List<MethodInfo> GetMethods<T>(T @interface) where T : class
        {
            Type type = typeof (T);
            return
                new List<MethodInfo>(
                    type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly));
        }
    }
}
