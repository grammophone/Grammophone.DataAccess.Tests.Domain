using System;

namespace Grammophone.DataAccess.Tests.Domain
{
	/// <summary>
	/// Event entity for date/time query function tests.
	/// </summary>
	public class EventRecord
	{
		/// <summary>The primary key.</summary>
		public int ID { get; set; }

		/// <summary>The event name.</summary>
		public string Name { get; set; }

		/// <summary>The start time.</summary>
		public DateTime? StartTime { get; set; }

		/// <summary>The end time.</summary>
		public DateTime? EndTime { get; set; }
	}
}
