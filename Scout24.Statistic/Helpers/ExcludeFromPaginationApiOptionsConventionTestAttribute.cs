using System;

namespace Scout24.Statistic
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class ExcludeFromPaginationApiOptionsConventionTestAttribute : Attribute
    {
        public ExcludeFromPaginationApiOptionsConventionTestAttribute(string note)
        {
            Note = note;
        }

        public string Note { get; private set; }
    }
}
