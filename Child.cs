namespace Grammophone.DataAccess.Tests.Domain
{
	/// <summary>
	/// Child entity for query translation tests.
	/// </summary>
	public class Child
	{
		/// <summary>The primary key.</summary>
		public int ID { get; set; }

		/// <summary>The child name.</summary>
		public string Name { get; set; }

		/// <summary>The parent foreign key.</summary>
		public int ParentID { get; set; }

		/// <summary>The parent reference.</summary>
		public virtual Parent Parent { get; set; }

		/// <summary>The dependent foreign key.</summary>
		public int? DependentID { get; set; }

		/// <summary>The dependent reference.</summary>
		public virtual Dependent Dependent { get; set; }
	}
}
