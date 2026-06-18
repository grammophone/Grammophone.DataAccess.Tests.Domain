using System;
using System.Collections.Generic;

namespace Grammophone.DataAccess.Tests.Domain
{
	/// <summary>
	/// Album entity for query translation tests.
	/// </summary>
	public class Album
	{
		/// <summary>The primary key.</summary>
		public int ID { get; set; }

		/// <summary>The album name.</summary>
		public string Name { get; set; }

		/// <summary>The release date.</summary>
		public DateTime? ReleaseDate { get; set; }

		/// <summary>The artist foreign key.</summary>
		public int ArtistID { get; set; }

		/// <summary>The artist reference.</summary>
		public virtual Artist Artist { get; set; }

		/// <summary>The genre foreign key.</summary>
		public int GenreID { get; set; }

		/// <summary>The genre reference.</summary>
		public virtual Genre Genre { get; set; }

		/// <summary>The album tracks.</summary>
		public virtual ICollection<Track> Tracks { get; set; } = new HashSet<Track>();
	}
}
