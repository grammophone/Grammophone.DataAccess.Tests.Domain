using System;

namespace Grammophone.DataAccess.Tests.Domain
{
	/// <summary>
	/// Shared test-domain constants.
	/// </summary>
	public static class TestData
	{
		/// <summary>Parent with children.</summary>
		public const string ParentWithChildrenName = "Parent with children";

		/// <summary>Dependent name.</summary>
		public const string DependentName = "Nested dependent";

		/// <summary>Event name.</summary>
		public const string EventName = "Long event";

		/// <summary>Event start time.</summary>
		public static readonly DateTime EventStartTime = new DateTime(2024, 1, 1);

		/// <summary>Event end time.</summary>
		public static readonly DateTime EventEndTime = new DateTime(2024, 1, 4);
	}
}
