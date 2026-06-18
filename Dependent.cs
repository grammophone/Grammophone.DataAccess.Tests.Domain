namespace Grammophone.DataAccess.Tests.Domain
{
	/// <summary>
	/// Dependent entity for nested eager-loading tests.
	/// </summary>
	public class Dependent
	{
		/// <summary>The primary key.</summary>
		public int ID { get; set; }

		/// <summary>The dependent name.</summary>
		public string Name { get; set; }
	}
}
