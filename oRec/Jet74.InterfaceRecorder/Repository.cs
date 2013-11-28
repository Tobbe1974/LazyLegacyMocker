

namespace Jet74.InterfaceRecorder
{
    public class Repository
    {
        public T AddObjectPrinter<T>(T i) where T : class 
        {
            return new Interceptor<T, ObjectPrinter>(i).Proxy;
        }
    }
}
