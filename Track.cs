namespace Grammophone.DataAccess.Tests.Domain
{
	/// <summary>
	/// Track entity for query translation tests.
	/// </summary>
	public class Track
	{
		/// <summary>The primary key.</summary>
		public virtual int ID { get; set; }

		/// <summary>The track name.</summary>
		public virtual string Name { get; set; }

		/// <summary>The track number in the album.</summary>
		public virtual int Number { get; set; }

		/// <summary>The duration in seconds.</summary>
		public virtual int DurationSeconds { get; set; }

		/// <summary>The album foreign key.</summary>
		public virtual int AlbumID { get; set; }

		/// <summary>The album reference.</summary>
		public virtual Album Album { get; set; }

		/// <summary>The genre foreign key.</summary>
		public virtual int GenreID { get; set; }

		/// <summary>The genre reference.</summary>
		public virtual Genre Genre { get; set; }
	}
}
