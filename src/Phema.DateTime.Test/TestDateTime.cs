using Microsoft.Extensions.Options;
using Phema.DateTime.Test;

namespace Phema.DateTime.Internal
{
	using System;

	internal class TestDateTime : IDateTime
	{
		private readonly TestDateTimeOptions options;

		public TestDateTime(IOptions<TestDateTimeOptions> options)
		{
			this.options = options.Value;
		}

		public DateTime Now => options.DateTimeNow;
	}
}