using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class CheckSuite
    {
        public CheckSuite()
        {
        }

        public CheckSuite(long id, string headBranch, string headSha, CheckStatus status, CheckConclusion? conclusion, string url, string before, string after, IReadOnlyList<PullRequest> pullRequests, GitHubApp app, Repository repository)
        {
            Id = id;
            HeadBranch = headBranch;
            HeadSha = headSha;
            Status = status;
            Conclusion = conclusion;
            Url = url;
            Before = before;
            After = after;
            PullRequests = pullRequests;
            App = app;
            Repository = repository;
        }

        /// <summary>
        /// The Id of the check suite
        /// </summary>
        public long Id { get; protected set; }

        /// <summary>
        /// The branch the check suite is associated with
        /// </summary>
        public string HeadBranch { get; protected set; }

        /// <summary>
        /// The SHA of the head commit in the push that created the check suite
        /// </summary>
        public string HeadSha { get; protected set; }

        /// <summary>
        /// The summarized status of the check runs included in the check suite
        /// </summary>
        public StringEnum<CheckStatus> Status { get; protected set; }

        /// <summary>
        /// The summarized conclusion of the check runs included in the check suite
        /// </summary>
        public StringEnum<CheckConclusion>? Conclusion { get; protected set; }

        /// <summary>
        /// The GitHub API URL of the check suite
        /// </summary>
        public string Url { get; protected set; }

        /// <summary>
        /// The hash of the commit prior to the push that created the check suite
        /// </summary>
        public string Before { get; protected set; }

        /// <summary>
        /// The hash of the commit after the push that created the check suite (or HeadSha if no later commits exist)
        /// </summary>
        public string After { get; protected set; }

        /// <summary>
        /// The pull requests that are associated with the check suite
        /// </summary>
        public IReadOnlyList<PullRequest> PullRequests { get; protected set; }

        /// <summary>
        /// The GitHub App for the check suite
        /// </summary>
        public GitHubApp App { get; protected set; }

        /// <summary>
        /// The repository for the check suite
        /// </summary>
        public Repository Repository { get; protected set; }

        internal string DebuggerDisplay => string.Format(CultureInfo.InvariantCulture, "Id: {0}, HeadBranch: {1}, HeadSha: {2}, Conclusion: {3}", Id, HeadBranch, HeadSha, Conclusion);
    }
}
