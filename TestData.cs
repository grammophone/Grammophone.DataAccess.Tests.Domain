using System;

namespace Grammophone.DataAccess.Tests.Domain
{
	/// <summary>
	/// Shared test-domain constants.
	/// </summary>
	public static class TestData
	{
		/// <summary>Artist name.</summary>
		public const string ArtistName = "The Example Band";

		/// <summary>Album name.</summary>
		public const string AlbumName = "Blue Integration";

		/// <summary>Genre name.</summary>
		public const string GenreName = "Progressive Tests";

		/// <summary>Track name.</summary>
		public const string TrackName = "Opening Assertion";

		/// <summary>Track duration in seconds.</summary>
		public const int TrackDurationSeconds = 245;

		/// <summary>Updated track duration in seconds.</summary>
		public const int UpdatedTrackDurationSeconds = 300;

		/// <summary>Batch operation artist name prefix.</summary>
		public const string SetOperationArtistNamePrefix = "Set Operation Artist";

		/// <summary>Batch operation album name prefix.</summary>
		public const string SetOperationAlbumNamePrefix = "Set Operation Album";

		/// <summary>Batch operation original genre name prefix.</summary>
		public const string SetOperationOriginalGenreNamePrefix = "Set Operation Original Genre";

		/// <summary>Batch operation target genre name prefix.</summary>
		public const string SetOperationTargetGenreNamePrefix = "Set Operation Target Genre";

		/// <summary>First batch operation track name prefix.</summary>
		public const string SetOperationTrackOneNamePrefix = "Set Operation Track One";

		/// <summary>Second batch operation track name prefix.</summary>
		public const string SetOperationTrackTwoNamePrefix = "Set Operation Track Two";

		/// <summary>Album release date.</summary>
		public static readonly DateTime AlbumReleaseDate = new DateTime(2024, 1, 1);
	}
}
