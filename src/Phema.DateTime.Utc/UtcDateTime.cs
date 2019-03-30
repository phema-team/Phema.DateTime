namespace Phema.DateTime.Internal
{
	using System;

	internal class UtcDateTime : IDateTime
	{
		public DateTime Now => DateTime.UtcNow;
	}
}