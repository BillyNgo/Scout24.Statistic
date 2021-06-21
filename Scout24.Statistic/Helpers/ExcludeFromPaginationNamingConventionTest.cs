using System;

namespace Scout24.Statistic
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class ExcludeFromPaginationNamingConventionTestAttribute : Attribute
    {
        public ExcludeFromPaginationNamingConventionTestAttribute()
        {
        }

        public ExcludeFromPaginationNamingConventionTestAttribute(string note)
        {
            Note = note;
        }

        public string Note { get; private set; }
    }
}
