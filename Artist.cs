using System.Collections.Generic;
using Grammophone.GenericContentModel;

namespace Grammophone.DataAccess.Tests.Domain
{
	/// <summary>
	/// Artist entity for query translation tests.
	/// </summary>
	public class Artist
	{
		/// <summary>The primary key.</summary>
		public virtual int ID { get; set; }

		/// <summary>The artist name.</summary>
		public virtual string Name { get; set; }

		/// <summary>The artist albums.</summary>
		public virtual ICollection<Album> Albums { get; set; } = new ObservableHashSet<Album>();
	}
}
