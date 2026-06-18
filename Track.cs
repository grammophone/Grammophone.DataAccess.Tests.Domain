namespace Grammophone.DataAccess.Tests.Domain
{
	/// <summary>
	/// Track entity for query translation tests.
	/// </summary>
	public class Track
	{
		/// <summary>The primary key.</summary>
		public int ID { get; set; }

		/// <summary>The track name.</summary>
		public string Name { get; set; }

		/// <summary>The track number in the album.</summary>
		public int Number { get; set; }

		/// <summary>The duration in seconds.</summary>
		public int DurationSeconds { get; set; }

		/// <summary>The album foreign key.</summary>
		public int AlbumID { get; set; }

		/// <summary>The album reference.</summary>
		public virtual Album Album { get; set; }

		/// <summary>The genre foreign key.</summary>
		public int GenreID { get; set; }

		/// <summary>The genre reference.</summary>
		public virtual Genre Genre { get; set; }
	}
}
