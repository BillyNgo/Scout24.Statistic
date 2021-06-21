namespace Scout24.Statistic
{
    public class SearchIndexTarget
    {
        public SearchIndexTarget(string target)
        {
            Target = target;
        }

        public string Target { get; protected set; }
    }
}
