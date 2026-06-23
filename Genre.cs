using System.Collections.Generic;
using Grammophone.GenericContentModel;

namespace Grammophone.DataAccess.Tests.Domain
{
	/// <summary>
	/// Genre entity for query translation tests.
	/// </summary>
	public class Genre
	{
		/// <summary>The primary key.</summary>
		public virtual int ID { get; set; }

		/// <summary>The genre name.</summary>
		public virtual string Name { get; set; }

		/// <summary>The albums in this genre.</summary>
		public virtual ICollection<Album> Albums { get; set; } = new ObservableHashSet<Album>();

		/// <summary>The tracks in this genre.</summary>
		public virtual ICollection<Track> Tracks { get; set; } = new ObservableHashSet<Track>();
	}
}
