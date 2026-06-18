namespace Grammophone.DataAccess.Tests.Domain
{
	/// <summary>
	/// Music domain container contract used by the provider-independent test cases.
	/// </summary>
	public interface IMusicDomainContainer : IDomainContainer
	{
		/// <summary>Artists.</summary>
		IEntitySet<Artist> Artists { get; }

		/// <summary>Albums.</summary>
		IEntitySet<Album> Albums { get; }

		/// <summary>Tracks.</summary>
		IEntitySet<Track> Tracks { get; }

		/// <summary>Genres.</summary>
		IEntitySet<Genre> Genres { get; }
	}
}
