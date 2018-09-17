﻿using System;

namespace DateTimeRangeCore.DateTimeRange
{
	public class DateTimeRange : IEquatable<DateTimeRange>
	{
		public DateTime End { get; private set; }
		public TimeSpan Begin { get; private set; }
		public DateTimeRange(DateTime end, TimeSpan begin)
		{
			this.End = end;
			this.Begin = begin;
		}

		public bool Equals(DateTimeRange other)
			=> !ReferenceEquals(other, null)
				&& End == other.End
				&& Begin == other.Begin;

		public static bool operator ==(DateTimeRange dateTimeRange1, DateTimeRange dateTimeRange2)
			=> ReferenceEquals(dateTimeRange1, dateTimeRange2) 
			||(!ReferenceEquals(dateTimeRange1, null) 
			&& dateTimeRange1.Equals(dateTimeRange2));

		public static bool operator !=(DateTimeRange first, DateTimeRange second)
			=> !(first == second);

		public override bool Equals(object obj) 
			=> Equals(obj as DateTimeRange);

		public override int GetHashCode()
			=> End.GetHashCode();
	}
}