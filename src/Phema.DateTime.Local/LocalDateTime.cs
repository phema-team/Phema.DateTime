namespace Phema.DateTime
{
    using System;
    
    internal class LocalDateTime : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}