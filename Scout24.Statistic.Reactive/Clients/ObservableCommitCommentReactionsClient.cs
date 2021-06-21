﻿using System;
using System.Reactive.Threading.Tasks;
using Scout24.Statistic.Reactive.Internal;

namespace Scout24.Statistic.Reactive
{
    /// <summary>
    /// A client for GitHub's Reactions API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developer.github.com/v3/reactions">Reactions API documentation</a> for more information.
    /// </remarks>
    public class ObservableCommitCommentReactionsClient : IObservableCommitCommentReactionsClient
    {
        readonly ICommitCommentReactionsClient _client;
        readonly IConnection _connection;

        public ObservableCommitCommentReactionsClient(IGitHubClient client)
        {
            Ensure.ArgumentNotNull(client, nameof(client));

            _client = client.Reaction.CommitComment;
            _connection = client.Connection;
        }

        /// <summary>
        /// Creates a reaction for a specified Commit Comment
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#create-reaction-for-a-commit-comment</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The comment id</param>
        /// <param name="reaction">The reaction to create</param>
        /// <returns></returns>
        public IObservable<Reaction> Create(string owner, string name, int number, NewReaction reaction)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));
            Ensure.ArgumentNotNull(reaction, nameof(reaction));

            return _client.Create(owner, name, number, reaction).ToObservable();
        }

        /// <summary>
        /// Creates a reaction for a specified Commit Comment
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#create-reaction-for-a-commit-comment</remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="number">The comment id</param>
        /// <param name="reaction">The reaction to create </param>
        /// <returns></returns>
        public IObservable<Reaction> Create(long repositoryId, int number, NewReaction reaction)
        {
            Ensure.ArgumentNotNull(reaction, nameof(reaction));

            return _client.Create(repositoryId, number, reaction).ToObservable();
        }

        /// <summary>
        /// List reactions for a specified Commit Comment
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#list-reactions-for-a-commit-comment</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The comment id</param>        
        /// <returns></returns>
        public IObservable<Reaction> GetAll(string owner, string name, int number)
        {
            return GetAll(owner, name, number, ApiOptions.None);
        }

        /// <summary>
        /// List reactions for a specified Commit Comment
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#list-reactions-for-a-commit-comment</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The comment id</param>
        /// <param name="options">Options for changing the API response</param> 
        /// <returns></returns>
        public IObservable<Reaction> GetAll(string owner, string name, int number, ApiOptions options)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, nameof(owner));
            Ensure.ArgumentNotNullOrEmptyString(name, nameof(name));
            Ensure.ArgumentNotNull(options, nameof(options));

            return _connection.GetAndFlattenAllPages<Reaction>(ApiUrls.CommitCommentReactions(owner, name, number), null, AcceptHeaders.ReactionsPreview, options);
        }

        /// <summary>
        /// List reactions for a specified Commit Comment
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#list-reactions-for-a-commit-comment</remarks>
        /// <param name="repositoryId">The owner of the repository</param>
        /// <param name="number">The comment id</param>        
        /// <returns></returns>
        public IObservable<Reaction> GetAll(long repositoryId, int number)
        {
            return GetAll(repositoryId, number, ApiOptions.None);
        }

        /// <summary>
        /// List reactions for a specified Commit Comment
        /// </summary>
        /// <remarks>https://developer.github.com/v3/reactions/#list-reactions-for-a-commit-comment</remarks>
        /// <param name="repositoryId">The owner of the repository</param>
        /// <param name="number">The comment id</param>
        /// <param name="options">Options for changing the API response</param>
        /// <returns></returns>
        public IObservable<Reaction> GetAll(long repositoryId, int number, ApiOptions options)
        {
            Ensure.ArgumentNotNull(options, nameof(options));

            return _connection.GetAndFlattenAllPages<Reaction>(ApiUrls.CommitCommentReactions(repositoryId, number), null, AcceptHeaders.ReactionsPreview, options);
        }
    }
}
