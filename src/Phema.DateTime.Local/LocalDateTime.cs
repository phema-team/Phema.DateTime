namespace Phema.DateTime.Internal
{
	using System;

	internal sealed class LocalDateTime : IDateTime
	{
		public DateTime Now => DateTime.Now;
	}
}