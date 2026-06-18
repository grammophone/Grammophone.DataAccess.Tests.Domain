namespace Grammophone.DataAccess.Tests.Domain
{
	/// <summary>
	/// Domain container contract used by the provider-independent test cases.
	/// </summary>
	public interface ITestDomainContainer : IDomainContainer
	{
		/// <summary>Parents.</summary>
		IEntitySet<Parent> Parents { get; }

		/// <summary>Children.</summary>
		IEntitySet<Child> Children { get; }

		/// <summary>Dependents.</summary>
		IEntitySet<Dependent> Dependents { get; }

		/// <summary>Event records.</summary>
		IEntitySet<EventRecord> Events { get; }
	}
}
