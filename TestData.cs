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

		/// <summary>Album release date.</summary>
		public static readonly DateTime AlbumReleaseDate = new DateTime(2024, 1, 1);
	}
}
