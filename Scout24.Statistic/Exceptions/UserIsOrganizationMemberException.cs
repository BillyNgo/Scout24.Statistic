﻿using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net;
#if !NO_SERIALIZABLE
using System.Runtime.Serialization;
#endif

namespace Scout24.Statistic
{
    /// <summary>
    /// Represents an error that occurs when trying to remove an 
    /// outside collaborator that is a member of the organization
    /// </summary>
#if !NO_SERIALIZABLE
    [Serializable]
#endif
    [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors",
        Justification = "These exceptions are specific to the GitHub API and not general purpose exceptions")]
    public class UserIsOrganizationMemberException : ApiException
    {
        /// <summary>
        /// Constructs an instance of the <see cref="UserIsOrganizationMemberException"/> class.
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        public UserIsOrganizationMemberException(IResponse response) : this(response, null)
        {
        }

        /// <summary>
        /// Constructs an instance of the <see cref="UserIsOrganizationMemberException"/> class.
        /// </summary>
        /// <param name="response">The HTTP payload from the server</param>
        /// <param name="innerException">The inner exception</param>
        public UserIsOrganizationMemberException(IResponse response, ApiException innerException)
            : base(response, innerException)
        {
            Debug.Assert(response != null && response.StatusCode == (HttpStatusCode)422,
                "UserIsOrganizationMemberException created with the wrong HTTP status code");
        }

        // https://developer.github.com/v3/orgs/outside_collaborators/#response-if-user-is-a-member-of-the-organization
        public override string Message => ApiErrorMessageSafe ?? "User could not be removed as an outside collaborator.";

#if !NO_SERIALIZABLE
        /// <summary>
        /// Constructs an instance of <see cref="UserIsOrganizationMemberException"/>.
        /// </summary>
        /// <param name="info">
        /// The <see cref="SerializationInfo"/> that holds the
        /// serialized object data about the exception being thrown.
        /// </param>
        /// <param name="context">
        /// The <see cref="StreamingContext"/> that contains
        /// contextual information about the source or destination.
        /// </param>
        protected UserIsOrganizationMemberException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}
