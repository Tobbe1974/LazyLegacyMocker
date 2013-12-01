namespace Jet74.LazyLegacyMocker.MockObjects
{
	public enum Indetation
	{
		Spaces = 0,
		Tabs = 1
	}

	public enum Target
	{
		File = 0,
		Memory = 1,
	}
	
	public class MockObjectProperties
	{
		public MockObjectProperties()
		{
			Indetation = Indetation.Tabs;
			IdentationSize = 1;
			WriteUsings = true;
			WriteFullClassName = false;
			IdentChildObject = true;
			OnlyWriteNoneDefaultProperties = true;
			TargetType = Target.File;
		}

		/// <summary>
		/// Sets the identation type Tabs or Spaces, default Tabs
		/// </summary>
		public Indetation Indetation { get; set; }
		/// <summary>
		/// Sets how much we ident, default 1
		/// </summary>
		public int IdentationSize { get; set; }
		/// <summary>
		/// Write usings at start, default true
		/// </summary>
		public bool WriteUsings { get; set; }
		/// <summary>
		/// If we should write the full classname of classes, default false
		/// </summary>
		public bool WriteFullClassName { get; set; }
		/// <summary>
		/// If a child object should be indented, default true
		/// </summary>
		public bool IdentChildObject { get; set; }
		/// <summary>
		/// Only write the properties that does have a vaule that differs from the default when instantiated
		/// </summary>
		public bool OnlyWriteNoneDefaultProperties { get; set; }
		/// <summary>
		/// Sets the output targert, default File
		/// </summary>
		public Target TargetType { get; set; }
		
	}
}
