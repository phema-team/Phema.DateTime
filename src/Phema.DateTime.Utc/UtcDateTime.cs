namespace Phema.DateTime
{
    using System;
    
    internal class UtcDateTime : IDateTime
    {
        public DateTime Now => DateTime.UtcNow;
    }
}