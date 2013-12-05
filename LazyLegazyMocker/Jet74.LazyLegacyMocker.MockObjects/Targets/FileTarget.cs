using System.IO;
using System.Text;
using Castle.DynamicProxy;

namespace Jet74.LazyLegacyMocker.MockObjects.Targets
{
	public class FileTarget : ITarget
	{
		public StreamWriter GetWriter(IInvocation invocation)
		{
			string fileName = CreateFilename(invocation);
			CheckFileExist(fileName);

			return new StreamWriter(File.OpenWrite(fileName));
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
			return CleanFilename(builder.ToString());
		}

		private void CheckFileExist(string fileName)
		{
			if (File.Exists(fileName))
			{	
				//TODO: Impelemt better behavior
				File.Delete(fileName);
			}
		}

		private static string CleanFilename(string result)
		{
			//TODO : Implemet
			return result;
		}
	}
}
