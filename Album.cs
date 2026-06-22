using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Grammophone.DataAccess.Collections;

namespace Grammophone.DataAccess.Tests.Domain
{
	/// <summary>
	/// Album entity for query translation tests.
	/// </summary>
	public class Album
	{
		/// <summary>The primary key.</summary>
		public virtual int ID { get; set; }

		/// <summary>The album name.</summary>
		public virtual string Name { get; set; }

		/// <summary>The release date.</summary>
		public virtual DateTime? ReleaseDate { get; set; }

		/// <summary>The artist foreign key.</summary>
		public virtual int ArtistID { get; set; }

		/// <summary>The artist reference.</summary>
		public virtual Artist Artist { get; set; }

		/// <summary>The genre foreign key.</summary>
		public virtual int GenreID { get; set; }

		/// <summary>The genre reference.</summary>
		public virtual Genre Genre { get; set; }

		/// <summary>The album tracks.</summary>
		public virtual ICollection<Track> Tracks { get; set; } = new ObservableHashSet<Track>();
	}
}
