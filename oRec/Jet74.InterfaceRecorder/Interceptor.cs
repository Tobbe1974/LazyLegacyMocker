using System;
using Castle.DynamicProxy;
using Jet74.InterfaceRecorder.Exceptions;

namespace Jet74.InterfaceRecorder
{
    internal class Interceptor<T, TS> 
        where T : class
        where TS : IInterceptor, new()
    {
        public T OriginalType { get; private set; }
        public T Proxy { get; private set; }

        internal Interceptor(T t)
        {
            OriginalType = t;
            var type = typeof (T);

            CreateProxy(t, type);
        }

        private void CreateProxy(T t, Type type)
        {
            var proxyGenerator = new ProxyGenerator();
            if (type.IsInterface)
            {
                Proxy = proxyGenerator.CreateInterfaceProxyWithTargetInterface(t, new TS());
                return;
            }

            if (type.IsClass)
            {
                if (type.IsSealed)
                    throw new SealedClassNotSupportedException();

                Proxy = proxyGenerator.CreateClassProxyWithTarget(t, new TS());
                return;
            }
            throw new TypeNotSupportedException();
        }
    }
}
