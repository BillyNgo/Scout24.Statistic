using System;
using System.Reactive;
using System.Reactive.Threading.Tasks;

namespace Scout24.Statistic.Reactive
{
    public class ObservableReactionsClient : IObservableReactionsClient
    {
        readonly IReactionsClient _client;

        public ObservableReactionsClient(IGitHubClient client)
        {
            Ensure.ArgumentNotNull(client, nameof(client));

            _client = client.Reaction;

            CommitComment = new ObservableCommitCommentReactionsClient(client);
            Issue = new ObservableIssueReactionsClient(client);
            IssueComment = new ObservableIssueCommentReactionsClient(client);
            PullRequestReviewComment = new ObservablePullRequestReviewCommentReactionsClient(client);
        }

        /// <summary>
        /// Access GitHub's Reactions API for Commit Comments.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/reactions/
        /// </remarks>
        public IObservableCommitCommentReactionsClient CommitComment { get; private set; }

        /// <summary>
        /// Access GitHub's Reactions API for Issues.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/reactions/
        /// </remarks>
        public IObservableIssueReactionsClient Issue { get; private set; }

        /// <summary>
        /// Access GitHub's Reactions API for Issue Comments.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/reactions/
        /// </remarks>
        public IObservableIssueCommentReactionsClient IssueComment { get; private set; }

        /// <summary>
        /// Access GitHub's Reactions API for Pull Request Review Comments.
        /// </summary>
        /// <remarks>
        /// Refer to the API documentation for more information: https://developer.github.com/v3/reactions/
        /// </remarks>
        public IObservablePullRequestReviewCommentReactionsClient PullRequestReviewComment { get; private set; }

        /// <summary>
        /// Delete a reaction.
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#delete-a-reaction</remarks>        
        /// <param name="number">The reaction id</param>        
        /// <returns></returns>
        public IObservable<Unit> Delete(int number)
        {
            return _client.Delete(number).ToObservable();
        }
    }
}
