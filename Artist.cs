using System.Collections.Generic;
using System.Collections.ObjectModel;
using Grammophone.DataAccess.Collections;

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
