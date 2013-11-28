using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace Jet74.InterfaceRecorder
{
    internal class ObjectPrinter : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();

            PrintObjectTree(invocation);
        }

        private void PrintObjectTree(IInvocation invocation)
        {
            string fileName = CreateFilename(invocation);
            
        }

        private string CreateFilename(IInvocation invocation)
        {
            var builder = new StringBuilder();

            builder.Append(invocation.InvocationTarget.GetType().FullName);
            builder.Append(".");
            builder.Append(invocation.Method.Name);
            builder.Append("(");

            foreach (var arg in invocation.Arguments)
            {
                builder.Append(arg);
            }
            builder.Append(")");
            return CleanIllegalChars(builder.ToString());
        }

        private static string CleanIllegalChars(string result)
        {
            //TODO : Implemet
            return result;
        }
    }
}
