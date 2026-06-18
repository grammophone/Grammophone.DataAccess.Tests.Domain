using System.Collections.Generic;

namespace Grammophone.DataAccess.Tests.Domain
{
	/// <summary>
	/// Parent entity for query translation tests.
	/// </summary>
	public class Parent
	{
		/// <summary>The primary key.</summary>
		public int ID { get; set; }

		/// <summary>The parent name.</summary>
		public string Name { get; set; }

		/// <summary>The child collection.</summary>
		public virtual ICollection<Child> Children { get; set; } = new HashSet<Child>();
	}
}
