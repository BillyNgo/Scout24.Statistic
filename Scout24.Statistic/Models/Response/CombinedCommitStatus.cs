using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class CombinedCommitStatus
    {
        public CombinedCommitStatus() { }

        public CombinedCommitStatus(CommitState state, string sha, int totalCount, IReadOnlyList<CommitStatus> statuses, Repository repository)
        {
            State = state;
            Sha = sha;
            TotalCount = totalCount;
            Statuses = statuses;
            Repository = repository;
        }

        /// <summary>
        /// The combined state of the commits.
        /// </summary>
        public StringEnum<CommitState> State { get; protected set; }

        /// <summary>
        /// The SHA of the reference.
        /// </summary>
        public string Sha { get; protected set; }

        /// <summary>
        /// The total number of statuses.
        /// </summary>
        public int TotalCount { get; protected set; }

        /// <summary>
        /// The statuses.
        /// </summary>
        public IReadOnlyList<CommitStatus> Statuses { get; protected set; }

        /// <summary>
        /// The repository of the reference.
        /// </summary>
        public Repository Repository { get; protected set; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "SHA: {0}, State: {1}, TotalCount: {2}", Sha, State, TotalCount);
            }
        }
    }
}